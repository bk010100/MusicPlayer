
namespace MusicPlayer.model.model
{
    class PlayingSong
    {
        private readonly Song song;
        private bool _isPlaying;


        public bool IsPlaying
        {
            get
            {
                return _isPlaying;
            }

            set
            {
                _isPlaying = value;
            }
        }
    }
}
