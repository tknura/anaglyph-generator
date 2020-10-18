namespace anaglyph_generator {
    partial class Form1 {
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.leftPhotoFileInput = new System.Windows.Forms.TextBox();
            this.leftPhotoGroup.SuspendLayout();
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
            this.leftPhotoGroup.Controls.Add(this.leftPhotoFileInput);
            this.leftPhotoGroup.Controls.Add(this.leftPhotoFilePickButton);
            this.leftPhotoGroup.Location = new System.Drawing.Point(28, 35);
            this.leftPhotoGroup.Name = "leftPhotoGroup";
            this.leftPhotoGroup.Size = new System.Drawing.Size(345, 98);
            this.leftPhotoGroup.TabIndex = 3;
            this.leftPhotoGroup.TabStop = false;
            this.leftPhotoGroup.Text = "Left picture";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // leftPhotoFileInput
            // 
            this.leftPhotoFileInput.Location = new System.Drawing.Point(6, 57);
            this.leftPhotoFileInput.Name = "leftPhotoFileInput";
            this.leftPhotoFileInput.Size = new System.Drawing.Size(245, 22);
            this.leftPhotoFileInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.leftPhotoGroup);
            this.Name = "Form1";
            this.Text = "AnaglyphGeneratorWindow";
            this.leftPhotoGroup.ResumeLayout(false);
            this.leftPhotoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button leftPhotoFilePickButton;
        private System.Windows.Forms.GroupBox leftPhotoGroup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox leftPhotoFileInput;
    }
}

