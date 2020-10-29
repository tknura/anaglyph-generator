using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsAnaglyphGenerationHelper
{
    static public class CsAnaglyphHelper {
        static public void makeAnagliph(byte[][] bitmaps, int startPoint, int endPoint) {
            byte[] leftPic = bitmaps[0];
            byte[] rightPic = bitmaps[1];
            byte[] result = bitmaps[2];

            for (int i = startPoint; i < endPoint - 2; i += 3) {
                result[i] = rightPic[i];
                result[i + 1] = rightPic[i + 1];
                result[i + 2] = Convert.ToByte(0.299 * leftPic[i + 2] + 0.587 * leftPic[i + 1] + 0.114 * leftPic[i]);
            }
        }
    }
}
