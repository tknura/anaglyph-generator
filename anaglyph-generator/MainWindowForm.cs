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
    public partial class MainWindowForm : Form {
        public MainWindowForm() {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {

        }

        private void choosePhotoFile(object sender, EventArgs e) {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                Console.WriteLine(openFileDialog1.FileName);
                leftPhotoFileInput.Text = openFileDialog1.FileName;
            }
        }

        private void functionTypGroup_Enter(object sender, EventArgs e) {

        }

        private void cppRadioButton_CheckedChanged(object sender, EventArgs e) {

        }

        private void asemblyRadioButton_CheckedChanged(object sender, EventArgs e) {

        }

        private void generateAnaglyphButton_Click(object sender, EventArgs e) {

        }
    }
}
