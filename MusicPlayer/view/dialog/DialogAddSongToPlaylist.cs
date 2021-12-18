using MusicPlayer.model.model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicPlayer.view.dialog
{
    public partial class DialogAddSongToPlaylist : Form
    {
        private readonly List<Song> songs = new List<Song>();
        private string newSongName, newSongArtist;
        private int newSongId = -1;

        public List<Song> AllSongs
        {
            set
            {
                songs.Clear();
                songs.AddRange(value);
            }
        }
        public int NewSongId => newSongId;


        public DialogAddSongToPlaylist()
        {
            InitializeComponent();
        }


        private void OnLoadDialog(object sender, System.EventArgs e)
        {
            DisplaySongList();
            dgvSongList.CellClick += DisplaySelectedSong;
        }

        private void DisplaySongList()
        {
            dgvSongList.AutoGenerateColumns = true;
            dgvSongList.DataSource = new BindingSource
            {
                DataSource = songs
            };
            dgvSongList.Columns[0].Visible = false;
            dgvSongList.Columns[1].Width = 150;
            dgvSongList.Columns[2].Width = 150;
            dgvSongList.Columns[3].Visible = false;
            dgvSongList.Columns[4].Visible = false;
        }


        private void DisplaySelectedSong(object sender, DataGridViewCellEventArgs e)
        {
            if (sender != null)
            {
                GetSelectedSong();
                DisplaySongInfo();
            }
        }


        private void GetSelectedSong()
        {
            newSongId = (int) dgvSongList.SelectedRows[0].Cells[0].Value;
            newSongName = dgvSongList.SelectedRows[0].Cells[1].Value.ToString();
            newSongArtist = dgvSongList.SelectedRows[0].Cells[2].Value.ToString();        
        }


        private void DisplaySongInfo()
        {
            tbName.Text = newSongName;
            tbArtist.Text = newSongArtist;
        }


        private void OnClickBtnOk(object sender, System.EventArgs e)
        {
            Close();
        }


        private void OnClickBtnCancel(object sender, System.EventArgs e)
        {
            newSongId = -1;
            Close();
        }

    }
}
