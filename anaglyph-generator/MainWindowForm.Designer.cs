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
            this.functionTypGroup = new System.Windows.Forms.GroupBox();
            this.asemblyRadioButton = new System.Windows.Forms.RadioButton();
            this.csRadioButton = new System.Windows.Forms.RadioButton();
            this.generationTimeLabel = new System.Windows.Forms.Label();
            this.generationTime = new System.Windows.Forms.Label();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.generateAnaglyphButton = new System.Windows.Forms.Button();
            this.leftPhotoGroup.SuspendLayout();
            this.rightPhotoGroup.SuspendLayout();
            this.functionTypGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPhotoFilePickButton
            // 
            this.leftPhotoFilePickButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPhotoFilePickButton.Location = new System.Drawing.Point(194, 46);
            this.leftPhotoFilePickButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftPhotoFilePickButton.Name = "leftPhotoFilePickButton";
            this.leftPhotoFilePickButton.Size = new System.Drawing.Size(56, 19);
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
            this.leftPhotoGroup.Location = new System.Drawing.Point(21, 28);
            this.leftPhotoGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftPhotoGroup.Name = "leftPhotoGroup";
            this.leftPhotoGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftPhotoGroup.Size = new System.Drawing.Size(266, 91);
            this.leftPhotoGroup.TabIndex = 3;
            this.leftPhotoGroup.TabStop = false;
            this.leftPhotoGroup.Text = "Left picture";
            // 
            // leftFileStateLabel
            // 
            this.leftFileStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.leftFileStateLabel.AutoSize = true;
            this.leftFileStateLabel.Location = new System.Drawing.Point(56, 67);
            this.leftFileStateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leftFileStateLabel.Name = "leftFileStateLabel";
            this.leftFileStateLabel.Size = new System.Drawing.Size(79, 13);
            this.leftFileStateLabel.TabIndex = 4;
            this.leftFileStateLabel.Text = "File not loaded.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File path";
            // 
            // leftPhotoFileInput
            // 
            this.leftPhotoFileInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPhotoFileInput.Enabled = false;
            this.leftPhotoFileInput.Location = new System.Drawing.Point(4, 46);
            this.leftPhotoFileInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftPhotoFileInput.Name = "leftPhotoFileInput";
            this.leftPhotoFileInput.Size = new System.Drawing.Size(186, 20);
            this.leftPhotoFileInput.TabIndex = 5;
            // 
            // photoFileDialog
            // 
            this.photoFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
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
            this.rightPhotoGroup.Location = new System.Drawing.Point(294, 28);
            this.rightPhotoGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightPhotoGroup.Name = "rightPhotoGroup";
            this.rightPhotoGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightPhotoGroup.Size = new System.Drawing.Size(264, 91);
            this.rightPhotoGroup.TabIndex = 4;
            this.rightPhotoGroup.TabStop = false;
            this.rightPhotoGroup.Text = "Right picture";
            // 
            // rightPhotoFileButton
            // 
            this.rightPhotoFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPhotoFileButton.Location = new System.Drawing.Point(194, 46);
            this.rightPhotoFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightPhotoFileButton.Name = "rightPhotoFileButton";
            this.rightPhotoFileButton.Size = new System.Drawing.Size(56, 19);
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
            this.rightFileStateLabel.Location = new System.Drawing.Point(71, 67);
            this.rightFileStateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightFileStateLabel.Name = "rightFileStateLabel";
            this.rightFileStateLabel.Size = new System.Drawing.Size(79, 13);
            this.rightFileStateLabel.TabIndex = 4;
            this.rightFileStateLabel.Text = "File not loaded.";
            // 
            // rightFilePathLabel
            // 
            this.rightFilePathLabel.AutoSize = true;
            this.rightFilePathLabel.Location = new System.Drawing.Point(4, 30);
            this.rightFilePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightFilePathLabel.Name = "rightFilePathLabel";
            this.rightFilePathLabel.Size = new System.Drawing.Size(47, 13);
            this.rightFilePathLabel.TabIndex = 4;
            this.rightFilePathLabel.Text = "File path";
            // 
            // rightPhotoFileInput
            // 
            this.rightPhotoFileInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPhotoFileInput.Enabled = false;
            this.rightPhotoFileInput.Location = new System.Drawing.Point(4, 46);
            this.rightPhotoFileInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightPhotoFileInput.Name = "rightPhotoFileInput";
            this.rightPhotoFileInput.Size = new System.Drawing.Size(186, 20);
            this.rightPhotoFileInput.TabIndex = 5;
            // 
            // rightPhotoFilePickButton
            // 
            this.rightPhotoFilePickButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPhotoFilePickButton.Location = new System.Drawing.Point(320, 58);
            this.rightPhotoFilePickButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightPhotoFilePickButton.Name = "rightPhotoFilePickButton";
            this.rightPhotoFilePickButton.Size = new System.Drawing.Size(56, 19);
            this.rightPhotoFilePickButton.TabIndex = 1;
            this.rightPhotoFilePickButton.Text = "Pick file";
            this.rightPhotoFilePickButton.UseVisualStyleBackColor = true;
            this.rightPhotoFilePickButton.Click += new System.EventHandler(this.chooseRightPhotoFile);
            // 
            // functionTypGroup
            // 
            this.functionTypGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.functionTypGroup.Controls.Add(this.asemblyRadioButton);
            this.functionTypGroup.Controls.Add(this.csRadioButton);
            this.functionTypGroup.Location = new System.Drawing.Point(18, 123);
            this.functionTypGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.functionTypGroup.Name = "functionTypGroup";
            this.functionTypGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.functionTypGroup.Size = new System.Drawing.Size(540, 62);
            this.functionTypGroup.TabIndex = 5;
            this.functionTypGroup.TabStop = false;
            this.functionTypGroup.Text = "Choose generation function type";
            // 
            // asemblyRadioButton
            // 
            this.asemblyRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.asemblyRadioButton.AutoSize = true;
            this.asemblyRadioButton.Location = new System.Drawing.Point(7, 39);
            this.asemblyRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.asemblyRadioButton.Name = "asemblyRadioButton";
            this.asemblyRadioButton.Size = new System.Drawing.Size(64, 17);
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
            this.csRadioButton.Location = new System.Drawing.Point(7, 17);
            this.csRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.csRadioButton.Name = "csRadioButton";
            this.csRadioButton.Size = new System.Drawing.Size(39, 17);
            this.csRadioButton.TabIndex = 0;
            this.csRadioButton.TabStop = true;
            this.csRadioButton.Text = "C#";
            this.csRadioButton.UseVisualStyleBackColor = true;
            this.csRadioButton.CheckedChanged += new System.EventHandler(this.functionTypeRadioButton_CheckedChanged);
            // 
            // generationTimeLabel
            // 
            this.generationTimeLabel.AutoSize = true;
            this.generationTimeLabel.Location = new System.Drawing.Point(16, 229);
            this.generationTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generationTimeLabel.Name = "generationTimeLabel";
            this.generationTimeLabel.Size = new System.Drawing.Size(84, 13);
            this.generationTimeLabel.TabIndex = 6;
            this.generationTimeLabel.Text = "Generation time:";
            // 
            // generationTime
            // 
            this.generationTime.AutoSize = true;
            this.generationTime.Location = new System.Drawing.Point(128, 229);
            this.generationTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.generationTime.Name = "generationTime";
            this.generationTime.Size = new System.Drawing.Size(10, 13);
            this.generationTime.TabIndex = 7;
            this.generationTime.Text = "-";
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultPictureBox.Location = new System.Drawing.Point(18, 256);
            this.resultPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(540, 499);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.resultPictureBox.TabIndex = 8;
            this.resultPictureBox.TabStop = false;
            // 
            // generateAnaglyphButton
            // 
            this.generateAnaglyphButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateAnaglyphButton.Enabled = false;
            this.generateAnaglyphButton.Location = new System.Drawing.Point(18, 189);
            this.generateAnaglyphButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generateAnaglyphButton.Name = "generateAnaglyphButton";
            this.generateAnaglyphButton.Size = new System.Drawing.Size(537, 28);
            this.generateAnaglyphButton.TabIndex = 9;
            this.generateAnaglyphButton.Text = "Generate anaglyph";
            this.generateAnaglyphButton.UseVisualStyleBackColor = true;
            this.generateAnaglyphButton.Click += new System.EventHandler(this.generateAnaglyphButton_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 766);
            this.Controls.Add(this.generateAnaglyphButton);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.rightPhotoGroup);
            this.Controls.Add(this.generationTime);
            this.Controls.Add(this.generationTimeLabel);
            this.Controls.Add(this.functionTypGroup);
            this.Controls.Add(this.leftPhotoGroup);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindowForm";
            this.Text = "AnaglyphGeneratorWindow";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.leftPhotoGroup.ResumeLayout(false);
            this.leftPhotoGroup.PerformLayout();
            this.rightPhotoGroup.ResumeLayout(false);
            this.rightPhotoGroup.PerformLayout();
            this.functionTypGroup.ResumeLayout(false);
            this.functionTypGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
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
        private System.Windows.Forms.GroupBox functionTypGroup;
        private System.Windows.Forms.RadioButton asemblyRadioButton;
        private System.Windows.Forms.RadioButton csRadioButton;
        private System.Windows.Forms.Label generationTimeLabel;
        private System.Windows.Forms.Label generationTime;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Button generateAnaglyphButton;
        private System.Windows.Forms.Button rightPhotoFileButton;
    }
}

