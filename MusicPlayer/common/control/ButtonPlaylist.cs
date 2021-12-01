using MusicPlayer.common.util;
using System;
using System.Windows.Forms;

namespace MusicPlayer.common.control
{
    public partial class ButtonPlaylist : UserControl
    {
        public ButtonPlaylist()
        {
            InitializeComponent();
        }


        private void OnLoad(object sender, EventArgs e)
        {

        }


        public void OnBtnPlaylistClick(object sender, EventArgs e)
        {

        }


        public void SetPlaylistName(string name)
        {
            btn.Text = TextUtil.GetTextWithLimitedLength(text: name, maxLength: 10);
        }

    }
}
