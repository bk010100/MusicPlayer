
namespace MusicPlayer.view.form
{
    partial class FormPlayingSongList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayingSongList));
            this.pnPlayerBar = new System.Windows.Forms.Panel();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.lbSongLength = new System.Windows.Forms.Label();
            this.lbSongTimer = new System.Windows.Forms.Label();
            this.tbVolume = new System.Windows.Forms.TrackBar();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.ttNotify = new System.Windows.Forms.ToolTip(this.components);
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.pnTitlebar = new MusicPlayer.common.control.DraggableTitlebarPanel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnMinimizeWindow = new System.Windows.Forms.Button();
            this.tbSongDurationBar = new System.Windows.Forms.Integration.ElementHost();
            this.sliderSongDuration = new MusicPlayer.common.control.TrackBar();
            this.gradientPanel2 = new MusicPlayer.common.control.GradientPanel();
            this.dataGrid = new System.Windows.Forms.Integration.ElementHost();
            this.dgSongList = new MusicPlayer.common.control.SongDataGrid();
            this.pnPlayerBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).BeginInit();
            this.pnTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPlayerBar
            // 
            this.pnPlayerBar.BackColor = System.Drawing.Color.Black;
            this.pnPlayerBar.Controls.Add(this.btnRepeat);
            this.pnPlayerBar.Controls.Add(this.tbSongDurationBar);
            this.pnPlayerBar.Controls.Add(this.lbSongLength);
            this.pnPlayerBar.Controls.Add(this.lbSongTimer);
            this.pnPlayerBar.Controls.Add(this.tbVolume);
            this.pnPlayerBar.Controls.Add(this.btnVolume);
            this.pnPlayerBar.Controls.Add(this.btnPrevious);
            this.pnPlayerBar.Controls.Add(this.btnNext);
            this.pnPlayerBar.Controls.Add(this.btnPlay);
            this.pnPlayerBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnPlayerBar.Location = new System.Drawing.Point(0, 660);
            this.pnPlayerBar.Margin = new System.Windows.Forms.Padding(0);
            this.pnPlayerBar.Name = "pnPlayerBar";
            this.pnPlayerBar.Size = new System.Drawing.Size(500, 108);
            this.pnPlayerBar.TabIndex = 4;
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackgroundImage = global::MusicPlayer.Properties.Resources.replay_all_64;
            this.btnRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRepeat.FlatAppearance.BorderSize = 0;
            this.btnRepeat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRepeat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.ForeColor = System.Drawing.Color.Black;
            this.btnRepeat.Location = new System.Drawing.Point(26, 61);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(32, 28);
            this.btnRepeat.TabIndex = 9;
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.OnClickBtnRepeat);
            // 
            // lbSongLength
            // 
            this.lbSongLength.AutoSize = true;
            this.lbSongLength.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongLength.ForeColor = System.Drawing.Color.White;
            this.lbSongLength.Location = new System.Drawing.Point(458, 22);
            this.lbSongLength.Name = "lbSongLength";
            this.lbSongLength.Size = new System.Drawing.Size(39, 17);
            this.lbSongLength.TabIndex = 7;
            this.lbSongLength.Text = "00:00";
            // 
            // lbSongTimer
            // 
            this.lbSongTimer.AutoSize = true;
            this.lbSongTimer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongTimer.ForeColor = System.Drawing.Color.White;
            this.lbSongTimer.Location = new System.Drawing.Point(3, 22);
            this.lbSongTimer.Name = "lbSongTimer";
            this.lbSongTimer.Size = new System.Drawing.Size(39, 17);
            this.lbSongTimer.TabIndex = 6;
            this.lbSongTimer.Text = "00:00";
            // 
            // tbVolume
            // 
            this.tbVolume.AutoSize = false;
            this.tbVolume.Location = new System.Drawing.Point(384, 54);
            this.tbVolume.Margin = new System.Windows.Forms.Padding(0);
            this.tbVolume.Maximum = 20;
            this.tbVolume.Name = "tbVolume";
            this.tbVolume.Size = new System.Drawing.Size(115, 45);
            this.tbVolume.TabIndex = 4;
            this.tbVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbVolume.Value = 20;
            this.tbVolume.ValueChanged += new System.EventHandler(this.OnValueChangeInTrackbarVolume);
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.Transparent;
            this.btnVolume.BackgroundImage = global::MusicPlayer.Properties.Resources.volume_64;
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.Location = new System.Drawing.Point(350, 55);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(34, 34);
            this.btnVolume.TabIndex = 3;
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.OnClickBtnVolume);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.BackgroundImage")));
            this.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(145, 45);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(54, 54);
            this.btnPrevious.TabIndex = 2;
            this.ttNotify.SetToolTip(this.btnPrevious, "Previous Song");
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.OnClickBtnPrevious);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(267, 45);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 54);
            this.btnNext.TabIndex = 1;
            this.ttNotify.SetToolTip(this.btnNext, "Next Song");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.OnClickBtnNext);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::MusicPlayer.Properties.Resources.pause_64;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(209, 45);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(10);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 54);
            this.btnPlay.TabIndex = 0;
            this.ttNotify.SetToolTip(this.btnPlay, "Play");
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.OnClickBtnPlay);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 100);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Child = null;
            // 
            // pnTitlebar
            // 
            this.pnTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnTitlebar.Controls.Add(this.lbTitle);
            this.pnTitlebar.Controls.Add(this.pbIcon);
            this.pnTitlebar.Controls.Add(this.btnCloseWindow);
            this.pnTitlebar.Controls.Add(this.btnMinimizeWindow);
            this.pnTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitlebar.Location = new System.Drawing.Point(0, 0);
            this.pnTitlebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnTitlebar.Name = "pnTitlebar";
            this.pnTitlebar.Padding = new System.Windows.Forms.Padding(2);
            this.pnTitlebar.Size = new System.Drawing.Size(500, 27);
            this.pnTitlebar.TabIndex = 5;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(22, 2);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(73, 19);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Now playing";
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbIcon.BackgroundImage")));
            this.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIcon.Location = new System.Drawing.Point(2, 4);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(20, 20);
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseWindow.BackgroundImage")));
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCloseWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Location = new System.Drawing.Point(471, 6);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(20, 18);
            this.btnCloseWindow.TabIndex = 1;
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.OnClickButtonCloseWindow);
            // 
            // btnMinimizeWindow
            // 
            this.btnMinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizeWindow.BackgroundImage")));
            this.btnMinimizeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btnMinimizeWindow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeWindow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeWindow.Location = new System.Drawing.Point(445, 9);
            this.btnMinimizeWindow.Name = "btnMinimizeWindow";
            this.btnMinimizeWindow.Size = new System.Drawing.Size(20, 13);
            this.btnMinimizeWindow.TabIndex = 2;
            this.btnMinimizeWindow.UseVisualStyleBackColor = false;
            this.btnMinimizeWindow.Click += new System.EventHandler(this.OnClickBtnMinimizeWindow);
            // 
            // tbSongDurationBar
            // 
            this.tbSongDurationBar.BackColor = System.Drawing.Color.Black;
            this.tbSongDurationBar.Enabled = false;
            this.tbSongDurationBar.Location = new System.Drawing.Point(12, 4);
            this.tbSongDurationBar.Name = "tbSongDurationBar";
            this.tbSongDurationBar.Size = new System.Drawing.Size(476, 18);
            this.tbSongDurationBar.TabIndex = 8;
            this.tbSongDurationBar.TabStop = false;
            this.tbSongDurationBar.Child = this.sliderSongDuration;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.Black;
            this.gradientPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientPanel2.Controls.Add(this.dataGrid);
            this.gradientPanel2.GradientAngel = 90F;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 27);
            this.gradientPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(500, 633);
            this.gradientPanel2.TabIndex = 3;
            // 
            // dataGrid
            // 
            this.dataGrid.BackColor = System.Drawing.Color.Transparent;
            this.dataGrid.Location = new System.Drawing.Point(-1, 0);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(500, 633);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.Child = this.dgSongList;
            // 
            // FormPlayingSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 768);
            this.ControlBox = false;
            this.Controls.Add(this.pnTitlebar);
            this.Controls.Add(this.pnPlayerBar);
            this.Controls.Add(this.gradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1200, 120);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlayingSongList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.OnLoadForm);
            this.Shown += new System.EventHandler(this.PlaySongOnShownForm);
            this.Disposed += new System.EventHandler(this.ClosePlayerOnDepose);
            this.pnPlayerBar.ResumeLayout(false);
            this.pnPlayerBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolume)).EndInit();
            this.pnTitlebar.ResumeLayout(false);
            this.pnTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMinimizeWindow;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lbTitle;
        private common.control.GradientPanel gradientPanel2;
        private System.Windows.Forms.Panel pnPlayerBar;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TrackBar tbVolume;
        private System.Windows.Forms.ToolTip ttNotify;
        private System.Windows.Forms.Integration.ElementHost dataGrid;
        private common.control.SongDataGrid dgSongList;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private common.control.DraggableTitlebarPanel pnTitlebar;
        private System.Windows.Forms.Label lbSongLength;
        private System.Windows.Forms.Label lbSongTimer;
        private System.Windows.Forms.Integration.ElementHost tbSongDurationBar;
        private common.control.TrackBar sliderSongDuration;
        private System.Windows.Forms.Button btnRepeat;
    }
}