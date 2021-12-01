using MusicPlayer.model;
using MusicPlayer.model.repository;
using System.Collections.Generic;

namespace MusicPlayer.viewmodel
{
    class SongListViewModel
    {
        private readonly SongRepository repository = new SongRepository();
        private List<Song> allSongs = new List<Song>();

        public List<Song> getAllSongs()
        {
            allSongs = repository.GetAllSongs();
            return allSongs;
        }
    }
}
