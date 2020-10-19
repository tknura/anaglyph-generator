using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anaglyph_generator {
    class AnaglyphGenerator {
        private Bitmap leftPicture;
        private Bitmap rightPicture;

        public void generate(String leftPicturePath, String rightPicturePath) {
            leftPicture = new Bitmap(leftPicturePath);
            rightPicture = new Bitmap(rightPicturePath);
        }
    }
}
