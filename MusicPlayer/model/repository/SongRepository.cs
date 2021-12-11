using MusicPlayer.common.util;
using MusicPlayer.model.model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

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
        private SqlCommand command = new SqlCommand();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private readonly DataSet dataset = new DataSet();

        public SongRepository()
        {
           
        }


        private async Task RunTask(Task task)
        {
            task.Start();
            await task;
            task.Dispose();
        }


        private List<Song> ConvertDatasetToSongList()
        {
            return dataset.Tables[0].AsEnumerable().Select(
                datarow => new Song
                {
                    Name = datarow.Field<string>("name"),
                    Artist = datarow.Field<string>("artist"),
                    FileName = datarow.Field<string>("fileName"),
                    Duration = datarow.Field<int>("duration"),
                    Length = datarow.Field<string>("length")
                }).ToList();
        }


        public async Task<List<Song>> GetAllSongs()
        {
            connection.Open();

            await RunTask(GetTaskRetrieveAllSongsFromDb());
            List<Song> allSongs = ConvertDatasetToSongList();
            
            connection.Close();
            return allSongs;
        }



        private Task GetTaskRetrieveAllSongsFromDb()
        {
            return new Task(() =>
            {
                string sql = SqlUtil.GetAllFromTable("TblSong");
                dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataset);
            }); 
        }

    }
}