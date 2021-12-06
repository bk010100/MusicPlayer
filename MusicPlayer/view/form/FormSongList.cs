using MusicPlayer.model;
using MusicPlayer.viewmodel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Binding = System.Windows.Data.Binding;

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


        private void OnLoadForm(object sender, EventArgs e)
        {
            viewModel.DataGrid = dgSongList;
            songList = viewModel.GetAllSongs();

            SetDataBindingForDataGrid(songList);
            SetOnDoubleMouseClickOnDataRow();
            SetTextForPlaylistProfile();
        }


        private void SetTextForPlaylistProfile()
        {
            lbPlaylistName.Text = "All songs";
            lbSongCount.Text = "Number of songs: " + songList.Count;
        }


        private void SetDataBindingForDataGrid(List<Song> songs)
        {
            dgSongList.dataGrid.ItemsSource = songs;
            dgSongList.name.Binding = new Binding("Name");
            dgSongList.artits.Binding = new Binding("Artist");
            dgSongList.length.Binding = new Binding("Length");
        }


        private void SetOnDoubleMouseClickOnDataRow()
        {
            dgSongList.dataGrid.MouseDoubleClick += viewModel.OnDoubleMouseClickOnDataRow;
        }

    }
}
