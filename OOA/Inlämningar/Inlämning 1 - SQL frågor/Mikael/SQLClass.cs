using System.Data;
using System.Data.SqlClient;
using System;

namespace SQL_appv2
{
    class SQLClass
    {

        public static DataTable GetDataTable(string sql, string paramName = "", string paramValue = "")
        {

            var connString = "server=(localdb)\\mssqllocaldb;integrated security=true;database=sqlprojectv2";
           
            var dt = new DataTable();
                    
            using (var connection = new SqlConnection(connString))
            {
           
                connection.Open();
               
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(paramName, paramValue);
                    
                    using (var adapter = new SqlDataAdapter(command))
                    {                      
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public static void PrintRow(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    Console.WriteLine("+-----------+");
                    
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine("");
                Console.WriteLine("+-----------+");
            }
        }
    }
}
