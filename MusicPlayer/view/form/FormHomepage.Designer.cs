
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer
{
    partial class FormHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomepage));
            this.panel = new MusicPlayer.common.control.GradientPanel();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnPlaylists = new System.Windows.Forms.Button();
            this.btnSongs = new System.Windows.Forms.Button();
            this.pnBackground = new MusicPlayer.common.control.GradientPanel();
            this.btnLogoAbout = new System.Windows.Forms.Button();
            this.lbAppName = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnMinimizeApp = new System.Windows.Forms.Button();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnTitlebar = new MusicPlayer.common.control.DraggableTitlebarPanel();
            this.panel.SuspendLayout();
            this.pnBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.pnTitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.ColorBottom = System.Drawing.Color.Black;
            this.panel.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel.Controls.Add(this.btnLogo);
            this.panel.Controls.Add(this.btnAbout);
            this.panel.Controls.Add(this.btnPlaylists);
            this.panel.Controls.Add(this.btnSongs);
            this.panel.GradientAngel = 0F;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(183, 768);
            this.panel.TabIndex = 4;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogo.BackgroundImage")));
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogo.Enabled = false;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Tempus Sans ITC", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.ForeColor = System.Drawing.Color.Brown;
            this.btnLogo.Location = new System.Drawing.Point(12, 58);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(155, 146);
            this.btnLogo.TabIndex = 3;
            this.btnLogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogo.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.Location = new System.Drawing.Point(12, 491);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(155, 128);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.OnClickBtnAbout);
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
            // pnBackground
            // 
            this.pnBackground.BackColor = System.Drawing.Color.Black;
            this.pnBackground.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnBackground.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnBackground.Controls.Add(this.btnLogoAbout);
            this.pnBackground.Controls.Add(this.lbAppName);
            this.pnBackground.Controls.Add(this.lbVersion);
            this.pnBackground.GradientAngel = 90F;
            this.pnBackground.Location = new System.Drawing.Point(183, 27);
            this.pnBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(1017, 741);
            this.pnBackground.TabIndex = 3;
            // 
            // btnLogoAbout
            // 
            this.btnLogoAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogoAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogoAbout.BackgroundImage")));
            this.btnLogoAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogoAbout.Enabled = false;
            this.btnLogoAbout.FlatAppearance.BorderSize = 0;
            this.btnLogoAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogoAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogoAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoAbout.Font = new System.Drawing.Font("Tempus Sans ITC", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoAbout.ForeColor = System.Drawing.Color.White;
            this.btnLogoAbout.Location = new System.Drawing.Point(425, 206);
            this.btnLogoAbout.Name = "btnLogoAbout";
            this.btnLogoAbout.Size = new System.Drawing.Size(127, 147);
            this.btnLogoAbout.TabIndex = 3;
            this.btnLogoAbout.UseVisualStyleBackColor = false;
            // 
            // lbAppName
            // 
            this.lbAppName.AutoSize = true;
            this.lbAppName.BackColor = System.Drawing.Color.Transparent;
            this.lbAppName.Enabled = false;
            this.lbAppName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAppName.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppName.Location = new System.Drawing.Point(394, 356);
            this.lbAppName.Name = "lbAppName";
            this.lbAppName.Size = new System.Drawing.Size(181, 35);
            this.lbAppName.TabIndex = 3;
            this.lbAppName.Text = "Music Player";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.Enabled = false;
            this.lbVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbVersion.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(420, 409);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(131, 25);
            this.lbVersion.TabIndex = 3;
            this.lbVersion.Text = "Version: 1.0.0";
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
            this.btnCloseApp.Location = new System.Drawing.Point(1173, 1);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(22, 29);
            this.btnCloseApp.TabIndex = 0;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.OnClickBtnCloseApp);
            // 
            // btnMinimizeApp
            // 
            this.btnMinimizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeApp.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizeApp.BackgroundImage")));
            this.btnMinimizeApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizeApp.FlatAppearance.BorderSize = 0;
            this.btnMinimizeApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeApp.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizeApp.Location = new System.Drawing.Point(1141, 8);
            this.btnMinimizeApp.Name = "btnMinimizeApp";
            this.btnMinimizeApp.Size = new System.Drawing.Size(26, 18);
            this.btnMinimizeApp.TabIndex = 1;
            this.btnMinimizeApp.UseVisualStyleBackColor = false;
            this.btnMinimizeApp.Click += new System.EventHandler(this.OnClickBtnMinimizeApp);
            // 
            // imgIcon
            // 
            this.imgIcon.BackColor = System.Drawing.Color.Transparent;
            this.imgIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgIcon.BackgroundImage")));
            this.imgIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgIcon.Location = new System.Drawing.Point(7, 4);
            this.imgIcon.Margin = new System.Windows.Forms.Padding(5);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Size = new System.Drawing.Size(18, 23);
            this.imgIcon.TabIndex = 2;
            this.imgIcon.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTitle.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lbTitle.Location = new System.Drawing.Point(33, 5);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(124, 18);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Music Player 1.0.0";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnTitlebar
            // 
            this.pnTitlebar.BackColor = System.Drawing.Color.Black;
            this.pnTitlebar.Controls.Add(this.btnMinimizeApp);
            this.pnTitlebar.Controls.Add(this.btnCloseApp);
            this.pnTitlebar.Controls.Add(this.lbTitle);
            this.pnTitlebar.Controls.Add(this.imgIcon);
            this.pnTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitlebar.Location = new System.Drawing.Point(0, 0);
            this.pnTitlebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnTitlebar.Name = "pnTitlebar";
            this.pnTitlebar.Padding = new System.Windows.Forms.Padding(2);
            this.pnTitlebar.Size = new System.Drawing.Size(1200, 27);
            this.pnTitlebar.TabIndex = 3;
            // 
            // FormHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 768);
            this.ControlBox = false;
            this.Controls.Add(this.pnTitlebar);
            this.Controls.Add(this.pnBackground);
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OnLoadForm);
            this.panel.ResumeLayout(false);
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.pnTitlebar.ResumeLayout(false);
            this.pnTitlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnLogo;
        private Button btnAbout;
        private Button btnPlaylists;
        private Button btnSongs;
        private common.control.GradientPanel panel;
        private Button btnCloseApp;
        private Button btnMinimizeApp;
        private PictureBox imgIcon;
        private Label lbTitle;
        private common.control.DraggableTitlebarPanel pnTitlebar;
        private Label lbVersion;
        private Label lbAppName;
        private Button btnLogoAbout;
        private common.control.GradientPanel pnBackground;
    }
}

