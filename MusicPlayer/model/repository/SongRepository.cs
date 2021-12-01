using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using MusicPlayer.common.util;

namespace MusicPlayer.model.repository
{
    sealed class SongRepository
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

        private List<Song> allSongs = new List<Song>();
        private readonly SqlConnection connection = new SqlConnection()
        {
            ConnectionString = SqlUtil.GetConnectionString()
        };
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        private DataSet dataset = new DataSet();

        public SongRepository()
        {
            
        }


        // Public methods
        public List<Song> GetAllSongs()
        {
            string sql = SqlUtil.GetAllFromTable("TblSong");
            dataAdapter = new SqlDataAdapter(sql, connection);
            dataAdapter.Fill(dataset);

            allSongs = ConvertDatasetToList();
            connection.Close();

            return allSongs;
        }


        // Private methods
        private List<Song> ConvertDatasetToList()
        {
            List<Song> songs = dataset.Tables[0].AsEnumerable().Select(
                datarow => new Song
                {
                    Name = datarow.Field<string>("name"),
                    Author = datarow.Field<string>("author"),
                    FileName = datarow.Field<string>("fileName")
                }).ToList();

            return songs;
        }
    }
}