using MusicPlayer.common.component;
using MusicPlayer.common.control;

namespace MusicPlayer.view.ui
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
            this.components = new System.ComponentModel.Container();
            this.tblSongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicPlayerDataSet = new MusicPlayer.model.data.MusicPlayerDataSet();
            this.tblSongTableAdapter = new MusicPlayer.model.data.MusicPlayerDataSetTableAdapters.TblSongTableAdapter();
            this.panelBackground = new MusicPlayer.common.component.GradientPanel();
            this.songListViewContainer = new System.Windows.Forms.Integration.ElementHost();
            this.songListView = new MusicPlayer.common.control.SongListView();
            ((System.ComponentModel.ISupportInitialize)(this.tblSongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSet)).BeginInit();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblSongBindingSource
            // 
            this.tblSongBindingSource.DataMember = "TblSong";
            this.tblSongBindingSource.DataSource = this.musicPlayerDataSet;
            // 
            // musicPlayerDataSet
            // 
            this.musicPlayerDataSet.DataSetName = "MusicPlayerDataSet";
            this.musicPlayerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSongTableAdapter
            // 
            this.tblSongTableAdapter.ClearBeforeFill = true;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.White;
            this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelBackground.ColorBottom = System.Drawing.Color.Blue;
            this.panelBackground.ColorTop = System.Drawing.Color.LavenderBlush;
            this.panelBackground.Controls.Add(this.songListViewContainer);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.GradientAngel = 90F;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1000, 600);
            this.panelBackground.TabIndex = 0;
            // 
            // songListViewContainer
            // 
            this.songListViewContainer.BackColor = System.Drawing.Color.Transparent;
            this.songListViewContainer.BackColorTransparent = true;
            this.songListViewContainer.Location = new System.Drawing.Point(242, 107);
            this.songListViewContainer.Name = "songListViewContainer";
            this.songListViewContainer.Size = new System.Drawing.Size(543, 391);
            this.songListViewContainer.TabIndex = 2;
            this.songListViewContainer.Child = this.songListView;
            // 
            // FormSongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSongList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SongListForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.tblSongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayerDataSet)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel panelBackground;
        private model.data.MusicPlayerDataSet musicPlayerDataSet;
        private System.Windows.Forms.BindingSource tblSongBindingSource;
        private model.data.MusicPlayerDataSetTableAdapters.TblSongTableAdapter tblSongTableAdapter;
        private System.Windows.Forms.Integration.ElementHost songListViewContainer;
        private SongListView songListView;
    }
}