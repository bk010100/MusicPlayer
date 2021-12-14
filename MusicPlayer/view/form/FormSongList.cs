using MusicPlayer.model.model;
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


        public SongListViewModel ViewModel => viewModel;


        public FormSongList()
        {
            InitializeComponent();
        }


        private async void OnLoadForm(object sender, EventArgs e)
        {
            await viewModel.GetSongList();

            SetDataBindingForDataGrid(viewModel.SongList);
            SetOnDoubleMouseClickOnDataRow();
            SetTextForPlaylistProfile();
        }


        private void SetTextForPlaylistProfile()
        {
            if (viewModel.SelectedPlaylist == null) lbPlaylistName.Text = "All songs";
            else lbPlaylistName.Text = viewModel.SelectedPlaylist.Name;
            lbSongCount.Text = "Number of songs: " + viewModel.SongList.Count;
        }


        private void SetDataBindingForDataGrid(List<Song> songList)
        {
            dgSongList.dataGrid.ItemsSource = songList;
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
