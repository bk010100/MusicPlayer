using MusicPlayer.common.control;
using MusicPlayer.model;
using MusicPlayer.model.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MusicPlayer.viewmodel
{
    public class SongListViewModel
    {
        private readonly SongRepository repository = new SongRepository();
        private List<Song> songList = new List<Song>();
        private SongDataGrid dataGrid;
        private int selectedSongIndex;

        public SongDataGrid DataGrid { set => dataGrid = value; }


        public List<Song> GetAllSongs()
        {
            songList = repository.GetAllSongs();
            return songList;
        }


        public void OnDoubleMouseClickOnDataRow(object sender, MouseButtonEventArgs e)
        {
            if (sender != null)
            {
                if (sender is DataGrid dataGrid && dataGrid.SelectedItem != null && dataGrid.SelectedItems.Count == 1)
                {
                    DataGridRow row = dataGrid.ItemContainerGenerator.ContainerFromItem(dataGrid.SelectedItem) as DataGridRow;
                    selectedSongIndex = row.GetIndex();
                }
            }
        }

    }
}
