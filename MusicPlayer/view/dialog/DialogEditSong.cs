using System;
using System.Windows.Forms;

namespace MusicPlayer.common.dialog
{
    public partial class DialogEditSong : Form
    {
        private string[] songInfo = new string[2];


        public string[] SongInfo => songInfo;
        public string SongName { get => songInfo[0]; set => songInfo[0] = value; }
        public string SongArtist { get => songInfo[1]; set => songInfo[1] = value; }


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
            SongName = tbName.Text;
            SongArtist = tbArtist.Text;
            Close();
        }


        private void OnClickBtnCancel(object sender, EventArgs e)
        {
            songInfo = null;
            Close();
        }

    }
}
