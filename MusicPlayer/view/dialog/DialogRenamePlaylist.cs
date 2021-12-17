using System;
using System.Windows.Forms;

namespace MusicPlayer.common.dialog
{
    public partial class DialogRenamePlaylist : Form
    {
        private string originalName = "", newName = "";


        public string OriginalName { set => originalName = value; }
        public string NewName { get => newName; }


        public DialogRenamePlaylist()
        {
            InitializeComponent();
        }


        private void OnLoadForm(object sender, EventArgs e)
        {
            tbOriginalName.Text = originalName;
            tbNewName.Text = originalName;
        }


        private void ReturnNewNameForResult()
        {
            if (tbNewName.Text.Length < 2) MessageBox.Show("Playlist name must have at least 2 characters.", "Playlist name is too short!");
            else
            {
                newName = tbNewName.Text;
                Close();
            }            
        }


        private void OnClickBtnOk(object sender, EventArgs e)
        {
            ReturnNewNameForResult();
        }


        private void OnClickBtnCancel(object sender, EventArgs e)
        {
            Close();
        }

    }
}
