using MusicPlayer.common.dialog;
using MusicPlayer.model.model;
using MusicPlayer.viewmodel;
using System;
using System.Collections.Generic;
using System.Windows;
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
            ResizeDataGrid();

            SetTextForPlaylistProfile();
            SetOnDoubleMouseClickOnDataRow();

            SetMenuItemClickEvent();
        }


        private void SetTextForPlaylistProfile()
        {
            lbPlaylistName.Text = viewModel.SelectedPlaylist == null ? "All songs" : viewModel.SelectedPlaylist.Name;
            lbSongCount.Text = "Number of songs: " + viewModel.SongList.Count;
        }


        private void SetDataBindingForDataGrid(List<Song> songList)
        {
            dgSongList.dataGrid.ItemsSource = songList;
            dgSongList.name.Binding = new Binding("Name");
            dgSongList.artits.Binding = new Binding("Artist");
            dgSongList.length.Binding = new Binding("Length");
        }


        private void ResizeDataGrid()
        {
            int width = 450;
            dgSongList.name.MinWidth = width;
            dgSongList.name.MaxWidth = width;
            dgSongList.artits.MinWidth = width;
            dgSongList.artits.MaxWidth = width;
        }


        private void SetOnDoubleMouseClickOnDataRow()
        {
            dgSongList.dataGrid.MouseDoubleClick += viewModel.PlayPlaylistOnDoubleClick;
        }


        #region Button and menu items events


        private void SetMenuItemClickEvent()
        {
            dgSongList.play.Click += PlayPlaylistOnClickMenuItem;
            dgSongList.edit.Click += OpenEditSongDialogOnClickMenuItem;
            dgSongList.playlist.Click += OpenAddSongToPlaylistDialogOnClickMenuItem;
            dgSongList.queue.Click += AddSongToQueue;
            dgSongList.queue.Visibility = Visibility.Collapsed;
            dgSongList.delete.Click += OpenDeleteSongDialogOnClickMenuItem;
        }


        private void OpenEditSongDialogOnClickMenuItem(object sender, RoutedEventArgs e)
        {
            if (dgSongList.dataGrid.SelectedItem != null)
            {
                Song selectedSong = dgSongList.dataGrid.SelectedItem as Song;
                viewModel.EditSongOnDialogResult(selectedSong, () =>
                {
                    dgSongList.dataGrid.Items.Refresh();
                });
            }
            
        }


        private void OpenDeleteSongDialogOnClickMenuItem(object sender, RoutedEventArgs e)
        {
            if (dgSongList.dataGrid.SelectedItem != null)
            {
                Song selectedSong = dgSongList.dataGrid.SelectedItem as Song;
                viewModel.DeleteSongOnDialogResult(selectedSong, () =>
                {
                    dgSongList.dataGrid.Items.Refresh();
                });
            }
        }


        private void OpenAddSongToPlaylistDialogOnClickMenuItem(object sender, RoutedEventArgs e)
        {
            if (dgSongList.dataGrid.SelectedItem != null)
            {
                Song selectedSong = dgSongList.dataGrid.SelectedItem as Song;
                viewModel.AddSongToPlaylistOnDialogResult(selectedSong);
            }
        }


        private void AddSongToQueue(object sender, RoutedEventArgs e)
        {

        }


        private void PlayPlaylistOnClickMenuItem(object sender, RoutedEventArgs e)
        {
            if (dgSongList.dataGrid.SelectedItem != null)
            {
                Song selectedSong = dgSongList.dataGrid.SelectedItem as Song;
                viewModel.PlayPlaylistOnClickMenuItem(selectedSong);
            }
        }


        private void OnClickBtnAddSong(object sender, EventArgs e)
        {
            viewModel.AddSongOnDialogResult(() =>
            {
                dgSongList.dataGrid.Items.Refresh();
            });
        }


        #endregion


    }
}
