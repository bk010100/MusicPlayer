namespace MusicPlayer.model
{
    public class Song
    {
        private int Id;
        private string name;
        private string author;
        private int duration;
        private string fileName;

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public int Duration { get => duration; set => duration = value; }
        public string FileName { get => fileName; set => fileName = value; }

    }
}
