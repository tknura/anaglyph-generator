using System;

namespace CsAnaglyphGenerationHelper
{
    static public class CsAnaglyphHelper {
        static public void makeAnagliph(byte[] leftPic, byte[] rightPic, byte[] result, int startPoint, int endPoint) {
            for (int i = startPoint;i < endPoint; i++) {
                if(i % 3 == 0 || i % 3 == 1) {
                    result[i] = rightPic[i]; // B or G
                } else if (i % 3 == 2) {
                    result[i] = Convert.ToByte(0.299 * leftPic[i] + 0.587 * leftPic[i - 1] + 0.114 * leftPic[i - 2]); //R
                }
            }
        }
    }
}
