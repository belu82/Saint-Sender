namespace Saint_Sender
{
    partial class Form2
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
            this.textMail = new MetroFramework.Controls.MetroTextBox();
            this.textPassw = new MetroFramework.Controls.MetroTextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.exitButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // textMail
            // 
            // 
            // 
            // 
            this.textMail.CustomButton.Image = null;
            this.textMail.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.textMail.CustomButton.Name = "";
            this.textMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textMail.CustomButton.TabIndex = 1;
            this.textMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textMail.CustomButton.UseSelectable = true;
            this.textMail.CustomButton.Visible = false;
            this.textMail.Lines = new string[] {
        "beluhbo82@gmail.com"};
            this.textMail.Location = new System.Drawing.Point(279, 63);
            this.textMail.MaxLength = 32767;
            this.textMail.Name = "textMail";
            this.textMail.PasswordChar = '\0';
            this.textMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textMail.SelectedText = "";
            this.textMail.SelectionLength = 0;
            this.textMail.SelectionStart = 0;
            this.textMail.ShortcutsEnabled = true;
            this.textMail.Size = new System.Drawing.Size(144, 23);
            this.textMail.TabIndex = 0;
            this.textMail.Text = "beluhbo82@gmail.com";
            this.textMail.UseSelectable = true;
            this.textMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textPassw
            // 
            // 
            // 
            // 
            this.textPassw.CustomButton.Image = null;
            this.textPassw.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.textPassw.CustomButton.Name = "";
            this.textPassw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textPassw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textPassw.CustomButton.TabIndex = 1;
            this.textPassw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textPassw.CustomButton.UseSelectable = true;
            this.textPassw.CustomButton.Visible = false;
            this.textPassw.Lines = new string[] {
        "password"};
            this.textPassw.Location = new System.Drawing.Point(279, 92);
            this.textPassw.MaxLength = 32767;
            this.textPassw.Name = "textPassw";
            this.textPassw.PasswordChar = '*';
            this.textPassw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textPassw.SelectedText = "";
            this.textPassw.SelectionLength = 0;
            this.textPassw.SelectionStart = 0;
            this.textPassw.ShortcutsEnabled = true;
            this.textPassw.Size = new System.Drawing.Size(144, 23);
            this.textPassw.TabIndex = 0;
            this.textPassw.Text = "password";
            this.textPassw.UseSelectable = true;
            this.textPassw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textPassw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(190, 63);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(47, 17);
            this.mailLabel.TabIndex = 1;
            this.mailLabel.Text = "E-mail";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(190, 92);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(69, 17);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(193, 175);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(320, 175);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseSelectable = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.textPassw);
            this.Controls.Add(this.textMail);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textMail;
        private MetroFramework.Controls.MetroTextBox textPassw;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label passLabel;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroButton exitButton;
    }
}