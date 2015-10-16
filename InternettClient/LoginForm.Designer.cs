namespace InternettClient
{
    partial class LoginForm
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.responseTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserName.Location = new System.Drawing.Point(0, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(238, 20);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "Username";
            // 
            // LoginBTN
            // 
            this.LoginBTN.AutoSize = true;
            this.LoginBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoginBTN.Location = new System.Drawing.Point(0, 20);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(238, 23);
            this.LoginBTN.TabIndex = 2;
            this.LoginBTN.Text = "Login";
            this.LoginBTN.UseVisualStyleBackColor = true;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // Password
            // 
            this.Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.Password.Location = new System.Drawing.Point(0, 43);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(238, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // responseTxt
            // 
            this.responseTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.responseTxt.Location = new System.Drawing.Point(0, 81);
            this.responseTxt.Multiline = true;
            this.responseTxt.Name = "responseTxt";
            this.responseTxt.Size = new System.Drawing.Size(238, 49);
            this.responseTxt.TabIndex = 3;
            this.responseTxt.Text = "Bruk HiN-konto for pålogging";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(238, 130);
            this.Controls.Add(this.responseTxt);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.UserName);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox responseTxt;
    }
}

