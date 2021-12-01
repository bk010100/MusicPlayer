using System.Configuration;

namespace MusicPlayer.common.util
{
    public static class SqlConnectionUtil
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MusicPlayer.MusicPlayerDb"].ConnectionString;
        }
    }
}
