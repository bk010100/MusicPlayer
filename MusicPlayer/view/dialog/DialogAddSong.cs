using MusicPlayer.model.model;
using MusicPlayer.viewmodel.util;
using System;
using System.Windows.Forms;
using TagLib;

namespace MusicPlayer.common.dialog
{
    public partial class DialogAddSong : Form
    {
        private Song newSong = new Song();
        private string filePath, name, artist, fileName, length;
        private int duration = 0;


        public Song NewSong => newSong;
        public string FilePath => filePath;


        public DialogAddSong()
        {
            InitializeComponent();
        }


        private void OnLoadDialog(object sender, EventArgs e)
        {

        }


        private void ShowSelectedSongInfo()
        {
            GetSongInfo();
            tbFilePath.Text = filePath;
            tbName.Text = name;
            tbArtist.Text = artist;
            tbLength.Text = length;
        }


        private void GetSongInfo()
        {
            File file = File.Create(filePath);
            name = file.Tag.Title;
            artist = file.Tag.FirstPerformer != null ? file.Tag.FirstPerformer.ToString() : "";
            duration = (int)file.Properties.Duration.TotalSeconds;
            fileName = FileUtil.GetFileName(filePath);

            // Get length            
            int minute = duration / 60;
            int second = duration - minute * 60;
            string secondString = second < 10 ? "0" + second : second.ToString();
            length = "0" + minute + ":" + secondString;
        }


        private void OnClickBtnBrowse(object sender, EventArgs e)
        {
            dialogOpenFile.ShowDialog();
            filePath = dialogOpenFile.FileName;
            if (filePath != "") ShowSelectedSongInfo();
        }


        private void OnClickBtnOk(object sender, EventArgs e)
        {
            if (tbName.Text == null || tbName.Text.Length < 2) MessageBox.Show("Song name must have at least 2 characters.", "Song name is too short!");
            else if (tbArtist.Text == null || tbArtist.Text.Length < 2) MessageBox.Show("Artist(s) name must have at least 2 characters.", "Artist(s) name is too short!");
            else
            {
                newSong = new Song
                {
                    Name = tbName.Text,
                    Artist = tbArtist.Text,
                    Duration = duration,
                    FileName = fileName,
                    Length = length
                };
                Close();
            }            
        }


        private void OnClickBtnCancel(object sender, EventArgs e)
        {
            newSong = null;
            Close();
        }

    }
}
