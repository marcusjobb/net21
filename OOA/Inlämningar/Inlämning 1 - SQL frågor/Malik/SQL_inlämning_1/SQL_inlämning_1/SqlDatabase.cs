using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_inlämning_1
{
    class SqlDatabase
    {
        public string ConnectionString { get; set; } = @"Server={1};Database={0};Trusted_Connection=True;";
        public string DatabaseName { get; set; } = "mlk";
        public string Server { get; set; } = @"(localdb)\mssqllocaldb";

        public DataTable GetDataTable(string sql)
        {
            var dt = new DataTable();
            
            var connString = string.Format(ConnectionString, DatabaseName, Server);
            
            using var connection = new SqlConnection(connString);
            
            connection.Open();
           
            using var command = new SqlCommand(sql, connection);

            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;
        }
    }
}
