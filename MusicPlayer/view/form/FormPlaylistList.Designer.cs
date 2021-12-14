
namespace MusicPlayer.view.form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlaylistList));
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnBackground = new MusicPlayer.common.control.GradientPanel();
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.cmsMenu.SuspendLayout();
            this.pnBackground.SuspendLayout();
            this.flPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMenu
            // 
            this.cmsMenu.DropShadowEnabled = false;
            this.cmsMenu.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemOpen,
            this.itemRename,
            this.itemDelete});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(123, 70);
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(122, 22);
            this.itemOpen.Text = "Open";
            // 
            // itemRename
            // 
            this.itemRename.Name = "itemRename";
            this.itemRename.Size = new System.Drawing.Size(122, 22);
            this.itemRename.Text = "Rename";
            // 
            // itemDelete
            // 
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.Size = new System.Drawing.Size(122, 22);
            this.itemDelete.Text = "Delete";
            // 
            // pnBackground
            // 
            this.pnBackground.AutoScroll = true;
            this.pnBackground.ColorBottom = System.Drawing.Color.DimGray;
            this.pnBackground.ColorTop = System.Drawing.Color.LightSlateGray;
            this.pnBackground.Controls.Add(this.flPanel);
            this.pnBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBackground.GradientAngel = 90F;
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(1100, 800);
            this.pnBackground.TabIndex = 1;
            // 
            // flPanel
            // 
            this.flPanel.AutoScroll = true;
            this.flPanel.BackColor = System.Drawing.Color.Transparent;
            this.flPanel.Controls.Add(this.btnAddPlaylist);
            this.flPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flPanel.Location = new System.Drawing.Point(0, 95);
            this.flPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(1100, 705);
            this.flPanel.TabIndex = 1;
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
            this.btnAddPlaylist.Location = new System.Drawing.Point(30, 0);
            this.btnAddPlaylist.Margin = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(180, 190);
            this.btnAddPlaylist.TabIndex = 0;
            this.btnAddPlaylist.Text = "Add playlist ";
            this.btnAddPlaylist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddPlaylist.UseVisualStyleBackColor = false;
            // 
            // FormPlaylistList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.pnBackground);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlaylistList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.OnLoadForm);
            this.cmsMenu.ResumeLayout(false);
            this.pnBackground.ResumeLayout(false);
            this.flPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPlaylist;
        private common.control.GradientPanel pnBackground;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripMenuItem itemRename;
        private System.Windows.Forms.ToolStripMenuItem itemDelete;
    }
}