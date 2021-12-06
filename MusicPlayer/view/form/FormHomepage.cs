using MusicPlayer.view.form;
using System;
using System.Drawing;
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

        // Variables for draggable title bar
        private bool isTitleDragging = false;
        private Point titleStartPoint = new Point(0, 0);


        [Obsolete]
        public HomepageForm() => InitializeComponent();


        private void OnLoadForm(object sender, EventArgs e)
        {
            SetTitleBarToDraggable();
        }


        private void SetTitleBarToDraggable()
        {
            panelTitlebar.MouseDown += OnMouseDownTitleBar;
            panelTitlebar.MouseUp += OnMouseUpTitleBar;
            panelTitlebar.MouseMove += OnMouseMoveTitleBar;
        }


        private void OnMouseMoveTitleBar(object sender, MouseEventArgs e)
        {
            if(isTitleDragging)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = PointToScreen(p1);
                Point p3 = new Point(p2.X - titleStartPoint.X, p2.Y - titleStartPoint.Y);
                Location = p3;
            }
        }


        private void OnMouseUpTitleBar(object sender, MouseEventArgs e)
        {
            isTitleDragging = false;
        }


        private void OnMouseDownTitleBar(object sender, MouseEventArgs e)
        {
            titleStartPoint = e.Location;
            isTitleDragging = true;
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

    }
}
