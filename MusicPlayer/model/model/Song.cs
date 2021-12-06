namespace MusicPlayer.model
{
    public class Song
    {
        private int Id;
        private string name;
        private string artist;
        private int duration;
        private string fileName;
        private string length;

        public string Name { get => name; set => name = value; }
        public string Artist { get => artist; set => artist = value; }
        public int Duration { get => duration; set => duration = value; }
        public string FileName { get => fileName; set => fileName = value; }
        public string Length { get => length; set => length = value; }

    }
}
