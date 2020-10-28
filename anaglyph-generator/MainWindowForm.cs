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
            if (generator != null) {
                generator.setAsmGeneration(isAsemblyEnabled);
            }
        }

        private void generateAnaglyphButton_Click(object sender, EventArgs e) {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            resultPictureBox.Image = generator.generate();
            watch.Stop();
            saveResultButton.Enabled = true;
            generationTime.Text = watch.ElapsedMilliseconds.ToString() + " ms";
        }

        private void choosePhotoFile(TextBox input, Label stateLabel) {
            DialogResult result = photoFileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                input.Text = photoFileDialog.FileName;
                stateLabel.Text = "File uploaded correctly.";
                stateLabel.ForeColor = Color.Green;
                if(leftPhotoFileInput.Text != "" && rightPhotoFileInput.Text != "") {
                    generator = new AnaglyphGenerator(leftPhotoFileInput.Text, rightPhotoFileInput.Text);
                    generateAnaglyphButton.Enabled = true;
                    functionTypeGroup.Enabled = true;
                    threadNumberGroupBox.Enabled = true;
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

        private void threadNumber_ValueChanged(object sender, EventArgs e) {
            if (generator != null) {
                generator.setThreadAmount((int)threadNumber.Value);
            }
        }

        private void saveResultButton_Click(object sender, EventArgs e) {
            if (saveResultFileDialog.ShowDialog() == DialogResult.OK) {
                if (generator != null) {
                    System.IO.FileStream fs = (System.IO.FileStream)saveResultFileDialog.OpenFile();
                    switch (saveResultFileDialog.FilterIndex) {
                        case 1:
                            generator.getResult().Save(fs,
                              System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            generator.getResult().Save(fs,
                              System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 3:
                            generator.getResult().Save(fs,
                              System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                    }
                }
            }
        }
    }
}
