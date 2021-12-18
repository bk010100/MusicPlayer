using System;
using System.Windows.Forms;

namespace MusicPlayer.common.dialog
{
    public partial class DialogEditSong : Form
    {
        private string songName, songArtist;


        public string SongName { get => songName; set => songName = value; }
        public string SongArtist { get => songArtist; set => songArtist = value; }


        public DialogEditSong()
        {
            InitializeComponent();
        }

        private void OnLoadDialog(object sender, EventArgs e)
        {
            tbName.Text = SongName;
            tbArtist.Text = SongArtist;
        }


        private void OnClickBtnOk(object sender, EventArgs e)
        {
            if (tbName.Text == null || tbName.Text.Length < 2) MessageBox.Show("Song name must have at least 2 characters.", "Song name is too short!");
            else if (tbArtist.Text == null || tbArtist.Text.Length < 2) MessageBox.Show("Artist(s) name must have at least 2 characters.", "Artist(s) name is too short!");
            else
            {
                SongName = tbName.Text;
                SongArtist = tbArtist.Text;
                Close();
            }                
        }


        private void OnClickBtnCancel(object sender, EventArgs e)
        {
            songName = null;
            songArtist = null;
            Close();
        }

    }
}
