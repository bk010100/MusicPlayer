using System.Configuration;

namespace MusicPlayer.model.util
{
    public static class SqlUtil
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MusicDb"].ConnectionString;
        }


        public static string GetAllFromTable(string tblName)
        {
            return "SELECT * FROM " + tblName;
        }


        public static string GetNameAuthorDurationFromTblSong()
        {
            return "SELECT name, author, duration from TblSong";
        }
    }
}
