using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MusicPlayer.model.util
{
    public class SqlHelper
    {
        private readonly DataProvider provider = new DataProvider();


        public SqlHelper(DataProvider dataProvider)
        {
            provider = dataProvider;
        }


        public static async Task RunSqlTask(Task task)
        {
            task.Start();
            await task;
            task.Dispose();
        }


        public Task GetTaskRetrieveDataTable(string tblName)
        {
            return new Task(() =>
            {
                provider.DataSet.Clear();
                string sql = SqlUtil.GetAllFromTable(tblName);
                provider.DataAdapter = new SqlDataAdapter(sql, provider.Connection);
                provider.DataAdapter.Fill(provider.DataSet);
            });
        }


        public bool RunStoredProcedureAndGetResult(string procedureName, Action getParam)
        {
            provider.Connection.Open();

            provider.Command = new SqlCommand(procedureName, provider.Connection);
            provider.Command.CommandType = CommandType.StoredProcedure;
            provider.Command.Parameters.Clear();
            getParam();

            int result = provider.Command.ExecuteNonQuery();
            provider.Connection.Close();
            return result > 0;
        }

        
        public int RunStoredProcedureAndReturnInt(string procedureName, Action getParam)
        {
            provider.Connection.Open();

            provider.Command = new SqlCommand(procedureName, provider.Connection);
            provider.Command.CommandType = CommandType.StoredProcedure;
            provider.Command.Parameters.Clear();
            getParam();

            int result = (int) provider.Command.ExecuteScalar();
            provider.Connection.Close();
            return result;
        }

        
    }
}
