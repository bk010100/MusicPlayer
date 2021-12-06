using MusicPlayer.common.util;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;

namespace MusicPlayer.model.repository
{
    public sealed class SongRepository
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

        public SongRepository()
        {
           
        }


        private void RunOnNewThread(ThreadStart functionName)
        {
            Thread thread = new Thread(functionName);
            thread.Start();
            thread.Join();
            if (thread.IsAlive)
            {
                thread.Abort();
            }
        }


        public List<Song> GetAllSongs()
        {
            connection.Open();

            RunOnNewThread(FillDatasetWithAllSongs);
            List<Song> allSongs = ConvertDatasetToList();

            connection.Close();
            return allSongs;
        }



        private void FillDatasetWithAllSongs()
        {
            string sql = SqlUtil.GetAllFromTable("TblSong");
            dataAdapter = new SqlDataAdapter(sql, connection);
            dataAdapter.Fill(dataset);
        }


        private List<Song> ConvertDatasetToList()
        {
            List<Song> songs = dataset.Tables[0].AsEnumerable().Select(
                datarow => new Song
                {
                    Name = datarow.Field<string>("name"),
                    Artist = datarow.Field<string>("artist"),
                    FileName = datarow.Field<string>("fileName"),
                    Duration = datarow.Field<int>("duration"),
                    Length = datarow.Field<string>("length")
                }).ToList();

            return songs;
        }
    }
}