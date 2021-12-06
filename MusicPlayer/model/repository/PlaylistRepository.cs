using MusicPlayer.common.util;
using System.Data;
using System.Data.SqlClient;

namespace MusicPlayer.model.repository
{
    class PlaylistRepository
    {

        #region Singleton

        private static SongRepository instance = null;
        private static readonly object padlock = new object();

        public static SongRepository Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SongRepository();
                    }

                    return instance;
                }
            }
        }

        #endregion

        private readonly SqlConnection connection = new SqlConnection()
        {
            ConnectionString = SqlUtil.GetConnectionString()
        };
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        private readonly DataSet dataset = new DataSet();
        
    }
}
