using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace anaglyph_generator {
    public partial class MainWindowForm : Form {
        public MainWindowForm() {
            InitializeComponent();
            csRadioButton.Checked = isCsEnabled;
            asemblyRadioButton.Checked = isAsemblyEnabled;
        }

        AnaglyphGenerator generator;
        private bool isCsEnabled = true;
        private bool isAsemblyEnabled = false;

        private void functionTypeRadioButton_CheckedChanged(object sender, EventArgs e) {
            isCsEnabled = csRadioButton.Checked;
            isAsemblyEnabled = asemblyRadioButton.Checked;
        }

        private void generateAnaglyphButton_Click(object sender, EventArgs e) {
            if(isCsEnabled) {
                generator.generate(leftPhotoFileInput.Text, rightPhotoFileInput.Text);
            } else if(isAsemblyEnabled) {
                // To Do: add assembly function to generate method
            }
        }

        private void choosePhotoFile(TextBox input, Label stateLabel) {
            DialogResult result = photoFileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                input.Text = photoFileDialog.FileName;
                stateLabel.Text = "File uploaded correctly.";
                stateLabel.ForeColor = Color.Green;
                if(leftPhotoFileInput.Text != "" && rightPhotoFileInput.Text != "") {
                    generateAnaglyphButton.Enabled = true;
                }
            }
            else if (result == DialogResult.Cancel) {
                stateLabel.Text = "Pick canceled.";
                stateLabel.ForeColor = Color.Red;
            }
            else {
                stateLabel.Text = "Error, Try again.";
                stateLabel.ForeColor = Color.Red;
            }
        }

        private void chooseLeftPhotoFile(object sender, EventArgs e) {
            choosePhotoFile(leftPhotoFileInput, leftFileStateLabel);
        }

        private void chooseRightPhotoFile(object sender, EventArgs e) {
            choosePhotoFile(rightPhotoFileInput, rightFileStateLabel);
        }

        private void MainWindowForm_Load(object sender, EventArgs e) {

        }
    }
}
