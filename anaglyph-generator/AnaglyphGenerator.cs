using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using CsAnaglyphGenerationHelper;

namespace anaglyph_generator {
    class AnaglyphGenerator { 
        private byte[] leftPicture;
        private byte[] rightPicture;
        private Bitmap result;
        private bool isAsmGenerationEnabled = false;
        private int threadAmount = 1;

        public AnaglyphGenerator(String leftPicturePath, String rightPicturePath) {
            using (var ms = new MemoryStream()) {
                Image.FromFile(leftPicturePath).Save(ms, ImageFormat.Jpeg);
                leftPicture = ms.ToArray();
                Image.FromFile(rightPicturePath).Save(ms, ImageFormat.Jpeg);
                rightPicture = ms.ToArray();
            }
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
            result = new Bitmap(leftPicture.Width, leftPicture.Height);
            for (int x = 0; x < result.Width; x++) {
                for (int y = 0; y < result.Height; y++) {
                    if(isAsmGenerationEnabled) {

                    } else {
                        Color leftPictureColor = leftPicture.GetPixel(x, y);
                        Color rightPictureColor = rightPicture.GetPixel(x, y);
                        Color newColor = Color.FromArgb(leftPictureColor.R, rightPictureColor.G, rightPictureColor.B);
                        result.SetPixel(x, y, newColor);
                        CsAnaglyphHelper.makeAnagliph();
                    }
                }
            }
            return result;
        }
    }
}
