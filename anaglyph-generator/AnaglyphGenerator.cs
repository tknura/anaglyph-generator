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
            byte[][] bitmaps = { leftPicture, rightPicture, res };
            if (isAsmGenerationEnabled) {

            }
            else {
                CsAnaglyphHelper.makeAnagliph(bitmaps, 0, res.Length);
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
