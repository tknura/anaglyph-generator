using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Runtime.InteropServices;
using CsAnaglyphGenerationHelper;

// Autor: Tomasz Knura INF SSI gr.5 sem.5
// Temat: Generator anaglifów
// Wersja: 1.0
namespace anaglyph_generator {
    class AnaglyphGenerator {
        private byte[] leftPicture;
        private byte[] rightPicture;

        private int resultWidth;
        private int resultHeight;
        private Bitmap result;

        private long generationTime;
        private bool isAsmGenerationEnabled = false;

        private int partSize = 96;
        private int threadAmount = 1;

        private byte[] getDataByteArrayFromBitmapFile(String filePath) {
            Bitmap bmp = new Bitmap(filePath);
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat);
            int bytesAmount = Math.Abs(bmpData.Stride) * bmp.Height;
            var byteArray = new byte[bytesAmount];
            Marshal.Copy(bmpData.Scan0, byteArray, 0, bytesAmount);
            bmp.UnlockBits(bmpData);
            return byteArray;
        }
        
        private void setResultBitmapSize(String filePath) {
            Bitmap bmp = new Bitmap(filePath);
            resultWidth = bmp.Width;
            resultHeight = bmp.Height;
        }

        public AnaglyphGenerator(String leftPicturePath, String rightPicturePath) {
            leftPicture = getDataByteArrayFromBitmapFile(leftPicturePath);
            rightPicture = getDataByteArrayFromBitmapFile(rightPicturePath);
            setResultBitmapSize(leftPicturePath);
        }

        public long getGenerationTime() {
            return generationTime;
        }

        public void setAsmGeneration(bool value) {
            isAsmGenerationEnabled = value;
        }

        public void setThreadAmount(int threads) {
            threadAmount = threads;
        }

        public Bitmap getResult() {
            return result;
        }

        public Bitmap generate() {
            byte[][] bitmaps = { leftPicture, rightPicture, new byte[leftPicture.Length]};
            AnaglyphGenerationTask.setBitmaps(bitmaps);
            if (isAsmGenerationEnabled) {
                AnaglyphGenerationTask.setGenerationFunction(AsmAnaglyphHelperProxy.makeAnagliph);
            } else {
                AnaglyphGenerationTask.setGenerationFunction(CsAnaglyphHelper.makeAnagliph);
            }

            int minWorker, maxWorker, IOC;
            ThreadPool.GetMinThreads(out minWorker, out IOC);
            ThreadPool.SetMinThreads(threadAmount, IOC);
            ThreadPool.GetMaxThreads(out maxWorker, out IOC);
            ThreadPool.SetMaxThreads(threadAmount, IOC);

            int partsAmount = bitmaps[2].Length / partSize;
            var doneEvents = new ManualResetEvent[bitmaps[2].Length % partSize == 0 ? partsAmount : partsAmount + 1];

            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < partsAmount; i++) {
                doneEvents[i] = new ManualResetEvent(false);
                AnaglyphGenerationTask agTask = new AnaglyphGenerationTask((i * partSize), ((i + 1) * partSize), doneEvents[i]);
                ThreadPool.QueueUserWorkItem(new WaitCallback(agTask.ThreadProc));
            }
            if(bitmaps[2].Length % partSize != 0) {
                doneEvents[partsAmount] = new ManualResetEvent(false);
                AnaglyphGenerationTask agTask = new AnaglyphGenerationTask((partsAmount * partSize) - 1, bitmaps[2].Length - 1, doneEvents[partsAmount]);
                ThreadPool.QueueUserWorkItem(new WaitCallback(agTask.ThreadProc));
            }
            foreach (var e in doneEvents) {
                e.WaitOne();
            }

            watch.Stop();

            generationTime = watch.ElapsedMilliseconds;
            result = new Bitmap(resultWidth, resultHeight, PixelFormat.Format24bppRgb);
            BitmapData resultData = result.LockBits(
                new Rectangle(0, 0, result.Width, result.Height),
                ImageLockMode.WriteOnly,
                result.PixelFormat
                );
            Marshal.Copy(bitmaps[2], 0, resultData.Scan0, bitmaps[2].Length);
            result.UnlockBits(resultData);

            return result;
        }
    }
}
