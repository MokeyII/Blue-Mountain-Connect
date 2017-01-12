namespace Blue_Mountain_Connect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnTileChat = new MetroFramework.Controls.MetroTile();
            this.btnTileTasks = new MetroFramework.Controls.MetroTile();
            this.btnTileContacts = new MetroFramework.Controls.MetroTile();
            this.btnTileClickTime = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // btnTileChat
            // 
            this.btnTileChat.ActiveControl = null;
            this.btnTileChat.AutoSize = true;
            this.btnTileChat.Location = new System.Drawing.Point(229, 33);
            this.btnTileChat.Name = "btnTileChat";
            this.btnTileChat.Size = new System.Drawing.Size(199, 111);
            this.btnTileChat.TabIndex = 6;
            this.btnTileChat.Text = "BME Chat";
            this.btnTileChat.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTileChat.TileImage = ((System.Drawing.Image)(resources.GetObject("btnTileChat.TileImage")));
            this.btnTileChat.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTileChat.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnTileChat.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnTileChat.UseSelectable = true;
            this.btnTileChat.UseStyleColors = true;
            this.btnTileChat.UseTileImage = true;
            this.btnTileChat.Click += new System.EventHandler(this.btnTileChat_Click);
            // 
            // btnTileTasks
            // 
            this.btnTileTasks.ActiveControl = null;
            this.btnTileTasks.AutoSize = true;
            this.btnTileTasks.Location = new System.Drawing.Point(22, 150);
            this.btnTileTasks.Name = "btnTileTasks";
            this.btnTileTasks.Size = new System.Drawing.Size(199, 111);
            this.btnTileTasks.TabIndex = 7;
            this.btnTileTasks.Text = "Tasks";
            this.btnTileTasks.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTileTasks.TileImage = ((System.Drawing.Image)(resources.GetObject("btnTileTasks.TileImage")));
            this.btnTileTasks.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTileTasks.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnTileTasks.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnTileTasks.UseMnemonic = false;
            this.btnTileTasks.UseSelectable = true;
            this.btnTileTasks.UseStyleColors = true;
            this.btnTileTasks.UseTileImage = true;
            this.btnTileTasks.Click += new System.EventHandler(this.btnTileTasks_Click);
            // 
            // btnTileContacts
            // 
            this.btnTileContacts.ActiveControl = null;
            this.btnTileContacts.AutoSize = true;
            this.btnTileContacts.Location = new System.Drawing.Point(229, 150);
            this.btnTileContacts.Name = "btnTileContacts";
            this.btnTileContacts.Size = new System.Drawing.Size(199, 111);
            this.btnTileContacts.TabIndex = 8;
            this.btnTileContacts.Text = "Contacts";
            this.btnTileContacts.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTileContacts.TileImage = ((System.Drawing.Image)(resources.GetObject("btnTileContacts.TileImage")));
            this.btnTileContacts.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTileContacts.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnTileContacts.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnTileContacts.UseSelectable = true;
            this.btnTileContacts.UseStyleColors = true;
            this.btnTileContacts.UseTileImage = true;
            this.btnTileContacts.Click += new System.EventHandler(this.btnTileContacts_Click);
            // 
            // btnTileClickTime
            // 
            this.btnTileClickTime.ActiveControl = null;
            this.btnTileClickTime.AutoSize = true;
            this.btnTileClickTime.Location = new System.Drawing.Point(23, 33);
            this.btnTileClickTime.Name = "btnTileClickTime";
            this.btnTileClickTime.Size = new System.Drawing.Size(199, 111);
            this.btnTileClickTime.TabIndex = 5;
            this.btnTileClickTime.Text = "Click Time";
            this.btnTileClickTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnTileClickTime.TileImage = ((System.Drawing.Image)(resources.GetObject("btnTileClickTime.TileImage")));
            this.btnTileClickTime.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTileClickTime.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnTileClickTime.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnTileClickTime.UseSelectable = true;
            this.btnTileClickTime.UseStyleColors = true;
            this.btnTileClickTime.UseTileImage = true;
            this.btnTileClickTime.Click += new System.EventHandler(this.btnTileClickTime_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(459, 290);
            this.Controls.Add(this.btnTileContacts);
            this.Controls.Add(this.btnTileTasks);
            this.Controls.Add(this.btnTileChat);
            this.Controls.Add(this.btnTileClickTime);
            this.DisplayHeader = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Text = "Blue Mountain Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnTileChat;
        private MetroFramework.Controls.MetroTile btnTileTasks;
        private MetroFramework.Controls.MetroTile btnTileContacts;
        private MetroFramework.Controls.MetroTile btnTileClickTime;
    }
}

