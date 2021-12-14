using MusicPlayer.common.util;
using MusicPlayer.model.model;
using MusicPlayer.viewmodel;
using System.Windows.Forms;
using System.Windows.Input;
using Binding = System.Windows.Data.Binding;
using MessageBox = System.Windows.Forms.MessageBox;

namespace MusicPlayer.view.form
{
    public partial class FormPlayingSongList : Form
    {
        private PlayingSongListViewModel viewModel;

        public PlayingSongListViewModel ViewModel { set => viewModel = value; }


        public FormPlayingSongList()
        {
            InitializeComponent();
        }


        private void OnLoadForm(object sender, System.EventArgs e)
        {
            pnTitlebar.SetDraggable();
            SetTitleToPlayingSongName();

            SetDataBindingForDataGrid();
            ResizeTextAndColumnInDataGrid();

            dgSongList.dataGrid.MouseDoubleClick += ChangeSongOnDoubleClick;
            dgSongList.play.Click += OnClickMenuItemPlaySong;
            dgSongList.queue.Visibility = System.Windows.Visibility.Collapsed;
            dgSongList.playlist.Visibility = System.Windows.Visibility.Collapsed;
            dgSongList.delete.Click += OnClickMenuItemDeleteSong;
        }


        private void OnClickMenuItemPlaySong(object sender, System.Windows.RoutedEventArgs e)
        {
            if (dgSongList.dataGrid.SelectedItem != null)
            {
                Song selectedSong = dgSongList.dataGrid.SelectedItem as Song;
                viewModel.PlayingSongIndex = viewModel.SongList.IndexOf(selectedSong);

                PlaySongAndChangeTitle();
                ResetDisplay();
            }
        }


        private void PlaySongOnShownForm(object sender, System.EventArgs e)
        {
            viewModel.SetPlayerSongUrl();
            if (!viewModel.CheckIfSongFileIsNotExist()) DeleteSongIfSongFileIsNotExist();

            PlaySongAndChangeTitle();
            viewModel.Timer.Tick += SetOnTimerTick;
        }


        private void PlayNextSongWhenSongEnds()
        {
            viewModel.PlayNextSongAfterFinishedCurrentSong(ResetDisplay);
        }


        private void PlaySongAndChangeTitle()
        {
            viewModel.SetPlayerSongUrl();
            viewModel.PlaySong();

            viewModel.Timer.Start();
            viewModel.SongTimer = 0;

            SetTextForDisplaySongLength();
            SetTitleToPlayingSongName();
        }


        private void SetOnTimerTick(object sender, System.EventArgs e)
        {
            // Try catch to in case song list is empty
            Song playingSong = new Song();
            try
            {
                playingSong = viewModel.SongList[viewModel.PlayingSongIndex];
            }
            catch (System.ArgumentOutOfRangeException)
            {
                viewModel.ClosePlayer();
                Close();
            }

            // Change slider value
            sliderSongDuration.slider.Maximum = playingSong.Duration;
            sliderSongDuration.slider.Value += 1;

            // Set text song timer label
            int timer = (int)sliderSongDuration.slider.Value;
            int minuteTimer = timer / 60;
            int secondTimer = timer - minuteTimer * 60;
            string secondTimerString = secondTimer > 9 ? secondTimer.ToString() : "0" + secondTimer;
            lbSongTimer.Text = "0" + minuteTimer + ":" + secondTimerString;

            viewModel.AddOneSecondOnTimerTick();
            PlayNextSongWhenSongEnds();
        }


        private void ResetDisplay()
        {
            lbSongTimer.Text = "00:00";
            sliderSongDuration.slider.Value = 0;
            SetTextForDisplaySongLength();
            SetTitleToPlayingSongName();
        }


        private void SetTextForDisplaySongLength()
        {
            Song playingSong = viewModel.SongList[viewModel.PlayingSongIndex];
            lbSongLength.Text = playingSong.Length;
        }


        #region DataGrid events

        private void SetTitleToPlayingSongName()
        {
            Song playingSong = viewModel.SongList[viewModel.PlayingSongIndex];
            string text = "Now playing: " + playingSong.Name;
            lbTitle.Text = TextUtil.GetTextWithLimitedLength(text, 60);
        }


        private void DeleteSongIfSongFileIsNotExist()
        {
            MessageBox.Show("File is not exist: " + viewModel.GetPlayerSongUrl(), "File path invalid!");
            Song song = viewModel.SongList[viewModel.PlayingSongIndex];
            viewModel.DeleteSong(song);
            dgSongList.dataGrid.Items.Refresh();
        }


        private void ChangeSongOnDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                viewModel.PlayingSongIndex = viewModel.GetDataGridSelectedRow(sender).GetIndex();
            PlaySongAndChangeTitle();
            ResetDisplay();
        }


        private void SetDataBindingForDataGrid()
        {
            dgSongList.dataGrid.ItemsSource = viewModel.SongList;
            dgSongList.name.Binding = new Binding("Name");
            dgSongList.artits.Binding = new Binding("Artist");
            dgSongList.length.Binding = new Binding("Length");
        }


        private void ResizeTextAndColumnInDataGrid()
        {
            int textSize = 16, width = 200;
            dgSongList.name.FontSize = textSize;
            dgSongList.artits.FontSize = textSize;
            dgSongList.length.FontSize = textSize;
            dgSongList.name.MinWidth = width;
            dgSongList.artits.MinWidth = width;
            dgSongList.length.MinWidth = 150;
            dgSongList.name.MaxWidth = width;
            dgSongList.artits.MaxWidth = width;
        }


        private void OnClickMenuItemDeleteSong(object sender, System.EventArgs e)
        {
            if (dgSongList.dataGrid.SelectedItem != null)
            {
                Song selectedSong = dgSongList.dataGrid.SelectedItem as Song;
                viewModel.DeleteSong(selectedSong);
                MessageBox.Show(selectedSong.Name + " - " + selectedSong.Artist + " has been removed from this list.", "Delete song successfully!");
                dgSongList.dataGrid.Items.Refresh();
            }
        }


        #endregion


        #region Button click events

        private void OnClickBtnMinimizeWindow(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void OnClickButtonCloseWindow(object sender, System.EventArgs e)
        {
            viewModel.ClosePlayer();
            Close();
        }


        private void OnClickBtnVolume(object sender, System.EventArgs e)
        {
            if (tbVolume.Value != 0)
            {
                if (viewModel.IsVolumeMuted())
                {
                    btnVolume.BackgroundImage = Properties.Resources.volume_64;
                    viewModel.MuteVolume = false;
                }
                else
                {
                    btnVolume.BackgroundImage = Properties.Resources.mute_64;
                    viewModel.MuteVolume = true;
                }
            }
        }


        private void OnValueChangeInTrackbarVolume(object sender, System.EventArgs e)
        {
            int volume = tbVolume.Value * 5;
            viewModel.SetVolume(volume);
            ttNotify.SetToolTip(tbVolume, "Volume: " + volume);

            if (viewModel.IsVolumeMuted())
            {
                btnVolume.BackgroundImage = Properties.Resources.volume_64;
                viewModel.MuteVolume = false;
            }
        }


        private void OnClickBtnNext(object sender, System.EventArgs e)
        {
            viewModel.PlayNextSong();

            if (!viewModel.CheckIfSongFileIsNotExist())
            {
                DeleteSongIfSongFileIsNotExist();
                PlaySongAndChangeTitle();            // After delete current playing song, the next song automatically become the playing song
            }

            ResetDisplay();
        }


        private void OnClickBtnPrevious(object sender, System.EventArgs e)
        {
            viewModel.PlayPreviousSong();

            if (!viewModel.CheckIfSongFileIsNotExist())
            {
                DeleteSongIfSongFileIsNotExist();
                viewModel.PlayPreviousSong();
            }

            ResetDisplay();
        }


        private void OnClickBtnPlay(object sender, System.EventArgs e)
        {
            if (viewModel.IsPlaying)
            {
                btnPlay.BackgroundImage = Properties.Resources.play_64;
                viewModel.PauseSong();
                viewModel.IsPlaying = false;
            }
            else
            {
                //ShowDialogIfSongFileIsNotExist();
                btnPlay.BackgroundImage = Properties.Resources.pause_64;
                viewModel.PlaySong();
                viewModel.IsPlaying = true;
            }
        }


        private void OnClickBtnRepeat(object sender, System.EventArgs e)
        {
            if (viewModel.RepeatOnce)
            {
                btnRepeat.BackgroundImage = Properties.Resources.replay_all_64;
                viewModel.RepeatOnce = false;
            }
            else
            {
                btnRepeat.BackgroundImage = Properties.Resources.replay_one_64;
                viewModel.RepeatOnce = true;
            }

        }

        #endregion

    }
}
