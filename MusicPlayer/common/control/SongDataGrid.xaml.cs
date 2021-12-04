using MusicPlayer.model;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Data;

namespace MusicPlayer.common.control
{
    /// <summary>
    /// Interaction logic for SongDataGrid.xaml
    /// </summary>
    public partial class SongDataGrid : UserControl
    {
        public SongDataGrid()
        {
            InitializeComponent();
        }


        public void SetBindingSource(List<Song> songs)
        {
            dataGrid.ItemsSource = songs;
            name.Binding = new Binding("Name");
            author.Binding = new Binding("Author");
            duration.Binding = new Binding("Duration");
        }
    }
}
