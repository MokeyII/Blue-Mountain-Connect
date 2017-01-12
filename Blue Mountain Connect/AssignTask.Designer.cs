namespace Blue_Mountain_Connect
{
    partial class AssignTask
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
            this.metroBtnSubmitTask = new MetroFramework.Controls.MetroButton();
            this.metroCmbDepartment = new MetroFramework.Controls.MetroComboBox();
            this.metroCmbName = new MetroFramework.Controls.MetroComboBox();
            this.metroLblDepartment = new MetroFramework.Controls.MetroLabel();
            this.metroLbLName = new MetroFramework.Controls.MetroLabel();
            this.metroTxtTaskName = new MetroFramework.Controls.MetroTextBox();
            this.metroTxtTaskDescription = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroBtnBrowseDir = new MetroFramework.Controls.MetroButton();
            this.metroTxtBrowserDirectory = new MetroFramework.Controls.MetroTextBox();
            this.metroTxtDateStart = new MetroFramework.Controls.MetroDateTime();
            this.metroTxtEndDate = new MetroFramework.Controls.MetroDateTime();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // metroBtnSubmitTask
            // 
            this.metroBtnSubmitTask.Highlight = true;
            this.metroBtnSubmitTask.Location = new System.Drawing.Point(201, 673);
            this.metroBtnSubmitTask.Name = "metroBtnSubmitTask";
            this.metroBtnSubmitTask.Size = new System.Drawing.Size(75, 23);
            this.metroBtnSubmitTask.Style = MetroFramework.MetroColorStyle.Black;
            this.metroBtnSubmitTask.TabIndex = 42;
            this.metroBtnSubmitTask.Text = "Submit Task";
            this.metroBtnSubmitTask.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroBtnSubmitTask.UseSelectable = true;
            this.metroBtnSubmitTask.Click += new System.EventHandler(this.metroBtnSubmitTask_Click);
            // 
            // metroCmbDepartment
            // 
            this.metroCmbDepartment.FormattingEnabled = true;
            this.metroCmbDepartment.ItemHeight = 23;
            this.metroCmbDepartment.Location = new System.Drawing.Point(23, 117);
            this.metroCmbDepartment.Name = "metroCmbDepartment";
            this.metroCmbDepartment.Size = new System.Drawing.Size(430, 29);
            this.metroCmbDepartment.Style = MetroFramework.MetroColorStyle.Black;
            this.metroCmbDepartment.TabIndex = 43;
            this.metroCmbDepartment.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCmbDepartment.UseSelectable = true;
            this.metroCmbDepartment.UseStyleColors = true;
            this.metroCmbDepartment.SelectedIndexChanged += new System.EventHandler(this.metroCmbDepartment_SelectedIndexChanged);
            // 
            // metroCmbName
            // 
            this.metroCmbName.FormattingEnabled = true;
            this.metroCmbName.ItemHeight = 23;
            this.metroCmbName.Location = new System.Drawing.Point(23, 171);
            this.metroCmbName.Name = "metroCmbName";
            this.metroCmbName.Size = new System.Drawing.Size(430, 29);
            this.metroCmbName.Style = MetroFramework.MetroColorStyle.Black;
            this.metroCmbName.TabIndex = 44;
            this.metroCmbName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCmbName.UseSelectable = true;
            this.metroCmbName.UseStyleColors = true;
            // 
            // metroLblDepartment
            // 
            this.metroLblDepartment.AutoSize = true;
            this.metroLblDepartment.Location = new System.Drawing.Point(23, 95);
            this.metroLblDepartment.Name = "metroLblDepartment";
            this.metroLblDepartment.Size = new System.Drawing.Size(82, 19);
            this.metroLblDepartment.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLblDepartment.TabIndex = 45;
            this.metroLblDepartment.Text = "Department:";
            this.metroLblDepartment.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLblDepartment.UseStyleColors = true;
            // 
            // metroLbLName
            // 
            this.metroLbLName.AutoSize = true;
            this.metroLbLName.Location = new System.Drawing.Point(23, 149);
            this.metroLbLName.Name = "metroLbLName";
            this.metroLbLName.Size = new System.Drawing.Size(68, 19);
            this.metroLbLName.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLbLName.TabIndex = 46;
            this.metroLbLName.Text = "Assign To:";
            this.metroLbLName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLbLName.UseStyleColors = true;
            // 
            // metroTxtTaskName
            // 
            // 
            // 
            // 
            this.metroTxtTaskName.CustomButton.Image = null;
            this.metroTxtTaskName.CustomButton.Location = new System.Drawing.Point(408, 1);
            this.metroTxtTaskName.CustomButton.Name = "";
            this.metroTxtTaskName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtTaskName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtTaskName.CustomButton.TabIndex = 1;
            this.metroTxtTaskName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtTaskName.CustomButton.UseSelectable = true;
            this.metroTxtTaskName.CustomButton.Visible = false;
            this.metroTxtTaskName.Lines = new string[0];
            this.metroTxtTaskName.Location = new System.Drawing.Point(23, 225);
            this.metroTxtTaskName.MaxLength = 32767;
            this.metroTxtTaskName.Name = "metroTxtTaskName";
            this.metroTxtTaskName.PasswordChar = '\0';
            this.metroTxtTaskName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtTaskName.SelectedText = "";
            this.metroTxtTaskName.SelectionLength = 0;
            this.metroTxtTaskName.SelectionStart = 0;
            this.metroTxtTaskName.ShortcutsEnabled = true;
            this.metroTxtTaskName.Size = new System.Drawing.Size(430, 23);
            this.metroTxtTaskName.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTxtTaskName.TabIndex = 47;
            this.metroTxtTaskName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtTaskName.UseSelectable = true;
            this.metroTxtTaskName.UseStyleColors = true;
            this.metroTxtTaskName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtTaskName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTxtTaskDescription
            // 
            // 
            // 
            // 
            this.metroTxtTaskDescription.CustomButton.Image = null;
            this.metroTxtTaskDescription.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.metroTxtTaskDescription.CustomButton.Name = "";
            this.metroTxtTaskDescription.CustomButton.Size = new System.Drawing.Size(293, 293);
            this.metroTxtTaskDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtTaskDescription.CustomButton.TabIndex = 1;
            this.metroTxtTaskDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtTaskDescription.CustomButton.UseSelectable = true;
            this.metroTxtTaskDescription.CustomButton.Visible = false;
            this.metroTxtTaskDescription.Lines = new string[0];
            this.metroTxtTaskDescription.Location = new System.Drawing.Point(23, 332);
            this.metroTxtTaskDescription.MaxLength = 32767;
            this.metroTxtTaskDescription.Multiline = true;
            this.metroTxtTaskDescription.Name = "metroTxtTaskDescription";
            this.metroTxtTaskDescription.PasswordChar = '\0';
            this.metroTxtTaskDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtTaskDescription.SelectedText = "";
            this.metroTxtTaskDescription.SelectionLength = 0;
            this.metroTxtTaskDescription.SelectionStart = 0;
            this.metroTxtTaskDescription.ShortcutsEnabled = true;
            this.metroTxtTaskDescription.Size = new System.Drawing.Size(430, 295);
            this.metroTxtTaskDescription.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTxtTaskDescription.TabIndex = 48;
            this.metroTxtTaskDescription.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtTaskDescription.UseSelectable = true;
            this.metroTxtTaskDescription.UseStyleColors = true;
            this.metroTxtTaskDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtTaskDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 203);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Task Name:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 251);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 50;
            this.metroLabel2.Text = "Start Date";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(253, 251);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 51;
            this.metroLabel3.Text = "Deadline";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 310);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel4.TabIndex = 52;
            this.metroLabel4.Text = "Task Description";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroBtnBrowseDir
            // 
            this.metroBtnBrowseDir.Highlight = true;
            this.metroBtnBrowseDir.Location = new System.Drawing.Point(421, 644);
            this.metroBtnBrowseDir.Name = "metroBtnBrowseDir";
            this.metroBtnBrowseDir.Size = new System.Drawing.Size(32, 23);
            this.metroBtnBrowseDir.Style = MetroFramework.MetroColorStyle.Black;
            this.metroBtnBrowseDir.TabIndex = 53;
            this.metroBtnBrowseDir.Text = "...";
            this.metroBtnBrowseDir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroBtnBrowseDir.UseSelectable = true;
            this.metroBtnBrowseDir.Click += new System.EventHandler(this.metroBtnBrowseDir_Click);
            // 
            // metroTxtBrowserDirectory
            // 
            // 
            // 
            // 
            this.metroTxtBrowserDirectory.CustomButton.Image = null;
            this.metroTxtBrowserDirectory.CustomButton.Location = new System.Drawing.Point(370, 1);
            this.metroTxtBrowserDirectory.CustomButton.Name = "";
            this.metroTxtBrowserDirectory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTxtBrowserDirectory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTxtBrowserDirectory.CustomButton.TabIndex = 1;
            this.metroTxtBrowserDirectory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtBrowserDirectory.CustomButton.UseSelectable = true;
            this.metroTxtBrowserDirectory.CustomButton.Visible = false;
            this.metroTxtBrowserDirectory.Lines = new string[0];
            this.metroTxtBrowserDirectory.Location = new System.Drawing.Point(23, 644);
            this.metroTxtBrowserDirectory.MaxLength = 32767;
            this.metroTxtBrowserDirectory.Name = "metroTxtBrowserDirectory";
            this.metroTxtBrowserDirectory.PasswordChar = '\0';
            this.metroTxtBrowserDirectory.ReadOnly = true;
            this.metroTxtBrowserDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTxtBrowserDirectory.SelectedText = "";
            this.metroTxtBrowserDirectory.SelectionLength = 0;
            this.metroTxtBrowserDirectory.SelectionStart = 0;
            this.metroTxtBrowserDirectory.ShortcutsEnabled = true;
            this.metroTxtBrowserDirectory.Size = new System.Drawing.Size(392, 23);
            this.metroTxtBrowserDirectory.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTxtBrowserDirectory.TabIndex = 54;
            this.metroTxtBrowserDirectory.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtBrowserDirectory.UseSelectable = true;
            this.metroTxtBrowserDirectory.UseStyleColors = true;
            this.metroTxtBrowserDirectory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTxtBrowserDirectory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTxtDateStart
            // 
            this.metroTxtDateStart.AllowDrop = true;
            this.metroTxtDateStart.Location = new System.Drawing.Point(24, 273);
            this.metroTxtDateStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroTxtDateStart.Name = "metroTxtDateStart";
            this.metroTxtDateStart.Size = new System.Drawing.Size(200, 29);
            this.metroTxtDateStart.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTxtDateStart.TabIndex = 55;
            this.metroTxtDateStart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtDateStart.UseStyleColors = true;
            // 
            // metroTxtEndDate
            // 
            this.metroTxtEndDate.DisplayFocus = true;
            this.metroTxtEndDate.Location = new System.Drawing.Point(253, 273);
            this.metroTxtEndDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroTxtEndDate.Name = "metroTxtEndDate";
            this.metroTxtEndDate.Size = new System.Drawing.Size(200, 29);
            this.metroTxtEndDate.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTxtEndDate.TabIndex = 56;
            this.metroTxtEndDate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTxtEndDate.UseStyleColors = true;
            // 
            // AssignTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 715);
            this.Controls.Add(this.metroTxtEndDate);
            this.Controls.Add(this.metroTxtDateStart);
            this.Controls.Add(this.metroTxtBrowserDirectory);
            this.Controls.Add(this.metroBtnBrowseDir);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTxtTaskDescription);
            this.Controls.Add(this.metroTxtTaskName);
            this.Controls.Add(this.metroLbLName);
            this.Controls.Add(this.metroLblDepartment);
            this.Controls.Add(this.metroCmbName);
            this.Controls.Add(this.metroCmbDepartment);
            this.Controls.Add(this.metroBtnSubmitTask);
            this.Name = "AssignTask";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Assign Task";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AssignTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroBtnSubmitTask;
        private MetroFramework.Controls.MetroComboBox metroCmbDepartment;
        private MetroFramework.Controls.MetroComboBox metroCmbName;
        private MetroFramework.Controls.MetroLabel metroLblDepartment;
        private MetroFramework.Controls.MetroLabel metroLbLName;
        private MetroFramework.Controls.MetroTextBox metroTxtTaskName;
        private MetroFramework.Controls.MetroTextBox metroTxtTaskDescription;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroBtnBrowseDir;
        private MetroFramework.Controls.MetroTextBox metroTxtBrowserDirectory;
        private MetroFramework.Controls.MetroDateTime metroTxtDateStart;
        private MetroFramework.Controls.MetroDateTime metroTxtEndDate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}