namespace MusicPlayer.model
{
    public class Playlist
    {
        private int id;
        private string name;
        private int songsNumber;


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int SongNumber { get => songsNumber; set => songsNumber = value; }
    }
}
