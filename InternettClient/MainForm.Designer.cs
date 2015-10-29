namespace InternettClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CounterLabel = new System.Windows.Forms.Label();
            this.byteTB = new System.Windows.Forms.TextBox();
            this.qrPicture = new System.Windows.Forms.PictureBox();
            this.getQRPictureBTN = new System.Windows.Forms.Button();
            this.FileButton = new System.Windows.Forms.Button();
            this.ByteLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uploadedFileText = new System.Windows.Forms.TextBox();
            this.qrCheckBox = new System.Windows.Forms.CheckBox();
            this.byteCountBTN = new System.Windows.Forms.Button();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Location = new System.Drawing.Point(12, 144);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(65, 13);
            this.CounterLabel.TabIndex = 0;
            this.CounterLabel.Text = "ByteCounter";
            // 
            // byteTB
            // 
            this.byteTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.byteTB.Location = new System.Drawing.Point(236, 218);
            this.byteTB.Name = "byteTB";
            this.byteTB.ReadOnly = true;
            this.byteTB.Size = new System.Drawing.Size(62, 13);
            this.byteTB.TabIndex = 1;
            this.byteTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.byteTB.Visible = false;
            // 
            // qrPicture
            // 
            this.qrPicture.Location = new System.Drawing.Point(53, 41);
            this.qrPicture.Name = "qrPicture";
            this.qrPicture.Size = new System.Drawing.Size(100, 100);
            this.qrPicture.TabIndex = 2;
            this.qrPicture.TabStop = false;
            this.qrPicture.Visible = false;
            // 
            // getQRPictureBTN
            // 
            this.getQRPictureBTN.Location = new System.Drawing.Point(15, 12);
            this.getQRPictureBTN.Name = "getQRPictureBTN";
            this.getQRPictureBTN.Size = new System.Drawing.Size(75, 23);
            this.getQRPictureBTN.TabIndex = 3;
            this.getQRPictureBTN.Text = "FortuneQR";
            this.getQRPictureBTN.UseVisualStyleBackColor = true;
            this.getQRPictureBTN.Click += new System.EventHandler(this.getQRPictureBTN_Click);
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(11, 174);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(75, 23);
            this.FileButton.TabIndex = 4;
            this.FileButton.Text = "File";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // ByteLabel
            // 
            this.ByteLabel.AutoSize = true;
            this.ByteLabel.Location = new System.Drawing.Point(304, 221);
            this.ByteLabel.Name = "ByteLabel";
            this.ByteLabel.Size = new System.Drawing.Size(28, 13);
            this.ByteLabel.TabIndex = 5;
            this.ByteLabel.Text = "Byte";
            this.ByteLabel.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // uploadedFileText
            // 
            this.uploadedFileText.BackColor = System.Drawing.SystemColors.Control;
            this.uploadedFileText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uploadedFileText.Location = new System.Drawing.Point(108, 174);
            this.uploadedFileText.Name = "uploadedFileText";
            this.uploadedFileText.ReadOnly = true;
            this.uploadedFileText.Size = new System.Drawing.Size(250, 13);
            this.uploadedFileText.TabIndex = 6;
            this.uploadedFileText.Visible = false;
            // 
            // qrCheckBox
            // 
            this.qrCheckBox.AutoSize = true;
            this.qrCheckBox.Location = new System.Drawing.Point(15, 217);
            this.qrCheckBox.Name = "qrCheckBox";
            this.qrCheckBox.Size = new System.Drawing.Size(78, 17);
            this.qrCheckBox.TabIndex = 8;
            this.qrCheckBox.Text = "QR-Picture";
            this.qrCheckBox.UseVisualStyleBackColor = true;
            this.qrCheckBox.CheckedChanged += new System.EventHandler(this.qrCheckBox_CheckedChanged);
            // 
            // byteCountBTN
            // 
            this.byteCountBTN.Location = new System.Drawing.Point(155, 217);
            this.byteCountBTN.Name = "byteCountBTN";
            this.byteCountBTN.Size = new System.Drawing.Size(75, 23);
            this.byteCountBTN.TabIndex = 9;
            this.byteCountBTN.Text = "Count Bytes";
            this.byteCountBTN.UseVisualStyleBackColor = true;
            this.byteCountBTN.Click += new System.EventHandler(this.byteCountBTN_Click);
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(45, 263);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(62, 20);
            this.inputTB.TabIndex = 10;
            this.inputTB.TextChanged += new System.EventHandler(this.inputTB_TextChanged);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(8, 263);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(31, 13);
            this.inputLabel.TabIndex = 11;
            this.inputLabel.Text = "Input";
            // 
            // numberLabel
            // 
            this.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberLabel.Location = new System.Drawing.Point(168, 128);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.ReadOnly = true;
            this.numberLabel.Size = new System.Drawing.Size(62, 13);
            this.numberLabel.TabIndex = 12;
            this.numberLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 307);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTB);
            this.Controls.Add(this.byteCountBTN);
            this.Controls.Add(this.qrCheckBox);
            this.Controls.Add(this.uploadedFileText);
            this.Controls.Add(this.ByteLabel);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.getQRPictureBTN);
            this.Controls.Add(this.qrPicture);
            this.Controls.Add(this.byteTB);
            this.Controls.Add(this.CounterLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.qrPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.TextBox byteTB;
        private System.Windows.Forms.PictureBox qrPicture;
        private System.Windows.Forms.Button getQRPictureBTN;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Label ByteLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox uploadedFileText;
        private System.Windows.Forms.CheckBox qrCheckBox;
        private System.Windows.Forms.Button byteCountBTN;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox numberLabel;
    }
}