using MusicPlayer.common.control;
using MusicPlayer.viewmodel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MusicPlayer.view.form
{
    public partial class FormPlaylistList : Form
    {
        private readonly PlaylistListViewModel viewModel = new PlaylistListViewModel();

        public FormPlaylistList()
        {
            InitializeComponent();
        }


        private void OnLoad(object sender, EventArgs e)
        {
            List<string> list = viewModel.GetAllPlaylistNames();
            LoadAllPlaylists(list);
        }


        private void LoadAllPlaylists(List<string> list)
        {
            int xSpace = 260, ySpace = 260;
            int x = btnAddPlaylist.Location.X;
            int y = btnAddPlaylist.Location.Y;

            for (int count = 0; count < list.Count; count++)
            {
                // First button is "Add new playlist" button
                if (count == 0)
                    x += xSpace;

                AddNewBtnPlaylist(
                    playlistName: list[count],
                    xPosition: x,
                    yPosition: y);

                // When reach the end line
                if (count == 2 || ((count - 2) / 4 == 0 && count > 4))
                {
                    x = btnAddPlaylist.Location.X;
                    y += ySpace;
                }
                else
                {
                    x += xSpace;
                }
            }
        }


        private void AddNewBtnPlaylist(string playlistName, int xPosition, int yPosition)
        {
            ButtonPlaylist btnPlaylist = new ButtonPlaylist
            {
                Location = new Point(xPosition, yPosition)
            };
            btnPlaylist.SetPlaylistName(playlistName);
            panelBackground.Controls.Add(btnPlaylist);
        }
    }
}
