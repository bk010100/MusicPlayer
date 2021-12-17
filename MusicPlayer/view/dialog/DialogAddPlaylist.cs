using System.Windows.Forms;

namespace MusicPlayer.common.dialog
{
    public partial class DialogAddPlaylist : Form
    {
        private string playlistName = "";


        public string PlaylistName => playlistName;


        public DialogAddPlaylist()
        {
            InitializeComponent();
        }


        private void OnLoadDialog(object sender, System.EventArgs e)
        {

        }



        private void OnClickBtnOk(object sender, System.EventArgs e)
        {
            if (tbName.Text.Length < 2) MessageBox.Show("Playlist name must have at least 2 characters.", "Playlist name is too short!");
            else
            {
                playlistName = tbName.Text;
                Close();
            }
        }


        private void OnClickBtnCancel(object sender, System.EventArgs e)
        {
            Close();
        }


    }
}
