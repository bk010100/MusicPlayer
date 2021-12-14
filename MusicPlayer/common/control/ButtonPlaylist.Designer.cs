
namespace MusicPlayer.common.control
{
    partial class ButtonPlaylist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonPlaylist));
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.AutoEllipsis = true;
            this.btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn.BackColor = System.Drawing.Color.Transparent;
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Image = ((System.Drawing.Image)(resources.GetObject("btn.Image")));
            this.btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Margin = new System.Windows.Forms.Padding(0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(180, 190);
            this.btn.TabIndex = 0;
            this.btn.Text = "Playlist name dsadaadsds";
            this.btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.OnBtnPlaylistClick);
            // 
            // ButtonPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn);
            this.Margin = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.PlaylistName = "ButtonPlaylist";
            this.Size = new System.Drawing.Size(180, 190);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
    }
}
