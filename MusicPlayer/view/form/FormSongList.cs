using MusicPlayer.model;
using MusicPlayer.viewmodel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicPlayer.view.form
{
    public partial class FormSongList : Form
    {
        private readonly SongListViewModel viewModel = new SongListViewModel();
        private List<Song> songList;

        public FormSongList()
        {
            InitializeComponent();
        }


        private void OnLoad(object sender, EventArgs e)
        {
            songList = viewModel.GetAllSongs();
            datagridSongList.SetBindingSource(songList);
        }


    }
}
