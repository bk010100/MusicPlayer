
namespace MusicPlayer.view.ui
{
    partial class FormPlaylistList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlaylistList));
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.panelBackground = new MusicPlayer.common.component.GradientPanel();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPlaylist.FlatAppearance.BorderSize = 0;
            this.btnAddPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlaylist.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnAddPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPlaylist.Image")));
            this.btnAddPlaylist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPlaylist.Location = new System.Drawing.Point(104, 119);
            this.btnAddPlaylist.Margin = new System.Windows.Forms.Padding(40, 10, 40, 10);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(159, 165);
            this.btnAddPlaylist.TabIndex = 0;
            this.btnAddPlaylist.Text = "Add playlist ";
            this.btnAddPlaylist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddPlaylist.UseVisualStyleBackColor = false;
            // 
            // panelBackground
            // 
            this.panelBackground.ColorBottom = System.Drawing.Color.DimGray;
            this.panelBackground.ColorTop = System.Drawing.Color.LightSlateGray;
            this.panelBackground.Controls.Add(this.btnAddPlaylist);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.GradientAngel = 90F;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1000, 600);
            this.panelBackground.TabIndex = 1;
            // 
            // PlaylistListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelBackground);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlaylistListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnLoad);
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPlaylist;
        private common.component.GradientPanel panelBackground;
    }
}