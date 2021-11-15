// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace CSharpochDB_01
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ange ett namn");
            var input = Console.ReadLine();

            var sql = "Select first_name, last_name from MOCK_DATA WHERE first_name LIKE @param";
            var dt = GetDataTable(sql, "@param", "%" + input + "%");

            PrintRow(dt);

            Console.WriteLine("Ange ett namn");
            input = Console.ReadLine();
            sql = "Select email,first_name, last_name from MOCK_DATA WHERE first_name LIKE @param";
            dt = GetDataTable(sql, "@param",  input );
            PrintRow(dt);

        }

        private static void PrintRow(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine();
            }
        }

        private static DataTable GetDataTable(string sql, string paramName, string paramValue)
        {
            // definiera connectionstring
            var connString = "server=(localdb)\\mssqllocaldb;integrated security=true;database=People";
            // skapa Datatable
            var dt = new DataTable();
            // förbered koppling till databasen
            using (var connection = new SqlConnection(connString))
            {
                // Öppna koppling till databasen
                connection.Open();
                // Förbered kommando
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(paramName, paramValue);

                    // Förbered en adapter
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        // Kopiera databasdata till datatable
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private static void ExecuteSQL(string sql, string paramName, string paramValue)
        {
            // definiera connectionstring
            var connString = "server=(localdb)\\mssqllocaldb;integrated security=true;database=People";
            // skapa Datatable
            var dt = new DataTable();
            // förbered koppling till databasen
            using (var connection = new SqlConnection(connString))
            {
                // Öppna koppling till databasen
                connection.Open();
                // Förbered kommando
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(paramName, paramValue);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

