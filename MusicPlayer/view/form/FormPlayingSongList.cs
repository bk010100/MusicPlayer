using System.Windows.Forms;
using MusicPlayer.viewmodel;
using MusicPlayer.common.util;
using Binding = System.Windows.Data.Binding;
using MusicPlayer.model.model;

namespace MusicPlayer.view.form
{
    public partial class FormPlayingSongList : Form
    {
        private PlayingSongListViewModel viewModel;
        private bool isPlaying = true;      // Always play song as soon as the form is displayed        
        
        public PlayingSongListViewModel ViewModel { set => viewModel = value; }


        public FormPlayingSongList()
        {
            InitializeComponent();
        }


        private void OnLoadForm(object sender, System.EventArgs e)
        { 
            // UI setup
            pnTitlebar.SetDraggable();
            SetTitleToPlayingSongName();

            // Display datagrid
            SetDataBindingForDataGrid();
            ResizeTextAndColumnInDataGrid();

            // Play song
            viewModel.GetPlayingSongUrl();
            viewModel.PlaySong();
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


        private void SetTitleToPlayingSongName()
        {
            Song playingSong = viewModel.SongList[viewModel.PlayingSongIndex];
            string text = "Now playing: " + playingSong.Name;
            lbTitle.Text = TextUtil.GetTextWithLimitedLength(text, 60);
        }


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
            SetTitleToPlayingSongName();
        }


        private void OnClickBtnPrevious(object sender, System.EventArgs e)
        {
            viewModel.PlayPreviousSong();
            SetTitleToPlayingSongName();
        }


        private void OnClickBtnPlay(object sender, System.EventArgs e)
        {
            if (isPlaying)
            {
                btnPlay.BackgroundImage = Properties.Resources.pause_64;
                viewModel.PauseSong();
                isPlaying = false;
            }
            else
            {
                btnPlay.BackgroundImage = Properties.Resources.play_64;
                viewModel.PlaySong();
                isPlaying = true;
            }
        }
    }
}
