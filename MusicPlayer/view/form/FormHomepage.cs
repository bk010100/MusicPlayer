using MusicPlayer.view.form;
using System;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class FormHomepage : Form
    {
        // Subforms
        private FormPlaylistList formPlaylistList = new FormPlaylistList();
        private FormSongList formSongList = new FormSongList();


        [Obsolete]
        public FormHomepage() => InitializeComponent();


        private void OnLoadForm(object sender, EventArgs e)
        {
            pnTitlebar.SetDraggable();
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
            formSongList = new FormSongList
            {
                TopLevel = false,
                Parent = panelChildForm
            };
            formSongList.Show();

            // Close other subform
            formPlaylistList.Close();
        }


        private void OnClickBtnPlaylists(object sender, EventArgs e)
        {
            formPlaylistList = new FormPlaylistList
            {
                TopLevel = false,
                Parent = panelChildForm
            };
            formPlaylistList.Show();

            // Close other subform
            formSongList.Close();
        }


        private void OnClickBtnAbout(object sender, EventArgs e)
        {
            // Close all subforms
            formPlaylistList.Close();
            formSongList.Close();
        }


    }
}
