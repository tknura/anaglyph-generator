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
            this.photoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rightPhotoGroup = new System.Windows.Forms.GroupBox();
            this.rightPhotoFileButton = new System.Windows.Forms.Button();
            this.rightFileStateLabel = new System.Windows.Forms.Label();
            this.rightFilePathLabel = new System.Windows.Forms.Label();
            this.rightPhotoFileInput = new System.Windows.Forms.TextBox();
            this.rightPhotoFilePickButton = new System.Windows.Forms.Button();
            this.functionTypeGroup = new System.Windows.Forms.GroupBox();
            this.asemblyRadioButton = new System.Windows.Forms.RadioButton();
            this.csRadioButton = new System.Windows.Forms.RadioButton();
            this.generationTimeLabel = new System.Windows.Forms.Label();
            this.generationTime = new System.Windows.Forms.Label();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.generateAnaglyphButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.threadNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.threadNumber = new System.Windows.Forms.NumericUpDown();
            this.threadNumberLabel = new System.Windows.Forms.Label();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.saveResultFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.leftPhotoGroup.SuspendLayout();
            this.rightPhotoGroup.SuspendLayout();
            this.functionTypeGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.threadNumberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPhotoFilePickButton
            // 
            this.leftPhotoFilePickButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPhotoFilePickButton.Location = new System.Drawing.Point(259, 57);
            this.leftPhotoFilePickButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPhotoFilePickButton.Name = "leftPhotoFilePickButton";
            this.leftPhotoFilePickButton.Size = new System.Drawing.Size(75, 23);
            this.leftPhotoFilePickButton.TabIndex = 1;
            this.leftPhotoFilePickButton.Text = "Pick file";
            this.leftPhotoFilePickButton.UseVisualStyleBackColor = true;
            this.leftPhotoFilePickButton.Click += new System.EventHandler(this.chooseLeftPhotoFile);
            // 
            // leftPhotoGroup
            // 
            this.leftPhotoGroup.Controls.Add(this.leftFileStateLabel);
            this.leftPhotoGroup.Controls.Add(this.label1);
            this.leftPhotoGroup.Controls.Add(this.leftPhotoFileInput);
            this.leftPhotoGroup.Controls.Add(this.leftPhotoFilePickButton);
            this.leftPhotoGroup.Location = new System.Drawing.Point(28, 34);
            this.leftPhotoGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPhotoGroup.Name = "leftPhotoGroup";
            this.leftPhotoGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPhotoGroup.Size = new System.Drawing.Size(355, 112);
            this.leftPhotoGroup.TabIndex = 3;
            this.leftPhotoGroup.TabStop = false;
            this.leftPhotoGroup.Text = "Left picture";
            // 
            // leftFileStateLabel
            // 
            this.leftFileStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leftFileStateLabel.AutoSize = true;
            this.leftFileStateLabel.Location = new System.Drawing.Point(75, 82);
            this.leftFileStateLabel.Name = "leftFileStateLabel";
            this.leftFileStateLabel.Size = new System.Drawing.Size(105, 17);
            this.leftFileStateLabel.TabIndex = 4;
            this.leftFileStateLabel.Text = "File not loaded.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "File path";
            // 
            // leftPhotoFileInput
            // 
            this.leftPhotoFileInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPhotoFileInput.Enabled = false;
            this.leftPhotoFileInput.Location = new System.Drawing.Point(5, 57);
            this.leftPhotoFileInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftPhotoFileInput.Name = "leftPhotoFileInput";
            this.leftPhotoFileInput.Size = new System.Drawing.Size(247, 22);
            this.leftPhotoFileInput.TabIndex = 5;
            // 
            // photoFileDialog
            // 
            this.photoFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            // 
            // rightPhotoGroup
            // 
            this.rightPhotoGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPhotoGroup.Controls.Add(this.rightPhotoFileButton);
            this.rightPhotoGroup.Controls.Add(this.rightFileStateLabel);
            this.rightPhotoGroup.Controls.Add(this.rightFilePathLabel);
            this.rightPhotoGroup.Controls.Add(this.rightPhotoFileInput);
            this.rightPhotoGroup.Controls.Add(this.rightPhotoFilePickButton);
            this.rightPhotoGroup.Location = new System.Drawing.Point(392, 34);
            this.rightPhotoGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightPhotoGroup.Name = "rightPhotoGroup";
            this.rightPhotoGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightPhotoGroup.Size = new System.Drawing.Size(352, 112);
            this.rightPhotoGroup.TabIndex = 4;
            this.rightPhotoGroup.TabStop = false;
            this.rightPhotoGroup.Text = "Right picture";
            // 
            // rightPhotoFileButton
            // 
            this.rightPhotoFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPhotoFileButton.Location = new System.Drawing.Point(259, 57);
            this.rightPhotoFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightPhotoFileButton.Name = "rightPhotoFileButton";
            this.rightPhotoFileButton.Size = new System.Drawing.Size(75, 23);
            this.rightPhotoFileButton.TabIndex = 6;
            this.rightPhotoFileButton.Text = "Pick file";
            this.rightPhotoFileButton.UseVisualStyleBackColor = true;
            this.rightPhotoFileButton.Click += new System.EventHandler(this.chooseRightPhotoFile);
            // 
            // rightFileStateLabel
            // 
            this.rightFileStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.rightFilePathLabel.Location = new System.Drawing.Point(5, 37);
            this.rightFilePathLabel.Name = "rightFilePathLabel";
            this.rightFilePathLabel.Size = new System.Drawing.Size(62, 17);
            this.rightFilePathLabel.TabIndex = 4;
            this.rightFilePathLabel.Text = "File path";
            // 
            // rightPhotoFileInput
            // 
            this.rightPhotoFileInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPhotoFileInput.Enabled = false;
            this.rightPhotoFileInput.Location = new System.Drawing.Point(5, 57);
            this.rightPhotoFileInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightPhotoFileInput.Name = "rightPhotoFileInput";
            this.rightPhotoFileInput.Size = new System.Drawing.Size(247, 22);
            this.rightPhotoFileInput.TabIndex = 5;
            // 
            // rightPhotoFilePickButton
            // 
            this.rightPhotoFilePickButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPhotoFilePickButton.Location = new System.Drawing.Point(427, 71);
            this.rightPhotoFilePickButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightPhotoFilePickButton.Name = "rightPhotoFilePickButton";
            this.rightPhotoFilePickButton.Size = new System.Drawing.Size(75, 23);
            this.rightPhotoFilePickButton.TabIndex = 1;
            this.rightPhotoFilePickButton.Text = "Pick file";
            this.rightPhotoFilePickButton.UseVisualStyleBackColor = true;
            this.rightPhotoFilePickButton.Click += new System.EventHandler(this.chooseRightPhotoFile);
            // 
            // functionTypeGroup
            // 
            this.functionTypeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionTypeGroup.Controls.Add(this.asemblyRadioButton);
            this.functionTypeGroup.Controls.Add(this.csRadioButton);
            this.functionTypeGroup.Enabled = false;
            this.functionTypeGroup.Location = new System.Drawing.Point(24, 151);
            this.functionTypeGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.functionTypeGroup.Name = "functionTypeGroup";
            this.functionTypeGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.functionTypeGroup.Size = new System.Drawing.Size(359, 76);
            this.functionTypeGroup.TabIndex = 5;
            this.functionTypeGroup.TabStop = false;
            this.functionTypeGroup.Text = "Choose generation function type";
            // 
            // asemblyRadioButton
            // 
            this.asemblyRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asemblyRadioButton.AutoSize = true;
            this.asemblyRadioButton.Location = new System.Drawing.Point(9, 48);
            this.asemblyRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.asemblyRadioButton.Name = "asemblyRadioButton";
            this.asemblyRadioButton.Size = new System.Drawing.Size(82, 21);
            this.asemblyRadioButton.TabIndex = 1;
            this.asemblyRadioButton.TabStop = true;
            this.asemblyRadioButton.Text = "Asembly";
            this.asemblyRadioButton.UseVisualStyleBackColor = true;
            this.asemblyRadioButton.CheckedChanged += new System.EventHandler(this.functionTypeRadioButton_CheckedChanged);
            // 
            // csRadioButton
            // 
            this.csRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.csRadioButton.AutoSize = true;
            this.csRadioButton.Location = new System.Drawing.Point(9, 21);
            this.csRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.csRadioButton.Name = "csRadioButton";
            this.csRadioButton.Size = new System.Drawing.Size(46, 21);
            this.csRadioButton.TabIndex = 0;
            this.csRadioButton.TabStop = true;
            this.csRadioButton.Text = "C#";
            this.csRadioButton.UseVisualStyleBackColor = true;
            this.csRadioButton.CheckedChanged += new System.EventHandler(this.functionTypeRadioButton_CheckedChanged);
            // 
            // generationTimeLabel
            // 
            this.generationTimeLabel.AutoSize = true;
            this.generationTimeLabel.Location = new System.Drawing.Point(21, 282);
            this.generationTimeLabel.Name = "generationTimeLabel";
            this.generationTimeLabel.Size = new System.Drawing.Size(113, 17);
            this.generationTimeLabel.TabIndex = 6;
            this.generationTimeLabel.Text = "Generation time:";
            // 
            // generationTime
            // 
            this.generationTime.AutoSize = true;
            this.generationTime.Location = new System.Drawing.Point(171, 282);
            this.generationTime.Name = "generationTime";
            this.generationTime.Size = new System.Drawing.Size(13, 17);
            this.generationTime.TabIndex = 7;
            this.generationTime.Text = "-";
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultPictureBox.Location = new System.Drawing.Point(24, 315);
            this.resultPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(720, 605);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 8;
            this.resultPictureBox.TabStop = false;
            // 
            // generateAnaglyphButton
            // 
            this.generateAnaglyphButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateAnaglyphButton.Enabled = false;
            this.generateAnaglyphButton.Location = new System.Drawing.Point(24, 233);
            this.generateAnaglyphButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateAnaglyphButton.Name = "generateAnaglyphButton";
            this.generateAnaglyphButton.Size = new System.Drawing.Size(720, 34);
            this.generateAnaglyphButton.TabIndex = 9;
            this.generateAnaglyphButton.Text = "Generate anaglyph";
            this.generateAnaglyphButton.UseVisualStyleBackColor = true;
            this.generateAnaglyphButton.Click += new System.EventHandler(this.generateAnaglyphButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(33, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(113, 17);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Pick two pictures";
            // 
            // threadNumberGroupBox
            // 
            this.threadNumberGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threadNumberGroupBox.Controls.Add(this.threadNumber);
            this.threadNumberGroupBox.Controls.Add(this.threadNumberLabel);
            this.threadNumberGroupBox.Enabled = false;
            this.threadNumberGroupBox.Location = new System.Drawing.Point(389, 151);
            this.threadNumberGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.threadNumberGroupBox.Name = "threadNumberGroupBox";
            this.threadNumberGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.threadNumberGroupBox.Size = new System.Drawing.Size(355, 76);
            this.threadNumberGroupBox.TabIndex = 6;
            this.threadNumberGroupBox.TabStop = false;
            this.threadNumberGroupBox.Text = "Choose generation function type";
            // 
            // threadNumber
            // 
            this.threadNumber.Location = new System.Drawing.Point(8, 43);
            this.threadNumber.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.threadNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadNumber.Name = "threadNumber";
            this.threadNumber.Size = new System.Drawing.Size(329, 22);
            this.threadNumber.TabIndex = 8;
            this.threadNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadNumber.ValueChanged += new System.EventHandler(this.threadNumber_ValueChanged);
            // 
            // threadNumberLabel
            // 
            this.threadNumberLabel.AutoSize = true;
            this.threadNumberLabel.Location = new System.Drawing.Point(5, 23);
            this.threadNumberLabel.Name = "threadNumberLabel";
            this.threadNumberLabel.Size = new System.Drawing.Size(126, 17);
            this.threadNumberLabel.TabIndex = 7;
            this.threadNumberLabel.Text = "Number of threads";
            // 
            // saveResultButton
            // 
            this.saveResultButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveResultButton.Enabled = false;
            this.saveResultButton.Location = new System.Drawing.Point(24, 925);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(720, 31);
            this.saveResultButton.TabIndex = 11;
            this.saveResultButton.Text = "Save Result";
            this.saveResultButton.UseVisualStyleBackColor = true;
            this.saveResultButton.Click += new System.EventHandler(this.saveResultButton_Click);
            // 
            // saveResultFileDialog
            // 
            this.saveResultFileDialog.DefaultExt = "bmp";
            this.saveResultFileDialog.FileName = "result";
            this.saveResultFileDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 968);
            this.Controls.Add(this.saveResultButton);
            this.Controls.Add(this.threadNumberGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.generateAnaglyphButton);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.rightPhotoGroup);
            this.Controls.Add(this.generationTime);
            this.Controls.Add(this.generationTimeLabel);
            this.Controls.Add(this.functionTypeGroup);
            this.Controls.Add(this.leftPhotoGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindowForm";
            this.Text = "AnaglyphGeneratorWindow";
            this.leftPhotoGroup.ResumeLayout(false);
            this.leftPhotoGroup.PerformLayout();
            this.rightPhotoGroup.ResumeLayout(false);
            this.rightPhotoGroup.PerformLayout();
            this.functionTypeGroup.ResumeLayout(false);
            this.functionTypeGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.threadNumberGroupBox.ResumeLayout(false);
            this.threadNumberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button leftPhotoFilePickButton;
        private System.Windows.Forms.GroupBox leftPhotoGroup;
        private System.Windows.Forms.OpenFileDialog photoFileDialog;
        private System.Windows.Forms.TextBox leftPhotoFileInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leftFileStateLabel;
        private System.Windows.Forms.GroupBox rightPhotoGroup;
        private System.Windows.Forms.Label rightFileStateLabel;
        private System.Windows.Forms.Label rightFilePathLabel;
        private System.Windows.Forms.TextBox rightPhotoFileInput;
        private System.Windows.Forms.Button rightPhotoFilePickButton;
        private System.Windows.Forms.GroupBox functionTypeGroup;
        private System.Windows.Forms.RadioButton asemblyRadioButton;
        private System.Windows.Forms.RadioButton csRadioButton;
        private System.Windows.Forms.Label generationTimeLabel;
        private System.Windows.Forms.Label generationTime;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Button generateAnaglyphButton;
        private System.Windows.Forms.Button rightPhotoFileButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox threadNumberGroupBox;
        private System.Windows.Forms.Label threadNumberLabel;
        private System.Windows.Forms.NumericUpDown threadNumber;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.SaveFileDialog saveResultFileDialog;
    }
}

