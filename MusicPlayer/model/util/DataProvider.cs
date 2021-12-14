using System.Data;
using System.Data.SqlClient;

namespace MusicPlayer.model.util
{
    public class DataProvider
    {
        private readonly SqlConnection connection = new SqlConnection()
        {
            ConnectionString = SqlUtil.GetConnectionString()
        };
        private SqlCommand command = new SqlCommand();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private readonly DataSet dataSet = new DataSet();


        public SqlConnection Connection { get => connection; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter DataAdapter { get => dataAdapter; set => dataAdapter = value; }
        public DataSet DataSet { get => dataSet; }


    }
}
