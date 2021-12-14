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


        public Panel PnBackgroud => pnBackground;


        [Obsolete]
        public FormHomepage()
        {
            InitializeComponent();
        }


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
            if (Application.OpenForms["FormSongList"] != null)
            {
                Application.OpenForms["FormSongList"].Dispose();
            }

            formSongList = new FormSongList
            {
                TopLevel = false,
                Parent = pnBackground
            };
            formSongList.Show();

            // Close other subform
            if (Application.OpenForms["FormPlaylistList"] != null)
            {
                formPlaylistList = Application.OpenForms["FormPlaylistList"] as FormPlaylistList;
            }
            
            formPlaylistList.Dispose();
            HideAbout();
        }


        private void OnClickBtnPlaylists(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormPlaylistList"] != null)
            {
                Application.OpenForms["FormPlaylistList"].Dispose();
            }

            formPlaylistList = new FormPlaylistList
            {
                TopLevel = false,
                Parent = pnBackground
            };
            formPlaylistList.Show();

            // Close other subform
            if (Application.OpenForms["FormSongList"] != null)
            {
                formSongList = Application.OpenForms["FormSongList"] as FormSongList;
            }
            formSongList.Dispose();
            HideAbout();
        }


        private void OnClickBtnAbout(object sender, EventArgs e)
        {
            // Close all subforms
            formPlaylistList.Dispose();
            formSongList.Dispose();

            ShowAbout();
        }


        private void ShowAbout()
        {
            btnLogoAbout.Visible = true;
            lbAppName.Visible = true;
            lbVersion.Visible = true;
        }


        private void HideAbout()
        {
            btnLogoAbout.Visible = false;
            lbAppName.Visible = false;
            lbVersion.Visible = false;
        }

    }
}
