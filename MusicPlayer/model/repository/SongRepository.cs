using MusicPlayer.model.model;
using MusicPlayer.model.util;
using System.Collections.Generic;
using System.Data;
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

        private readonly DataProvider provider = new DataProvider();
        private readonly SqlHelper helper;

        public SongRepository()
        {
            helper = new SqlHelper(provider);
        }


        private List<Song> ConvertDatasetToSongList()
        {
            return provider.DataSet.Tables[0].AsEnumerable().Select(
                datarow => new Song
                {
                    Id = datarow.Field<int>("id"),
                    Name = datarow.Field<string>("name"),
                    Artist = datarow.Field<string>("artist"),
                    FileName = datarow.Field<string>("fileName"),
                    Duration = datarow.Field<int>("duration"),
                    Length = datarow.Field<string>("length")
                }).ToList();
        }


        public async Task<List<Song>> GetAllSongs()
        {
            provider.Connection.Open();

            Task getAllSongsTask = helper.GetTaskRetrieveDataTable("TblSong");
            await SqlHelper.RunSqlTask(getAllSongsTask);
            List<Song> allSongs = ConvertDatasetToSongList();
            
            provider.Connection.Close();
            return allSongs;
        }


    }
}