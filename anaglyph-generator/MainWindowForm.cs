using System;
using System.Drawing;
using System.Management;
using System.Windows.Forms;

// Autor: Tomasz Knura INF SSI gr.5 sem.5
// Temat: Generator anaglifów
// Wersja: 1.0
namespace anaglyph_generator {
    public partial class MainWindowForm : Form {
        public MainWindowForm() {
            InitializeComponent();
            csRadioButton.Checked = isCsEnabled;
            asemblyRadioButton.Checked = isAsemblyEnabled;
            /* Ustawianie optymalnej liczby wątków dla danego urządzenia, która wynosi Max(MinThreads, CPU_CORES),
             * MinThread w aplikacjach dekstopowych jest domyślnie równe 0, więc sprawdzamy i ustawiamy tylko ilość rdzeni */
            int coreCount = 0;
            foreach (var item in new ManagementObjectSearcher("Select * from Win32_Processor").Get()) {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            threadNumber.Value = coreCount;
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
            resultPictureBox.Image = generator.generate();
            saveResultButton.Enabled = true;
            generationTime.Text = generator.getGenerationTime().ToString() + " ms";
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
