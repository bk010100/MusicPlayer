using MusicPlayer.common.control;
using MusicPlayer.common.dialog;
using MusicPlayer.model;
using MusicPlayer.viewmodel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.view.form
{
    public partial class FormPlaylistList : Form
    {
        private readonly PlaylistListViewModel viewModel = new PlaylistListViewModel();
        private readonly List<ButtonPlaylist> btnPlaylistList = new List<ButtonPlaylist>();


        public FormPlaylistList()
        {
            InitializeComponent();
        }


        private async void OnLoadForm(object sender, EventArgs e)
        {
            await ShowAllPlaylists();
            OnMenuItemClick();
            btnAddPlaylist.Click += OpenAddPlaylistDialog;
        }


        private int GetSeletedButtonIndex(ToolStripItem item)
        {
            ContextMenuStrip menu = item.Owner as ContextMenuStrip;
            ButtonPlaylist button = menu.SourceControl as ButtonPlaylist;
            return btnPlaylistList.IndexOf(button); 
        }


        private void ChangeButtonPlaylistName(ButtonPlaylist buttonPlaylist, string name)
        {
            buttonPlaylist.PlaylistName = name;
        }


        private async Task ShowAllPlaylists()
        {
            List<Playlist> playlistList = await viewModel.GetAllPlaylistFromDb();
            

            for (int index = 0; index < playlistList.Count; index++)
            {
                AddNewBtnPlaylist(playlistList[index]);
            }

        }


        private void AddNewBtnPlaylist(Playlist playlist)
        {
            ButtonPlaylist btnPlaylist = new ButtonPlaylist
            {
                PlaylistName = playlist.Name
            };
            btnPlaylist.SetPlaylistName();
            btnPlaylist.ContextMenuStrip = cmsMenu;
            btnPlaylist.Click += OpenPlaylistOnClick;

            btnPlaylistList.Add(btnPlaylist);
            flPanel.Controls.Add(btnPlaylist);            
        }


        private void OpenPlaylistOnClick(object sender, EventArgs e)
        {
            if (sender != null && sender is ButtonPlaylist button)
            {
                int index = btnPlaylistList.IndexOf(button);
                OpenPlaylist(index);
            }
        }


        private void OpenPlaylist(int index)
        {
            Playlist selectedPlaylist = viewModel.PlaylistList[index];

            // Setup form song list
            FormHomepage formHomepage = Application.OpenForms["FormHomePage"] as FormHomepage;
            FormSongList formSongList = new FormSongList()
            {
                TopLevel = false,
                Parent = formHomepage.PnBackgroud
            };
            formSongList.ViewModel.SelectedPlaylist = selectedPlaylist;

            // Switch to form song list
            formSongList.Show();
            Dispose();
        }


        #region Menu item events

        private void OnMenuItemClick()
        {
            itemOpen.Click += OpenPlaylistOnClickOpenMenu;
            itemRename.Click += OpenRenamePlaylistDialog;
            itemDelete.Click += OpenDeletePlaylistDialog;
        }


        private void OpenAddPlaylistDialog(object sender, EventArgs e)
        {
            DialogAddPlaylist addPlaylistDialog = new DialogAddPlaylist();
            addPlaylistDialog.ShowDialog();

            // Check if user click OK 
            if (addPlaylistDialog.PlaylistName.Length > 0)
            {
                Playlist playlist = new Playlist
                {
                    Name = addPlaylistDialog.PlaylistName
                };
                AddNewBtnPlaylist(playlist);
                viewModel.AddNewPlaylistToDb(playlist.Name);
            }
        }


        private void OpenPlaylistOnClickOpenMenu(object sender, EventArgs e)
        {
            if (sender != null && sender is ToolStripItem item)
            {
                int index = GetSeletedButtonIndex(item);
                OpenPlaylist(index);
            }
        }


        private void OpenRenamePlaylistDialog(object sender, EventArgs e)
        {
            if (sender != null && sender is ToolStripItem item)
            {
                int index = GetSeletedButtonIndex(item);
                DialogRenamePlaylist renameDialog = new DialogRenamePlaylist
                {
                    OriginalName = viewModel.PlaylistList[index].Name
                };
                renameDialog.ShowDialog();

                // Check if user click OK
                if (renameDialog.NewName.Length > 0)
                {
                    ButtonPlaylist selectedButton = flPanel.Controls[index + 1] as ButtonPlaylist;
                    ChangeButtonPlaylistName(selectedButton, renameDialog.NewName);
                    viewModel.UpdatePlaylistNameToDb(index, renameDialog.NewName);
                }
            }
        }


        private void OpenDeletePlaylistDialog(object sender, EventArgs e)
        {
            if (sender != null && sender is ToolStripItem item)
            {
                int index = GetSeletedButtonIndex(item);
                DialogDeletePlaylist deletePlaylistDialog = new DialogDeletePlaylist
                {
                    PlaylistName = viewModel.PlaylistList[index].Name
                };
                deletePlaylistDialog.ShowDialog();

                // Check if user click OK
                if (deletePlaylistDialog.DeleteConfirmed)
                {
                    flPanel.Controls[index + 1].Dispose();
                    btnPlaylistList.RemoveAt(index);
                    viewModel.DeletePlaylistFromDb(index);
                }
            }
        }


        #endregion

    }
}
