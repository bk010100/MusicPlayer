using System;
using System.Windows.Forms;

namespace MusicPlayer.common.dialog
{
    public partial class DialogDeleteSong : Form
    {
        private bool deleteConfirm = false;
        private int playlistId = -1;


        public bool DeleteConfirm => deleteConfirm;
        public int PlaylistId { set => playlistId = value; }


        public DialogDeleteSong()
        {
            InitializeComponent();
        }

        private void OnDialogLoad(object sender, EventArgs e)
        {
            if (playlistId != -1) lbNote.Hide();
        }


        private void OnClickBtnOk(object sender, EventArgs e)
        {
            deleteConfirm = true;
            Close();
        }


        private void OnClickBtnClose(object sender, EventArgs e)
        {
            Close();
        }
    }
}
