using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using CsAnaglyphGenerationHelper;

namespace anaglyph_generator {
    class AnaglyphGenerator { 
        private byte[] leftPicture;
        private byte[] rightPicture;
        private int resultWidth;
        private int resultHeight;
        private Bitmap result;
        private bool isAsmGenerationEnabled = false;
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
            var res = new byte[leftPicture.Length];
            for (int i = 0; i < res.Length - 2; i += 3) {
                if (isAsmGenerationEnabled) {

                }
                else {
                    res[i] = rightPicture[i + 2];
                    res[i + 1] = rightPicture[i + 1];
                    res[i + 2] = Convert.ToByte(0.299 * (double)leftPicture[i] + 0.587 * (double)leftPicture[i + 1] + 0.114 * (double)leftPicture[i + 2]);
                    //CsAnaglyphHelper.makeAnagliph();
                }
            }
            result = new Bitmap(resultWidth, resultHeight, PixelFormat.Format24bppRgb);
            BitmapData resultData = result.LockBits(
                new Rectangle(0, 0, result.Width, result.Height),
                ImageLockMode.WriteOnly,
                result.PixelFormat
                );
            Marshal.Copy(res, 0, resultData.Scan0, res.Length);
            result.UnlockBits(resultData);
            return result;
        }
    }
}
