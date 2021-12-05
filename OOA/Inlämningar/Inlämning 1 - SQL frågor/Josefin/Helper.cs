using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Project1_JosefinPersson
{
    class Helper
    {
        public static void PrintRow(DataTable dt)  // Print-metod
        {
            foreach (DataRow row in dt.Rows)
            {
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    Console.WriteLine(row[i] + " ");
                }
            }
        }

        public static DataTable GetDataTable(string sql, string paramName = "", string paramValue = "")    
        {
            //Defienerar connection-string
            var connString = "server=(localdb)\\mssqllocaldb;integrated security=true;database=Project1_OOA";
            //Skapar data-table
            var dt = new DataTable();
            //Förbereder koppling till databasen
            using (var connection = new SqlConnection(connString))
            {
                //Öppnar koppling till databasen
                connection.Open();
                //Förbereder kommando
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(paramName, paramValue);
                    //Förbereder en adapter
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        //Kopierar databasdata till data-table
                        adapter.Fill(dt);
                    }
                }
            } //Här förstörs kopplingen till databasen, skyddar databasen

            return dt;
        }
    }
}
