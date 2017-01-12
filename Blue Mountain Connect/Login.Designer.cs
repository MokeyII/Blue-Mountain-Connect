namespace Blue_Mountain_Connect
{
    partial class Login
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
            this.metroBtnLogin = new MetroFramework.Controls.MetroButton();
            this.metroTxtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroTxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroBtnLogin
            // 
            this.metroBtnLogin.Highlight = true;
            this.metroBtnLogin.Location = new System.Drawing.Point(223, 300);
            this.metroBtnLogin.Name = "metroBtnLogin";
            this.metroBtnLogin.Size = new System.Drawing.Size(75, 23);
            this.metroBtnLogin.Style = MetroFramework.MetroColorStyle.Black;
            this.metroBtnLogin.TabIndex = 5;
            this.metroBtnLogin.Text = "Login";
            this.metroBtnLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroBtnLogin.UseSelectable = true;
            this.metroBtnLogin.Click += new System.EventHandler(this.metroBtnLogin_Click);
            // 
            // metroTxtUsername
            // 
            // 
            // 
            // 
            this.metroTxtUsername.CustomButton.Image = null;
            this.metroTxtUsername.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.metroTxtUsername.CustomButton.Name = "";
            this.metroTxtUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtUsername.CustomButton.TabIndex = 1;
            this.metroTxtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtUsername.CustomButton.UseSelectable = true;
            this.metroTxtUsername.CustomButton.Visible = false;
            this.metroTxtUsername.Lines = new string[] {
        "Ex. John.S"};
            this.metroTxtUsername.Location = new System.Drawing.Point(194, 230);
            this.metroTxtUsername.MaxLength = 32767;
            this.metroTxtUsername.Name = "metroTxtUsername";
            this.metroTxtUsername.PasswordChar = '\0';
            this.metroTxtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtUsername.SelectedText = "";
            this.metroTxtUsername.SelectionLength = 0;
            this.metroTxtUsername.SelectionStart = 0;
            this.metroTxtUsername.ShortcutsEnabled = true;
            this.metroTxtUsername.Size = new System.Drawing.Size(145, 23);
            this.metroTxtUsername.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTxtUsername.TabIndex = 6;
            this.metroTxtUsername.Text = "Ex. John.S";
            this.metroTxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTxtUsername.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtUsername.UseSelectable = true;
            this.metroTxtUsername.UseStyleColors = true;
            this.metroTxtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTxtUsername.Click += new System.EventHandler(this.metroTxtUsername_Click);
            this.metroTxtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTxtUsername_KeyPress);
            // 
            // metroTxtPassword
            // 
            // 
            // 
            // 
            this.metroTxtPassword.CustomButton.Image = null;
            this.metroTxtPassword.CustomButton.Location = new System.Drawing.Point(123, 1);
            this.metroTxtPassword.CustomButton.Name = "";
            this.metroTxtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtPassword.CustomButton.TabIndex = 1;
            this.metroTxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtPassword.CustomButton.UseSelectable = true;
            this.metroTxtPassword.CustomButton.Visible = false;
            this.metroTxtPassword.Lines = new string[] {
        "MyPassword13!$"};
            this.metroTxtPassword.Location = new System.Drawing.Point(194, 258);
            this.metroTxtPassword.MaxLength = 32767;
            this.metroTxtPassword.Name = "metroTxtPassword";
            this.metroTxtPassword.PasswordChar = '●';
            this.metroTxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtPassword.SelectedText = "";
            this.metroTxtPassword.SelectionLength = 0;
            this.metroTxtPassword.SelectionStart = 0;
            this.metroTxtPassword.ShortcutsEnabled = true;
            this.metroTxtPassword.Size = new System.Drawing.Size(145, 23);
            this.metroTxtPassword.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTxtPassword.TabIndex = 7;
            this.metroTxtPassword.Text = "MyPassword13!$";
            this.metroTxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTxtPassword.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtPassword.UseSelectable = true;
            this.metroTxtPassword.UseStyleColors = true;
            this.metroTxtPassword.UseSystemPasswordChar = true;
            this.metroTxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTxtPassword.Click += new System.EventHandler(this.metroTxtPassword_Click);
            this.metroTxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTxtPassword_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(105, 233);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Username:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(104, 262);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Password:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTxtPassword);
            this.Controls.Add(this.metroTxtUsername);
            this.Controls.Add(this.metroBtnLogin);
            this.Name = "Login";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroBtnLogin;
        private MetroFramework.Controls.MetroTextBox metroTxtUsername;
        private MetroFramework.Controls.MetroTextBox metroTxtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}