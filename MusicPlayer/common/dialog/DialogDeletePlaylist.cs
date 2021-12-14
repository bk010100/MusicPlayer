using MusicPlayer.common.util;
using System;
using System.Windows.Forms;

namespace MusicPlayer.common.dialog
{
    public partial class DialogDeletePlaylist : Form
    {
        private bool deleteConfirmed = false;
        private string playlistName = "";

        public bool DeleteConfirmed => deleteConfirmed;
        public string PlaylistName { set => playlistName = value; }

        public DialogDeletePlaylist()
        {
            InitializeComponent();
        }


        private void OnClickBtnCancel(object sender, EventArgs e)
        {
            Close();
        }


        private void OnClickBtnOk(object sender, EventArgs e)
        {
            deleteConfirmed = true;
            Close();
        }

        private void OnLoadForm(object sender, EventArgs e)
        {
            lbText.Text = $@"Do you want to delete playlist { TextUtil.GetTextWithLimitedLength(playlistName, 7) } ?";
        }
    }
}
