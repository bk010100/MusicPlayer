using MusicPlayer.model;
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
        private readonly SongRepository repository = SongRepository.Instance;
        private List<Song> songList = new List<Song>();
        private Playlist selectedPlaylist;
        private int selectedSongIndex = -1;

        public Playlist SelectedPlaylist { get => selectedPlaylist; set => selectedPlaylist = value; }
        public List<Song> SongList => songList;


        public async Task GetSongList()
        {
            if (selectedPlaylist == null)
                songList = await repository.GetAllSongs();
            else
            {
                MessageBox.Show(selectedPlaylist.Id.ToString());
            }

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
