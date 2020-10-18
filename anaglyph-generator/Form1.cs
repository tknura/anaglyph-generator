using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anaglyph_generator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {

        }

        private void choosePhotoFile(object sender, EventArgs e) {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                Console.WriteLine(openFileDialog1.FileName);
                leftPhotoFileLabel.Text = openFileDialog1.FileName;
            }
        }
    }
}
