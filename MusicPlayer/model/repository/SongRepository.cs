using MusicPlayer.model.model;
using MusicPlayer.model.util;
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

        private readonly DataProvider provider = new DataProvider();
        private readonly SqlHelper helper;
        private readonly string idParam = "@Id", nameParam = "@Name", artistParam = "@Artist", durationParam = "@Duration", fileNameParam = "@FileName", lengthParam = "@Length";
        private readonly string songIdParam = "@SongId" ,playlistIdParam = "@PlaylistId";

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


        private List<int> ConvertDatasetToIntList()
        {
            return provider.DataSet.Tables[0]
                .AsEnumerable()
                .Select(datarow => datarow.Field<int>("songId"))
                .ToList();
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


        public async Task<List<int>> GetSongIdsFromPlaylist(int playlistId)
        {
            provider.Connection.Open();

            Task getSongsTask = GetTaskRetriveSongIdFromPlaylist(playlistId);
            await SqlHelper.RunSqlTask(getSongsTask);
            List<int> songIds = ConvertDatasetToIntList();

            provider.Connection.Close();
            return songIds;
        }


        public Task GetTaskRetriveSongIdFromPlaylist(int playlistId)
        {
            return new Task(() =>
            {
                provider.DataSet.Clear();
                provider.Command = new SqlCommand("GetSongIdFromPlaylist", provider.Connection);
                provider.Command.CommandType = CommandType.StoredProcedure;
                provider.Command.Parameters.AddWithValue(playlistIdParam, playlistId);
                provider.DataAdapter = new SqlDataAdapter(provider.Command);
                provider.DataAdapter.Fill(provider.DataSet);
            });
        }


        public bool AddNewSong(Song song)
        {
            return helper.RunStoredProcedureAndGetResult("AddSong", () =>
            {
                provider.Command.Parameters.AddWithValue(nameParam, song.Name);
                provider.Command.Parameters.AddWithValue(artistParam, song.Artist);
                provider.Command.Parameters.AddWithValue(durationParam, song.Duration);
                provider.Command.Parameters.AddWithValue(fileNameParam, song.FileName);
                provider.Command.Parameters.AddWithValue(lengthParam, song.Length);
            });
        }


        public int GetSongId(string name, string artist)
        {
            return helper.RunStoredProcedureAndReturnInt("GetSongId", () =>
            {
                provider.Command.Parameters.AddWithValue(nameParam, name);
                provider.Command.Parameters.AddWithValue(artistParam, artist);
            });
        }


        public bool UpdateSong(int id, string name, string artist)
        {
            return helper.RunStoredProcedureAndGetResult("UpdateSong", () =>
            {
                provider.Command.Parameters.AddWithValue(idParam, id);
                provider.Command.Parameters.AddWithValue(nameParam, name);
                provider.Command.Parameters.AddWithValue(artistParam, artist);
            });
        }


        public bool DeleteSong(int id)
        {
            return helper.RunStoredProcedureAndGetResult("DeleteSong", () =>
            {
                provider.Command.Parameters.AddWithValue(idParam, id);            
            });
        }


        public bool DeleteSongIdFromPlaylist(int songId, int playlistId)
        {
            return helper.RunStoredProcedureAndGetResult("DeleteSongIdFromPlaylist", () =>
            {
                provider.Command.Parameters.AddWithValue(songIdParam, songId);
                provider.Command.Parameters.AddWithValue(playlistIdParam, playlistId);
            });
        }


        public bool AddSongToPlaylist(int songId, int playlistId)
        {
            return helper.RunStoredProcedureAndGetResult("AddSongToPlaylist", () =>
            {
                provider.Command.Parameters.AddWithValue(songIdParam, songId);
                provider.Command.Parameters.AddWithValue(playlistIdParam, playlistId);
            });
        }

    }
}