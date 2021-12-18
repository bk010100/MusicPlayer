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


        private bool CheckIfPlaylistAlreadyExisted(string name)
        {
            int index = -1;
            index = playlistList.FindIndex(playlist => playlist.Name == name);
            if (index == -1) return false;
            else return true;
        }


        public bool AddNewPlaylistToDbAndReturnResult(string name)
        {
            if (CheckIfPlaylistAlreadyExisted(name))
            {
                MessageBox.Show("A playlist with this name has already existed. Please chooose another name.", "Duplicate playlist!");
                return false;
            }
            else
            {
                bool isPlaylistAdded = repository.AddNewPlaylist(name);
                if (isPlaylistAdded)
                {
                    Playlist newPlaylist = new Playlist
                    {
                        Id = repository.GetPlaylistIdByName(name),
                        Name = name
                    };
                    playlistList.Add(newPlaylist);
                    MessageBox.Show("Add playlist successfully.", "Yeahhhh!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Something went wrong :(", "Add playlist failed!");
                    return false;
                }
            }
        }


        public bool UpdatePlaylistNameToDbAndReturnResult(int index, string name)
        {
            if (CheckIfPlaylistAlreadyExisted(name))
            {
                MessageBox.Show("A playlist with this name has already existed. Please chooose another name.", "Duplicate playlist!");
                return false;
            }
            else
            {
                bool isPlaylistUpdated = repository.UpdatePlaylistNameById(playlistList[index].Id, name);
                if (isPlaylistUpdated)
                {
                    playlistList[index].Name = name;
                    MessageBox.Show("Rename playlist successfully.", "Yeahhhh!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Something went wrong :(", "Update playlist failed!");
                    return false;
                }
            }
        }


        public void DeletePlaylistFromDb(int index)
        {
            int id = playlistList[index].Id;
            bool isPlaylistDeleted = repository.DeletePlaylistById(id);
            if (isPlaylistDeleted)
            {
                MessageBox.Show("Delete playlist successfully.", "Yeahhhh!");
                playlistList.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Something went wrong :(", "Delete playlist failed!");
            }
        }

    }
}
