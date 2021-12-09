using MusicPlayer.model.model;
using MusicPlayer.model.repository;
using MusicPlayer.view.form;
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
        private readonly SongRepository repository = new SongRepository();
        private List<Song> songList = new List<Song>();
        private int selectedSongIndex, selectedPlaylistId = 0;

        public int SelectedPlaylistId { set => selectedPlaylistId = value; }

        public async Task<List<Song>> GetSongList()
        {
            if (selectedPlaylistId == 0)
                songList = await repository.GetAllSongs();
            else
            {
                
            }

            return songList;
        }


        public void OnDoubleMouseClickOnDataRow(object sender, MouseButtonEventArgs e)
        {
            if (Application.OpenForms["FormPlayingSongs"] == null)
            {
                GetSelectedSongIndex(sender);
                OpenPlayingSongsForm();
            }
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

    }
}
