using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_SQL
{
    class DatabaseConnection //koden i denna klass kopierad från 'SqlDatabase.cs by Marcus Medina'
    {
        public string ConnectionString { get; set; } = @"Data Source=(localdb)\mssqllocaldb;Database=Personlist;Trusted_Connection=True;";
        public string DatabaseName { get; set; } = "Personlist";

        public DataTable GetDataTable(string sql)
        {
            var dt = new DataTable();

            //sätt ihop connectionstring
            var connString = string.Format(ConnectionString, DatabaseName);

            //förbered sqlConnection
            using (var connection = new SqlConnection(ConnectionString))
            {
                //öppna koppling till databasen
                connection.Open();

                //förbered query
                using (var command = new SqlCommand(sql, connection))
                {

                    //kör query
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }

                    return dt;
                }
            }
        }
    }
}
