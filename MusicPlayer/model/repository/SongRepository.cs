using System.Collections.Generic;

namespace MusicPlayer.model.repository
{
    sealed class SongRepository
    {
        // Singleton        
        private static SongRepository instance = null;
        private static readonly object padlock = new object();
        
        private List<Song> allSongs = new List<Song>();
        

        SongRepository()
        {

        }

        
        public static SongRepository Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null) instance = new SongRepository();
                    return instance;
                }
            }
        }
                

        public List<Song> GetAllSongs()
        {
            return allSongs;
        }


    }
}
