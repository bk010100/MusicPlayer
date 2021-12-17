using MusicPlayer.model.model;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using System.Windows.Forms;
using System;
using DataGrid = System.Windows.Controls.DataGrid;
using MusicPlayer.viewmodel.util;

namespace MusicPlayer.viewmodel
{
    public class PlayingSongListViewModel
    {
        private int playingSongIndex = 0;
        private readonly List<Song> songList = new List<Song>();
        private readonly Mp3Player player = new Mp3Player();
        private readonly Timer timer = new Timer();
        private int songTimer = 0;
        private bool isRepeatOnce = false;
        private bool isPlaying = true;      // Always play song as soon as the form is displayed        


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
        public bool IsPlaying { get => isPlaying; set => isPlaying = value; }
        public Timer Timer { get => timer; }
        public int SongTimer { get => songTimer; set => songTimer = value; }
        public bool RepeatOnce { get => isRepeatOnce; set => isRepeatOnce = value; }


        public PlayingSongListViewModel()
        {
            timer.Interval = 1000;
            timer.Start();
        }


        public void AddOneSecondOnTimerTick()
        {
            songTimer++;
        }


        public void PlayNextSongAfterFinishedCurrentSong(Action viewChange)
        {
            // Try catch in case song list is empty
            int playingSongDuration = 0;
            try
            {
                playingSongDuration = songList[playingSongIndex].Duration;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Song list is empty.", "Empty song list");
            }

            if (songTimer == playingSongDuration)
            {
                if (isRepeatOnce)
                {
                    songTimer = 0;
                    player.StopSong();
                    PlaySong();
                    viewChange();
                }
                else
                {
                    PlayNextSong();
                    viewChange();
                }
            }
        }


        public DataGridRow GetDataGridSelectedRow(object sender)
        {
            if (sender != null)
            {
                DataGrid dataGrid = sender as DataGrid;
                bool isOnlyOneItemSelected = dataGrid.SelectedItem != null && dataGrid.SelectedItems.Count == 1;
                if (isOnlyOneItemSelected)
                {
                    return dataGrid.ItemContainerGenerator.ContainerFromItem(dataGrid.SelectedItem) as DataGridRow;
                }
            }

            return null;
        }    
        

        public void DeleteSong(Song song)
        {
            bool isDeletedSongOnTopOfPlayingSong = songList.IndexOf(song) < playingSongIndex;
            if (isDeletedSongOnTopOfPlayingSong) playingSongIndex--;
            songList.Remove(song);
        }


        #region Functions for Player      

        public void SetPlayerSongUrl()
        {
            player.SongUrl = songList[playingSongIndex].FileName;
        }


        public bool CheckIfSongFileIsNotExist()
        {
            string songFileName = songList[playingSongIndex].FileName;
            string songFilePath = Mp3Player.GetSongLocation(songFileName);

            if (File.Exists(songFilePath)) return true;
            else return false;
        }


        public string GetPlayerSongUrl()
        {
            return player.SongUrl;
        }


        public void PlaySong()
        {
            timer.Start();
            player.PlaySong();
        }


        public void PauseSong() 
        {
            timer.Stop();
            player.PauseSong();
        }


        public void ClosePlayer()
        {
            player.ClosePlayer();
            timer.Dispose();
        }


        public void PlayNextSong()
        {
            if (playingSongIndex == songList.Count - 1) playingSongIndex = 0;
            else playingSongIndex++;
            SetPlayerSongUrl();
            PlaySong();
            timer.Start();
            songTimer = 0;
        }


        public void PlayPreviousSong()
        {
            if (playingSongIndex == 0) playingSongIndex = songList.Count - 1;
            else playingSongIndex--;
            SetPlayerSongUrl();
            PlaySong();
            timer.Start();
            songTimer = 0;
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
