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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.qrPicture = new System.Windows.Forms.PictureBox();
            this.getQRPictureBTN = new System.Windows.Forms.Button();
            this.UploadButton = new System.Windows.Forms.Button();
            this.ByteLabel = new System.Windows.Forms.Label();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // qrPicture
            // 
            this.qrPicture.Location = new System.Drawing.Point(53, 41);
            this.qrPicture.Name = "qrPicture";
            this.qrPicture.Size = new System.Drawing.Size(105, 66);
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
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(15, 174);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 4;
            this.UploadButton.Text = "UploadFile";
            this.UploadButton.UseVisualStyleBackColor = true;
            // 
            // ByteLabel
            // 
            this.ByteLabel.AutoSize = true;
            this.ByteLabel.Location = new System.Drawing.Point(164, 195);
            this.ByteLabel.Name = "ByteLabel";
            this.ByteLabel.Size = new System.Drawing.Size(28, 13);
            this.ByteLabel.TabIndex = 5;
            this.ByteLabel.Text = "Byte";
            this.ByteLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 240);
            this.Controls.Add(this.ByteLabel);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.getQRPictureBTN);
            this.Controls.Add(this.qrPicture);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CounterLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.qrPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox qrPicture;
        private System.Windows.Forms.Button getQRPictureBTN;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Label ByteLabel;
    }
}