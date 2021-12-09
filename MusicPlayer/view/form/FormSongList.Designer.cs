using MusicPlayer.common.control;

namespace MusicPlayer.view.form
{
    partial class FormSongList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSongList));
            this.panelBackground = new MusicPlayer.common.control.GradientPanel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbSongCount = new System.Windows.Forms.Label();
            this.lbPlaylistName = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.Integration.ElementHost();
            this.dgSongList = new MusicPlayer.common.control.SongDataGrid();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.Black;
            this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBackground.ColorBottom = System.Drawing.Color.Black;
            this.panelBackground.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelBackground.Controls.Add(this.pbImage);
            this.panelBackground.Controls.Add(this.lbSongCount);
            this.panelBackground.Controls.Add(this.lbPlaylistName);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBackground.GradientAngel = 90F;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1100, 250);
            this.panelBackground.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImage.BackgroundImage")));
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.Location = new System.Drawing.Point(12, 36);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(167, 168);
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // lbSongCount
            // 
            this.lbSongCount.AutoSize = true;
            this.lbSongCount.BackColor = System.Drawing.Color.Transparent;
            this.lbSongCount.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongCount.ForeColor = System.Drawing.Color.White;
            this.lbSongCount.Location = new System.Drawing.Point(190, 143);
            this.lbSongCount.Name = "lbSongCount";
            this.lbSongCount.Size = new System.Drawing.Size(68, 25);
            this.lbSongCount.TabIndex = 3;
            this.lbSongCount.Text = "label2";
            // 
            // lbPlaylistName
            // 
            this.lbPlaylistName.AutoSize = true;
            this.lbPlaylistName.BackColor = System.Drawing.Color.Transparent;
            this.lbPlaylistName.Font = new System.Drawing.Font("Bahnschrift", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaylistName.ForeColor = System.Drawing.Color.White;
            this.lbPlaylistName.Location = new System.Drawing.Point(185, 65);
            this.lbPlaylistName.Name = "lbPlaylistName";
            this.lbPlaylistName.Size = new System.Drawing.Size(147, 58);
            this.lbPlaylistName.TabIndex = 2;
            this.lbPlaylistName.Text = "label1";
            // 
            // dataGrid
            // 
            this.dataGrid.BackColor = System.Drawing.Color.Transparent;
            this.dataGrid.Location = new System.Drawing.Point(0, 250);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.dataGrid.MinimumSize = new System.Drawing.Size(500, 300);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(1100, 491);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.TabStop = false;
            this.dataGrid.Text = "elementHost1";
            this.dataGrid.Child = this.dgSongList;
            // 
            // FormSongList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.ControlBox = false;
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSongList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SongListForm";
            this.Load += new System.EventHandler(this.OnLoadForm);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel panelBackground;
        private System.Windows.Forms.Integration.ElementHost dataGrid;
        private SongDataGrid dgSongList;
        private System.Windows.Forms.Label lbSongCount;
        private System.Windows.Forms.Label lbPlaylistName;
        private System.Windows.Forms.PictureBox pbImage;
    }
}