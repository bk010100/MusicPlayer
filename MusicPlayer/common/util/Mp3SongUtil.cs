using WMPLib;

namespace MusicPlayer.common.util
{
    class Mp3SongUtil
    {
        private static readonly string audioLocation = @"C:\Users\Speedyservice\Music\MusicPlayer\";
        private static readonly WindowsMediaPlayer player = new WindowsMediaPlayer();
        private static IWMPMedia media;

        public static string GetSongLocation(string mp3File)
        {
            return audioLocation + mp3File;
        }


        public static void PlaySong(string mp3File)
        {
            player.URL = GetSongLocation(mp3File);
            player.controls.play();
        }


        public static int GetSongDurationInSecond(string mp3File)
        {
            media = player.newMedia(GetSongLocation(mp3File));
            int duration = (int)media.duration;

            // Stop the music and return result
            player.controls.stop();
            return duration;
        }
    }
}
