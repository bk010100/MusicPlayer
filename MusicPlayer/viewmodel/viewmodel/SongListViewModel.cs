using MusicPlayer.common.dialog;
using MusicPlayer.model;
using MusicPlayer.model.model;
using MusicPlayer.model.repository;
using MusicPlayer.view.form;
using MusicPlayer.viewmodel.util;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using DataGrid = System.Windows.Controls.DataGrid;

namespace MusicPlayer.viewmodel
{
    public class SongListViewModel
    {
        private readonly SongRepository repository = SongRepository.Instance;
        private List<Song> songList = new List<Song>();
        private Playlist selectedPlaylist;
        private int selectedSongIndex = -1;

        public Playlist SelectedPlaylist { get => selectedPlaylist; set => selectedPlaylist = value; }
        public List<Song> SongList => songList;


        public async Task GetSongList()
        {
            if (selectedPlaylist == null)
            {
                songList = await repository.GetAllSongs();
            }
            else
            {
                List<Song> songs = await repository.GetAllSongs();
                int playlistId = selectedPlaylist.Id;
                List<int> songIds = await repository.GetSongIdsFromPlaylist(playlistId);
                for (int index = 0; index < songs.Count; index++)
                {
                    int id = songs[index].Id;
                    if (songIds.Contains(id)) songList.Add(songs[index]);
                }
            }

        }


        public void PlayPlaylistOnDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Application.OpenForms["FormPlayingSongList"] != null)
            {
                Application.OpenForms["FormPlayingSongList"].Dispose();                
            }
            GetSelectedSongIndex(sender);
            OpenPlayingSongsForm();
        }


        public void PlayPlaylistOnClickMenuItem(Song song)
        {
            if (Application.OpenForms["FormPlayingSongList"] != null)
            {
                Application.OpenForms["FormPlayingSongList"].Dispose();
            }
            selectedSongIndex = songList.IndexOf(song);
            OpenPlayingSongsForm();
        }


        private void GetSelectedSongIndex(object sender)
        {
            if (sender != null)
            {
                if (sender is DataGrid dataGrid && dataGrid.SelectedItem != null && dataGrid.SelectedItems.Count == 1)
                {
                    DataGridRow row = dataGrid.ItemContainerGenerator.ContainerFromItem(dataGrid.SelectedItem) as DataGridRow;
                    selectedSongIndex = row.GetIndex();
                }
            }
        }


        private void OpenPlayingSongsForm()
        {
            FormPlayingSongList playingSongsForm = new FormPlayingSongList()
            {
                ViewModel = new PlayingSongListViewModel
                {
                    PlayingSongIndex = selectedSongIndex,
                    SongList = songList
                }
            };

            playingSongsForm.Show();
        }


        #region CRUD

        private void AddSongToDb(Song song)
        {
            if (repository.AddNewSong(song))
            {
                song.Id = repository.GetSongId(song.Name, song.Artist);
                songList.Add(song);
                MessageBox.Show("Add song succressfully.", "Succress!");
            }
            else
            {
                MessageBox.Show("Please recheck your database connection.", "Add song failed!");
            }
        }


        private void MoveSongToMainDir(string filePath)
        {
            if (!FileUtil.CheckIfFileExistInMainDir(filePath))
            {
                FileUtil.CopyPasteFileToMainDir(filePath);
            }
        }


        private void EditSongToDb(Song song, string name, string artist)
        {
            if (repository.UpdateSong(song.Id, name, artist))
            {
                int index = songList.IndexOf(song);
                songList[index].Name = name;
                songList[index].Artist = artist;
                MessageBox.Show("update song successfully.", "Successs!");
            }
            else
            {
                MessageBox.Show("Please recheck your database connection.", "Update failed!");
            }    
        }


        private void DeleteSongFromDb(Song song)
        {
            int id = song.Id;
            if (selectedPlaylist == null)
            {
                if (repository.DeleteSong(id) && repository.DeleteSongIdFromPlaylist(id))
                {
                    songList.Remove(song);
                    MessageBox.Show("Delete song successfully!", "Success!");
                }
                else
                {
                    MessageBox.Show("Please recheck your database connection.", "Delete failed!");
                }
            }
            else
            {
                if (repository.DeleteSong(id))
                {
                    songList.Remove(song);
                    MessageBox.Show("Delete song successfully!", "Success!");
                }
                else
                {
                    MessageBox.Show("Please recheck your database connection.", "Delete failed!");
                }
            }
        }


        private void AddSongToPlaylistInDb(int songId, int playlistId)
        {
            if (repository.AddSongToPlaylist(songId, playlistId))
            {
                MessageBox.Show("Add song to playlist successfully!", "Success!");
            }
            else
            {
                MessageBox.Show("Please recheck your database connection.", "Failed!");
            }
        }


        #endregion


        #region Dialog events

        public void AddSongOnDialogResult(Action viewChange)
        {
            DialogAddSong dialogAddSong = new DialogAddSong();
            dialogAddSong.ShowDialog();
            if (dialogAddSong.NewSong != null)
            {
                MoveSongToMainDir(dialogAddSong.FilePath);
                AddSongToDb(dialogAddSong.NewSong);
                viewChange();
            }
        }


        public void EditSongOnDialogResult(Song song, Action viewChange)
        {
            DialogEditSong dialogEditSong = new DialogEditSong
            {
                SongName = song.Name,
                SongArtist = song.Artist
            };
            dialogEditSong.ShowDialog();

            if (dialogEditSong.SongInfo != null)
            {
                EditSongToDb(song, dialogEditSong.SongName, dialogEditSong.SongArtist);
                viewChange();
            }                
        }


        public void DeleteSongOnDialogResult(Song song, Action viewChange)
        {
            DialogDeleteSong dialogDeleteSong = new DialogDeleteSong();
            if (selectedPlaylist != null) dialogDeleteSong.PlaylistId = selectedPlaylist.Id;
            dialogDeleteSong.ShowDialog();
            if (dialogDeleteSong.DeleteConfirm)
            {
                DeleteSongFromDb(song);
                viewChange();
            }
        }


        public void AddSongToPlaylistOnDialogResult(Song song)
        {
            DialogChoosePlaylist dialogChoosePlaylist = new DialogChoosePlaylist();
            dialogChoosePlaylist.ShowDialog();
            if (dialogChoosePlaylist.Playlist != null)
            {
                AddSongToPlaylistInDb(song.Id, dialogChoosePlaylist.Playlist.Id);
            }
        }


        #endregion


    }
}
