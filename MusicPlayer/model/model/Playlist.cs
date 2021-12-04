namespace MusicPlayer.model
{
    public class Playlist
    {
        private int id;
        private string name;
        private int songsNumber;

        public string Name { get => name; set => name = value; }
        public int SongNumber { get => songsNumber; set => songsNumber = value; }
    }
}
