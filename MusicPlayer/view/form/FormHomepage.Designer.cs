
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    partial class HomepageForm
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPlaylists = new System.Windows.Forms.Button();
            this.btnSongs = new System.Windows.Forms.Button();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            this.btnMinimizeApp = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.panelBackground = new MusicPlayer.common.control.GradientPanel();
            this.panelChildForm = new MusicPlayer.common.control.GradientPanel();
            this.panelMenu.SuspendLayout();
            this.panelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.btnHomepage);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnPlaylists);
            this.panelMenu.Controls.Add(this.btnSongs);
            this.panelMenu.ForeColor = System.Drawing.Color.DimGray;
            this.panelMenu.Location = new System.Drawing.Point(0, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(186, 765);
            this.panelMenu.TabIndex = 1;
            // 
            // btnHomepage
            // 
            this.btnHomepage.BackColor = System.Drawing.Color.Transparent;
            this.btnHomepage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHomepage.BackgroundImage")));
            this.btnHomepage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHomepage.FlatAppearance.BorderSize = 0;
            this.btnHomepage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHomepage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHomepage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomepage.Font = new System.Drawing.Font("Tempus Sans ITC", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomepage.ForeColor = System.Drawing.Color.Brown;
            this.btnHomepage.Location = new System.Drawing.Point(12, 58);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(155, 146);
            this.btnHomepage.TabIndex = 3;
            this.btnHomepage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomepage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomepage.UseVisualStyleBackColor = false;
            this.btnHomepage.Click += new System.EventHandler(this.OnClickBtnHomepage);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(12, 491);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(155, 128);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.OnClickBtnSettings);
            // 
            // btnPlaylists
            // 
            this.btnPlaylists.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylists.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlaylists.FlatAppearance.BorderSize = 0;
            this.btnPlaylists.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlaylists.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylists.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylists.ForeColor = System.Drawing.Color.White;
            this.btnPlaylists.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylists.Image")));
            this.btnPlaylists.Location = new System.Drawing.Point(12, 357);
            this.btnPlaylists.Name = "btnPlaylists";
            this.btnPlaylists.Size = new System.Drawing.Size(155, 128);
            this.btnPlaylists.TabIndex = 1;
            this.btnPlaylists.Text = "Playlists";
            this.btnPlaylists.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlaylists.UseVisualStyleBackColor = false;
            this.btnPlaylists.Click += new System.EventHandler(this.OnClickBtnPlaylists);
            // 
            // btnSongs
            // 
            this.btnSongs.BackColor = System.Drawing.Color.Transparent;
            this.btnSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSongs.FlatAppearance.BorderSize = 0;
            this.btnSongs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSongs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongs.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongs.ForeColor = System.Drawing.Color.Transparent;
            this.btnSongs.Image = ((System.Drawing.Image)(resources.GetObject("btnSongs.Image")));
            this.btnSongs.Location = new System.Drawing.Point(12, 232);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Size = new System.Drawing.Size(155, 119);
            this.btnSongs.TabIndex = 0;
            this.btnSongs.Text = "Songs";
            this.btnSongs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSongs.UseVisualStyleBackColor = false;
            this.btnSongs.Click += new System.EventHandler(this.OnClickBtnSongs);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelTitlebar.Controls.Add(this.lbTitle);
            this.panelTitlebar.Controls.Add(this.imgIcon);
            this.panelTitlebar.Controls.Add(this.btnMinimizeApp);
            this.panelTitlebar.Controls.Add(this.btnCloseApp);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Padding = new System.Windows.Forms.Padding(1);
            this.panelTitlebar.Size = new System.Drawing.Size(1200, 30);
            this.panelTitlebar.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lbTitle.Location = new System.Drawing.Point(36, 6);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(124, 18);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Music Player 1.0.0";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgIcon
            // 
            this.imgIcon.BackColor = System.Drawing.Color.Transparent;
            this.imgIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgIcon.BackgroundImage")));
            this.imgIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgIcon.Location = new System.Drawing.Point(10, 6);
            this.imgIcon.Margin = new System.Windows.Forms.Padding(5);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(18, 23);
            this.imgIcon.TabIndex = 2;
            this.imgIcon.TabStop = false;
            // 
            // btnMinimizeApp
            // 
            this.btnMinimizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeApp.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimizeApp.FlatAppearance.BorderSize = 0;
            this.btnMinimizeApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizeApp.Image")));
            this.btnMinimizeApp.Location = new System.Drawing.Point(1142, 13);
            this.btnMinimizeApp.Name = "btnMinimizeApp";
            this.btnMinimizeApp.Size = new System.Drawing.Size(20, 5);
            this.btnMinimizeApp.TabIndex = 1;
            this.btnMinimizeApp.UseVisualStyleBackColor = false;
            this.btnMinimizeApp.Click += new System.EventHandler(this.OnClickBtnMinimizeApp);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseApp.Image")));
            this.btnCloseApp.Location = new System.Drawing.Point(1174, 1);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(22, 29);
            this.btnCloseApp.TabIndex = 0;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.OnClickBtnCloseApp);
            // 
            // panelBackground
            // 
            this.panelBackground.AutoSize = true;
            this.panelBackground.BackColor = System.Drawing.Color.Transparent;
            this.panelBackground.ColorBottom = System.Drawing.Color.Transparent;
            this.panelBackground.ColorTop = System.Drawing.Color.Transparent;
            this.panelBackground.Controls.Add(this.panelChildForm);
            this.panelBackground.Controls.Add(this.panelTitlebar);
            this.panelBackground.Controls.Add(this.panelMenu);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Font = new System.Drawing.Font("Malgun Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBackground.ForeColor = System.Drawing.Color.Transparent;
            this.panelBackground.GradientAngel = 90F;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1200, 768);
            this.panelBackground.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Black;
            this.panelChildForm.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelChildForm.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChildForm.GradientAngel = 90F;
            this.panelChildForm.Location = new System.Drawing.Point(182, 30);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1018, 738);
            this.panelChildForm.TabIndex = 3;
            // 
            // HomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 768);
            this.Controls.Add(this.panelBackground);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "HomepageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OnLoad);
            this.panelMenu.ResumeLayout(false);
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenu;
        private Button btnHomepage;
        private Button btnSettings;
        private Button btnPlaylists;
        private Button btnSongs;
        private Panel panelTitlebar;
        private Label lbTitle;
        private PictureBox imgIcon;
        private Button btnMinimizeApp;
        private Button btnCloseApp;
        private common.control.GradientPanel panelBackground;
        private common.control.GradientPanel panelChildForm;
    }
}

