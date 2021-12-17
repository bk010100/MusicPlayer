using MusicPlayer.model.util;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.model.repository
{
    public class PlaylistRepository
    {
        #region Singleton

        private static PlaylistRepository instance = null;
        private static readonly object padlock = new object();

        public static PlaylistRepository Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new PlaylistRepository();
                    }

                    return instance;
                }
            }
        }

        #endregion

        private readonly DataProvider provider = new DataProvider();
        private readonly SqlHelper helper;
        private readonly string idParam = "@Id", nameParam = "@Name";
        
        public PlaylistRepository()
        {
            helper = new SqlHelper(provider);
        }


        private List<Playlist> ConvertDatasetToPlaylistList()
        {
            return provider.DataSet.Tables[0].AsEnumerable().Select(
                datarow => new Playlist
                {
                    Id = datarow.Field<int>("id"),
                    Name = datarow.Field<string>("name")
                }).ToList();
        }


        public async Task<List<Playlist>> GetAllPlaylists()
        {
            provider.Connection.Open();

            Task getAllPlaylistsTask = helper.GetTaskRetrieveDataTable("tblPlaylist");
            await SqlHelper.RunSqlTask(getAllPlaylistsTask);
            List<Playlist> allPlaylists = ConvertDatasetToPlaylistList();

            provider.Connection.Close();
            return allPlaylists;
        }



        public bool UpdatePlaylistNameById(int id, string name)
        {
            return helper.RunStoredProcedureAndGetResult("RenamePlaylist", () =>
            {
                provider.Command.Parameters.AddWithValue(idParam, id);
                provider.Command.Parameters.AddWithValue(nameParam, name);
            });
        }


        public bool AddNewPlaylist(string name)
        {
            return helper.RunStoredProcedureAndGetResult("AddPlaylist", () =>
            {
                provider.Command.Parameters.AddWithValue(nameParam, name);            
            });
        }


        public int GetPlaylistIdByName(string name)
        {
            return helper.RunStoredProcedureAndReturnInt("GetPlaylistId", () =>
            {
                provider.Command.Parameters.AddWithValue(nameParam, name);
            });
        }


        public bool DeletePlaylistById(int id)
        {
            return helper.RunStoredProcedureAndGetResult("DeletePlaylist", () =>
            {
                provider.Command.Parameters.AddWithValue(idParam, id);
            });
        }

    }
}
