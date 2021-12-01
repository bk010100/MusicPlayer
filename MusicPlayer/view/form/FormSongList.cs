using MusicPlayer.viewmodel;
using System;
using System.Windows.Forms;

namespace MusicPlayer.view.ui
{
    public partial class FormSongList : Form
    {
        private readonly SongListViewModel viewModel = new SongListViewModel();

        public FormSongList()
        {
            InitializeComponent();
        }


        private void OnLoad(object sender, EventArgs e)
        {
            _ = viewModel.getAllSongs();
        }

    }
}
