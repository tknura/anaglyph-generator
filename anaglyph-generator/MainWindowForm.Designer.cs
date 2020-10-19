namespace anaglyph_generator {
    partial class MainWindowForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.leftPhotoFilePickButton = new System.Windows.Forms.Button();
            this.leftPhotoGroup = new System.Windows.Forms.GroupBox();
            this.leftFileStateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPhotoFileInput = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rightPhotoGroup = new System.Windows.Forms.GroupBox();
            this.rightFileStateLabel = new System.Windows.Forms.Label();
            this.rightFilePathLabel = new System.Windows.Forms.Label();
            this.rightPhotoFileInput = new System.Windows.Forms.TextBox();
            this.rightPhotoFilePickButton = new System.Windows.Forms.Button();
            this.functionTypGroup = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.generationTimeLabel = new System.Windows.Forms.Label();
            this.generationTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.leftPhotoGroup.SuspendLayout();
            this.rightPhotoGroup.SuspendLayout();
            this.functionTypGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPhotoFilePickButton
            // 
            this.leftPhotoFilePickButton.Location = new System.Drawing.Point(257, 57);
            this.leftPhotoFilePickButton.Name = "leftPhotoFilePickButton";
            this.leftPhotoFilePickButton.Size = new System.Drawing.Size(75, 23);
            this.leftPhotoFilePickButton.TabIndex = 1;
            this.leftPhotoFilePickButton.Text = "Pick file";
            this.leftPhotoFilePickButton.UseVisualStyleBackColor = true;
            this.leftPhotoFilePickButton.Click += new System.EventHandler(this.choosePhotoFile);
            // 
            // leftPhotoGroup
            // 
            this.leftPhotoGroup.Controls.Add(this.leftFileStateLabel);
            this.leftPhotoGroup.Controls.Add(this.label1);
            this.leftPhotoGroup.Controls.Add(this.leftPhotoFileInput);
            this.leftPhotoGroup.Controls.Add(this.leftPhotoFilePickButton);
            this.leftPhotoGroup.Location = new System.Drawing.Point(28, 35);
            this.leftPhotoGroup.Name = "leftPhotoGroup";
            this.leftPhotoGroup.Size = new System.Drawing.Size(345, 109);
            this.leftPhotoGroup.TabIndex = 3;
            this.leftPhotoGroup.TabStop = false;
            this.leftPhotoGroup.Text = "Left picture";
            // 
            // leftFileStateLabel
            // 
            this.leftFileStateLabel.AutoSize = true;
            this.leftFileStateLabel.Location = new System.Drawing.Point(95, 82);
            this.leftFileStateLabel.Name = "leftFileStateLabel";
            this.leftFileStateLabel.Size = new System.Drawing.Size(105, 17);
            this.leftFileStateLabel.TabIndex = 4;
            this.leftFileStateLabel.Text = "File not loaded.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "File path";
            // 
            // leftPhotoFileInput
            // 
            this.leftPhotoFileInput.Location = new System.Drawing.Point(6, 57);
            this.leftPhotoFileInput.Name = "leftPhotoFileInput";
            this.leftPhotoFileInput.Size = new System.Drawing.Size(245, 22);
            this.leftPhotoFileInput.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rightPhotoGroup
            // 
            this.rightPhotoGroup.Controls.Add(this.rightFileStateLabel);
            this.rightPhotoGroup.Controls.Add(this.rightFilePathLabel);
            this.rightPhotoGroup.Controls.Add(this.rightPhotoFileInput);
            this.rightPhotoGroup.Controls.Add(this.rightPhotoFilePickButton);
            this.rightPhotoGroup.Location = new System.Drawing.Point(390, 35);
            this.rightPhotoGroup.Name = "rightPhotoGroup";
            this.rightPhotoGroup.Size = new System.Drawing.Size(345, 109);
            this.rightPhotoGroup.TabIndex = 4;
            this.rightPhotoGroup.TabStop = false;
            this.rightPhotoGroup.Text = "Right picture";
            // 
            // rightFileStateLabel
            // 
            this.rightFileStateLabel.AutoSize = true;
            this.rightFileStateLabel.Location = new System.Drawing.Point(95, 82);
            this.rightFileStateLabel.Name = "rightFileStateLabel";
            this.rightFileStateLabel.Size = new System.Drawing.Size(105, 17);
            this.rightFileStateLabel.TabIndex = 4;
            this.rightFileStateLabel.Text = "File not loaded.";
            // 
            // rightFilePathLabel
            // 
            this.rightFilePathLabel.AutoSize = true;
            this.rightFilePathLabel.Location = new System.Drawing.Point(6, 37);
            this.rightFilePathLabel.Name = "rightFilePathLabel";
            this.rightFilePathLabel.Size = new System.Drawing.Size(62, 17);
            this.rightFilePathLabel.TabIndex = 4;
            this.rightFilePathLabel.Text = "File path";
            // 
            // rightPhotoFileInput
            // 
            this.rightPhotoFileInput.Location = new System.Drawing.Point(6, 57);
            this.rightPhotoFileInput.Name = "rightPhotoFileInput";
            this.rightPhotoFileInput.Size = new System.Drawing.Size(245, 22);
            this.rightPhotoFileInput.TabIndex = 5;
            // 
            // rightPhotoFilePickButton
            // 
            this.rightPhotoFilePickButton.Location = new System.Drawing.Point(257, 57);
            this.rightPhotoFilePickButton.Name = "rightPhotoFilePickButton";
            this.rightPhotoFilePickButton.Size = new System.Drawing.Size(75, 23);
            this.rightPhotoFilePickButton.TabIndex = 1;
            this.rightPhotoFilePickButton.Text = "Pick file";
            this.rightPhotoFilePickButton.UseVisualStyleBackColor = true;
            // 
            // functionTypGroup
            // 
            this.functionTypGroup.Controls.Add(this.radioButton2);
            this.functionTypGroup.Controls.Add(this.radioButton1);
            this.functionTypGroup.Location = new System.Drawing.Point(28, 173);
            this.functionTypGroup.Name = "functionTypGroup";
            this.functionTypGroup.Size = new System.Drawing.Size(707, 78);
            this.functionTypGroup.TabIndex = 5;
            this.functionTypGroup.TabStop = false;
            this.functionTypGroup.Text = "Choose generation function type";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Asembly";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.asemblyRadioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "C++";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.cppRadioButton_CheckedChanged);
            // 
            // generationTimeLabel
            // 
            this.generationTimeLabel.AutoSize = true;
            this.generationTimeLabel.Location = new System.Drawing.Point(25, 264);
            this.generationTimeLabel.Name = "generationTimeLabel";
            this.generationTimeLabel.Size = new System.Drawing.Size(113, 17);
            this.generationTimeLabel.TabIndex = 6;
            this.generationTimeLabel.Text = "Generation time:";
            // 
            // generationTime
            // 
            this.generationTime.AutoSize = true;
            this.generationTime.Location = new System.Drawing.Point(144, 264);
            this.generationTime.Name = "generationTime";
            this.generationTime.Size = new System.Drawing.Size(13, 17);
            this.generationTime.TabIndex = 7;
            this.generationTime.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(707, 389);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generate anaglyph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.generateAnaglyphButton_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 774);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.generationTime);
            this.Controls.Add(this.generationTimeLabel);
            this.Controls.Add(this.functionTypGroup);
            this.Controls.Add(this.rightPhotoGroup);
            this.Controls.Add(this.leftPhotoGroup);
            this.Name = "MainWindowForm";
            this.Text = "AnaglyphGeneratorWindow";
            this.leftPhotoGroup.ResumeLayout(false);
            this.leftPhotoGroup.PerformLayout();
            this.rightPhotoGroup.ResumeLayout(false);
            this.rightPhotoGroup.PerformLayout();
            this.functionTypGroup.ResumeLayout(false);
            this.functionTypGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button leftPhotoFilePickButton;
        private System.Windows.Forms.GroupBox leftPhotoGroup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox leftPhotoFileInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leftFileStateLabel;
        private System.Windows.Forms.GroupBox rightPhotoGroup;
        private System.Windows.Forms.Label rightFileStateLabel;
        private System.Windows.Forms.Label rightFilePathLabel;
        private System.Windows.Forms.TextBox rightPhotoFileInput;
        private System.Windows.Forms.Button rightPhotoFilePickButton;
        private System.Windows.Forms.GroupBox functionTypGroup;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label generationTimeLabel;
        private System.Windows.Forms.Label generationTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

