using System.Configuration;

namespace MusicPlayer.common.util
{
    public static class SqlUtil
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MusicPlayerDataSource"].ConnectionString;
        }

       
        public static string GetAllFromTable(string tblName)
        {
            return "SELECT * FROM " + tblName;
        }
    }
}
