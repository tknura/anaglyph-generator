using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

// Autor: Tomasz Knura INF SSI gr.5 sem.5
// Temat: Generator anaglifów
// Wersja: 1.0
namespace anaglyph_generator {
    class AsmAnaglyphHelperProxy {
        [DllImport("asm-anaglyph-generation.dll")]
        private static extern void asmMakeAnagliph(byte[] leftPic, byte[] rightPic, byte[] result, int startPoint, int endPoint);

        public static void makeAnagliph(byte[] leftPic, byte[] rightPic, byte[] result, int startPoint, int endPoint) {
            asmMakeAnagliph(leftPic, rightPic, result, startPoint, endPoint);
        }
    }
}
