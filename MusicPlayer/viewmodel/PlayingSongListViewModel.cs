using MusicPlayer.model.model;
using System.Collections.Generic;
using MusicPlayer.common.util;
using System.Windows.Forms;

namespace MusicPlayer.viewmodel
{
    public class PlayingSongListViewModel
    {
        private int playingSongIndex = 0;
        private readonly List<Song> songList = new List<Song>();
        private readonly Mp3Player player = new Mp3Player();

        public int PlayingSongIndex { get => playingSongIndex; set => playingSongIndex = value; }
        public List<Song> SongList
        {
            get => songList;
            set
            {
                songList.Clear();
                songList.AddRange(value);
            }
        }


        #region Functions for Player       
        public void GetPlayingSongUrl()
        {
            player.SongUrl = songList[playingSongIndex].FileName;
        }


        public void PlaySong()
        {
            player.ClosePlayer();
            GetPlayingSongUrl();
            player.PlaySong();
        }


        public void PauseSong() 
        {
            player.PauseSong();
        }


        public void ClosePlayer()
        {
            player.ClosePlayer();
        }


        public void PlayNextSong()
        {
            if (playingSongIndex == songList.Count - 1) playingSongIndex = 0;
            else playingSongIndex++;
            PlaySong();
        }


        public void PlayPreviousSong()
        {
            if (playingSongIndex == 0) playingSongIndex = songList.Count - 1;
            else playingSongIndex--;
            PlaySong();
        }


        public void SetVolume(int volume)
        {
            player.SetVolume(volume);
        }


        public bool MuteVolume
        {
            set => player.MuteVolume = value;
        }


        public bool IsVolumeMuted()
        {
            return player.MuteVolume;
        }

        #endregion
    }
}
