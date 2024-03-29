﻿// -----------------------------------------------------------------------------------------------
//  SqlDatabase.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace SQLDVTest
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SqlDatabase
    {
        public string ConnectionString { get; set; } = @"Server={1};Database={0};Trusted_Connection=True;";
        public string DatabaseName { get; set; } = "master";
        public string Server { get; set; } = @"(localdb)\mssqllocaldb";

        public void ExecuteSQL(string sql, ParamData[] parameters)
        {
            // Sätt ihop connectionstring
            var connString = string.Format(ConnectionString, DatabaseName, Server);
            // Förbered SQLConnection
            using var connection = new SqlConnection(connString);
            // Öppna koppling till databasen
            connection.Open();
            // Förbered query
            using var command = new SqlCommand(sql, connection);
            // använd parametrar
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    if (param != null && param.Name != null && param.Data != null)
                        command.Parameters.AddWithValue(param.Name, param.Data);
                }
            }
            // Kör query
            command.ExecuteNonQuery();
        }

        public DataTable GetDataTable(string sql, ParamData[] parameters)
        {
            var dt = new DataTable();
            // Sätt ihop connectionstring
            var connString = string.Format(ConnectionString, DatabaseName, Server);
            // Förbered SQLConnection
            using var connection = new SqlConnection(connString);
            // Öppna koppling till databasen
            connection.Open();
            // Förbered query
            using var command = new SqlCommand(sql, connection);
            // använd parametrar
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    if (param != null && param.Name != null && param.Data != null)
                        command.Parameters.AddWithValue(param.Name, param.Data);
                }
            }
            // Kör query
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);

            return dt;
        }
    }

    public class ParamData
    {
        public string Name { get; set; }
        public string Data { get; set; }
    }
}
