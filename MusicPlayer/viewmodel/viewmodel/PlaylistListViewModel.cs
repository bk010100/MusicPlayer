using MusicPlayer.model;
using MusicPlayer.model.repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.viewmodel
{
    public class PlaylistListViewModel
    {
        private List<Playlist> playlistList = new List<Playlist>();
        private readonly PlaylistRepository repository = PlaylistRepository.Instance;


        public List<Playlist> PlaylistList
        {
            get => playlistList;
            set
            {
                playlistList.Clear();
                playlistList.AddRange(value);
            }
        }


        public async Task<List<Playlist>> GetAllPlaylistFromDb()
        {
            playlistList = await repository.GetAllPlaylists();
            return playlistList;
        }


        public void AddNewPlaylistToDb(string name)
        {
            if (repository.AddNewPlaylist(name))
            {
                Playlist newPlaylist = new Playlist
                {
                    Id = repository.GetPlaylistIdByName(name),
                    Name = name
                };
                playlistList.Add(newPlaylist);
            }
            else
            {
                MessageBox.Show("Please recheck your connection to the database.", "Add playlist failed!");
            }
        }


        public void UpdatePlaylistNameToDb(int index, string name)
        {
            playlistList[index].Name = name;
            if (repository.UpdatePlaylistNameById(playlistList[index].Id, name))
            {
                MessageBox.Show("Rename playlist successfully.", "Update successfully!");
            }
            else
            {
                MessageBox.Show("Please recheck your connection to the database.", "Update failed!");
            }
        }


        public void DeletePlaylistFromDb(int index)
        {
            int id = playlistList[index].Id;
            if (repository.DeletePlaylistById(id) && repository.DeleteSongsFromDeletedPlaylist(id))
            {
                MessageBox.Show("Delete playlist successfully.", "Delete successfully!");
                playlistList.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Please recheck your connection to the database.", "Delete failed!");
            }
        }

    }
}
