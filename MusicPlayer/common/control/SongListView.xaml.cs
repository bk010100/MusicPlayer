using MusicPlayer.model;
using System.Windows.Controls;
using Binding = System.Windows.Data.Binding;

namespace MusicPlayer.common.control
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class SongListView : UserControl
    {
        public SongListView()
        {
            InitializeComponent();
        }


        public void AddSongToListView(Song song)
        {
            _ = listView.Items.Add(song);
        }


        public void SetBindingForColumns(string name, string author, string duration)
        {
            nameColumn.DisplayMemberBinding = new Binding(name);
            authorColumn.DisplayMemberBinding = new Binding(author);
            durationColumn.DisplayMemberBinding = new Binding(duration);
        }
    }
}
