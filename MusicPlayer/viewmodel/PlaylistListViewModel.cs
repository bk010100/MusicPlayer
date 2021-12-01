using System.Collections.Generic;

namespace MusicPlayer.viewmodel
{
    class PlaylistListViewModel
    {
        public List<string> GetAllPlaylistNames()
        {
            List<string> fakePlaylistNames = new List<string>
            {
                "Favourite",
                "Top hits",
                "Favourite",
                "Songs",
                "wuhdoahoduahdodahdiahodhasidahodiaodhsoadhoisahdoia"
            };

            return fakePlaylistNames;
        }
    }
}
