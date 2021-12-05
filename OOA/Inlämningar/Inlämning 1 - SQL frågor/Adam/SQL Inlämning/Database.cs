using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Inlämning
{
    public class Database
    {
        public string ConnectionString { get; set; } = @"Server={1};Database={0};Trusted_Connection=True;";
        public string DatabaseName { get; set; } = "master";
        public string Server { get; set; } = "localhost";

        public void ExecuteSQL(string SQL, ParamData[] parameters)
        {
            // Sätt ihop connectionstring
            var connString = string.Format(ConnectionString, DatabaseName, Server);
            // förbered SQLConnection
            using (var connection = new SqlConnection(connString))
            {
                // Öppna koppling till databasen
                connection.Open();
                //förbered query
                using (var command = new SqlCommand(SQL, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            if (param != null && param.Name != null && param.Data != null)
                                command.Parameters.AddWithValue(param.Name, param.Data);
                        }
                    }
                    // kör query
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetDataTable(string SQL, ParamData[] parameters = null)
        {
            var dt = new DataTable();

            // Sätt ihop connectionstring
            var connString = string.Format(ConnectionString, DatabaseName, Server);
            // förbered SQLConnection
            using (var connection = new SqlConnection(connString))
            {
                // Öppna koppling till databasen
                connection.Open();
                //förbered query
                using (var command = new SqlCommand(SQL, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            if (param != null && param.Name != null && param.Data != null)
                                command.Parameters.AddWithValue(param.Name, param.Data);
                        }
                    }
                    // kör query
                    using var adapter = new SqlDataAdapter(command);
                    {
                        adapter.Fill(dt);
                    }
                    return dt;
                }
            }
        }
    }

    public class ParamData
    {
        public string Name { get; set; }
        public string Data { get; set; }
    }
}
