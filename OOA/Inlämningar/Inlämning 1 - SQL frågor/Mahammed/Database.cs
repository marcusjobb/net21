using System.Data;
using System.Data.SqlClient;

namespace SQL.Inlämning
{

    internal class Database
    {
        public string ConnectionString { get; set; } = @"Server={1};Database={0};Trusted_Connection=True;";
        public string DatabaseName { get; set; } = "master";
        public string Server { get; set; } = "localhost";
        public void ExecuteSQL(string SQL, ParamSets[] parameters)
        {
            var connectString = string.Format(ConnectionString, DatabaseName, Server);

            using var Cnn = new SqlConnection(connectString);

            Cnn.Open();

            using var command = new SqlCommand(SQL, Cnn);
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    if (param != null && param.Name != null && param.Data != null)
                        command.Parameters.AddWithValue(param.Name, param.Data);
                }
            }

            command.ExecuteNonQuery();
        }

        public DataTable GetDataTable(string SQL, ParamSets[] parameters = null)
        {
            var dt = new DataTable();
            var connectString = string.Format(ConnectionString, DatabaseName, Server);
            using var Cnn = new SqlConnection(connectString);
            Cnn.Open();
            using var command = new SqlCommand(SQL, Cnn);
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    if (param != null && param.Name != null && param.Data != null)
                        command.Parameters.AddWithValue(param.Name, param.Data);
                }
            }
            using var adapter = new SqlDataAdapter(command);
            {
                adapter.Fill(dt);
            }

            return dt;
        }
    }
}