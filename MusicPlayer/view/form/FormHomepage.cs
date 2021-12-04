using MusicPlayer.view.form;
using System;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class HomepageForm : Form
    {

        // Subforms
        private readonly FormPlaylistList formPlaylistList = new FormPlaylistList
        {
            TopLevel = false
        };
        private readonly FormSongList formSongList = new FormSongList
        {
            TopLevel = false
        };


        [Obsolete]
        public HomepageForm()
        {
            InitializeComponent();
        }


        private void OnLoad(object sender, EventArgs e)
        {

        }


        private void OnClickBtnCloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void OnClickBtnMinimizeApp(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void OnClickBtnSongs(object sender, EventArgs e)
        {
            formSongList.Parent = panelChildForm;
            formSongList.Show();
        }


        private void OnClickBtnPlaylists(object sender, EventArgs e)
        {
            formPlaylistList.Parent = panelChildForm;
            formPlaylistList.Show();
        }


        private void OnClickBtnSettings(object sender, EventArgs e)
        {

        }


        private void OnClickBtnHomepage(object sender, EventArgs e)
        {

        }

        private void onClickBtnHomepage(object sender, EventArgs e)
        {

        }

        private void onClickBtnSettings(object sender, EventArgs e)
        {

        }

        private void onClickBtnPlaylists(object sender, EventArgs e)
        {

        }

        private void onClickBtnSongs(object sender, EventArgs e)
        {

        }
    }
}
