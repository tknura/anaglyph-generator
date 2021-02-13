using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Autor: Tomasz Knura INF SSI gr.5 sem.5
// Temat: Generator anaglifów
// Wersja: 1.0
namespace anaglyph_generator {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindowForm());
        }
    }
}
