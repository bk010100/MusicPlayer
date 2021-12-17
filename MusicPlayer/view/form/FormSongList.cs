using MusicPlayer.common.dialog;
using MusicPlayer.model.model;
using MusicPlayer.viewmodel;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using Application = System.Windows.Forms.Application;
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
            lbPlaylistName.Text = !viewModel.CheckIfThisFormWasOpenFromPlaylist() ? "All songs" : viewModel.SelectedPlaylist.Name;
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
            dgSongList.dataGrid.MouseDoubleClick += PlayPlaylistOnDoubleClick;
        }


        private void PlayPlaylistOnDoubleClick(object sender, MouseButtonEventArgs e)
        {
            viewModel.GetSelectedSongIndex(sender);
            OpenPlayingSongsForm();
        }


        private void OpenPlayingSongsForm()
        {
            if (Application.OpenForms["FormPlayingSongList"] != null)
            {
                Application.OpenForms["FormPlayingSongList"].Dispose();
            }

            FormPlayingSongList playingSongsForm = new FormPlayingSongList()
            {
                ViewModel = new PlayingSongListViewModel
                {
                    PlayingSongIndex = viewModel.SelectSongIndex,
                    SongList = viewModel.SongList
                }
            };
            playingSongsForm.Show();
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


        private bool CheckIfItemIsSelected()
        {
            return dgSongList.dataGrid.SelectedItem != null;
        }


        private void OpenEditSongDialogOnClickMenuItem(object sender, RoutedEventArgs e)
        {
            if (CheckIfItemIsSelected())
            {
                Song selectedSong = dgSongList.dataGrid.SelectedItem as Song;
                DialogEditSong dialogEditSong = new DialogEditSong
                {
                    SongName = selectedSong.Name,
                    SongArtist = selectedSong.Artist
                };
                dialogEditSong.ShowDialog();

                if (dialogEditSong.SongInfo != null)
                {
                    viewModel.EditSongToDb(selectedSong,
                                           dialogEditSong.SongName,
                                           dialogEditSong.SongArtist);
                    dgSongList.dataGrid.Items.Refresh();
                }
                
            }
            
        }


        private void OpenAddSongToPlaylistDialogOnClickMenuItem(object sender, RoutedEventArgs e)
        {
            if (CheckIfItemIsSelected())
            {
                Song selectedSong = dgSongList.dataGrid.SelectedItem as Song;
                DialogChoosePlaylist dialogChoosePlaylist = new DialogChoosePlaylist();
                dialogChoosePlaylist.ShowDialog();

                if (dialogChoosePlaylist.Playlist != null)
                {
                    viewModel.AddSongToPlaylistInDb(selectedSong.Id, dialogChoosePlaylist.Playlist.Id);
                }
            }
        }


        private void OpenDeleteSongDialogOnClickMenuItem(object sender, RoutedEventArgs e)
        {
            if (CheckIfItemIsSelected())
            {
                DialogDeleteSong dialogDeleteSong = new DialogDeleteSong();
                if (viewModel.SelectedPlaylist != null)
                {
                    dialogDeleteSong.PlaylistId = viewModel.SelectedPlaylist.Id;
                }
                dialogDeleteSong.ShowDialog();

                if (dialogDeleteSong.DeleteConfirm)
                {
                    Song selectedSong = dgSongList.dataGrid.SelectedItem as Song;
                    viewModel.DeleteSongFromDb(selectedSong);
                    dgSongList.dataGrid.Items.Refresh();
                }
            }
        }


        private void AddSongToQueue(object sender, RoutedEventArgs e)
        {

        }


        private void PlayPlaylistOnClickMenuItem(object sender, RoutedEventArgs e)
        {
            if (CheckIfItemIsSelected())
            {
                Song selectedSong = dgSongList.dataGrid.SelectedItem as Song;
                viewModel.SelectSongIndex = viewModel.SongList.IndexOf(selectedSong);
                OpenPlayingSongsForm();
            }
        }


        private void OnClickBtnAddSong(object sender, EventArgs e)
        {
            DialogAddSong dialogAddSong = new DialogAddSong();
            dialogAddSong.ShowDialog();

            if (dialogAddSong.NewSong != null)
            {
                viewModel.MoveSongToMainDir(dialogAddSong.FilePath);
                viewModel.AddSongToDb(dialogAddSong.NewSong);
                dgSongList.dataGrid.Items.Refresh();
            }
        }


        #endregion


    }
}
