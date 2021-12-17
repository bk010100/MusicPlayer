using MusicPlayer.model;
using MusicPlayer.model.repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicPlayer.common.dialog
{
    public partial class DialogChoosePlaylist : Form
    {
        private List<Playlist> playlistList;
        private Playlist playlist;
        private PlaylistRepository repository = PlaylistRepository.Instance;


        public Playlist Playlist => playlist;


        public DialogChoosePlaylist()
        {
            InitializeComponent();
        }


        private async void OnLoadDialog(object sender, EventArgs e)
        {
            playlistList = await repository.GetAllPlaylists();
            AddAllPlaylistNameToListView();
            lvPlaylists.ItemActivate += GetSelectedItem;
        }


        private void GetSelectedItem(object sender, EventArgs e)
        {
            if (lvPlaylists.SelectedIndices != null)
            {
                int index = lvPlaylists.SelectedIndices[0];
                tbName.Text = playlistList[index].Name;
                playlist = playlistList[index];
            }
        }


        private void AddAllPlaylistNameToListView()
        {
            for (int index = 0; index < playlistList.Count; index++)
            {
                ListViewItem item = new ListViewItem(playlistList[index].Name);
                lvPlaylists.Items.Add(item);
            }
        }


        private void OnClickBtnOk(object sender, EventArgs e)
        {
            Close();
        }


        private void OnClickBtnCancel(object sender, EventArgs e)
        {
            playlist = null;
            Close();
        }
    }
}
