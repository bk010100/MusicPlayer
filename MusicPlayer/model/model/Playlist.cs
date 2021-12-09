namespace MusicPlayer.model
{
    public class Playlist
    {
        private readonly int id;
        private string name;
        private int songsNumber;


        public int Id { get => id; }
        public string Name { get => name; set => name = value; }
        public int SongNumber { get => songsNumber; set => songsNumber = value; }
    }
}
