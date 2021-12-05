using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Assignment1
{


    internal class SQLDatabase
    {
        // Stores the connection string
        public string ConnectionString { get; set; } = @"Server={0};Database={1};Trusted_Connection=True;";
        // Set database name
        public string DatabaseName { get; set; } = "master";
        // Set server name
        public string Server { get; set; } = "(localdb)\\mssqllocaldb";
        // Sets the new database name which we will work against.
        public string NewDatabaseName { get; set; } = "Assignment1_MockDB";


        /// <summary>
        /// The constructor is used to establish a connection and create a new DB upon instantiation of the class.
        /// </summary>
        public SQLDatabase()
        {
            ConnectAndCreateNew();
        }

        /// <summary>
        /// Connects to the "master" database first (under the assumption that the user has some kind of SQL database so that the master database exists)
        /// then creates a new DB which the later methods can use. There might be a better way of creating a database from scratch, but it seems there must be a connection
        /// established from the start to create one, so this is the only solution I came up with.
        /// </summary>
        private void ConnectAndCreateNew()
        {
            // If the stuff inside the parenthesis doesn't exist, creates a new database with the NewDatabaseName property as name.
            string createDB = $"IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = '{NewDatabaseName}') CREATE DATABASE {NewDatabaseName}";
            var connString = string.Format(ConnectionString, Server, DatabaseName);
            using var connection = new SqlConnection(connString);
            connection.Open();
            using var command = new SqlCommand(createDB, connection);
            command.ExecuteNonQuery();
        }


        /// <summary>
        /// Connects to the database and executes an sql command which doesn't need to return anything.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        public void ExecuteSQL(string sql, ParamData[] parameters) 
        {
            // Format the connection string, store in connString
            var connString = string.Format(ConnectionString, Server, NewDatabaseName); 
            // Prepare the connection
            using var connection = new SqlConnection(connString);
            // Open the connection.
            connection.Open();
            // Prepare the command/query
            using var command = new SqlCommand(sql, connection);
            //// "Query" stuff in case a user needs to input parameters for a command, not used in this particular program.
            if (parameters != null)
                foreach (var param in parameters)
                {
                    if (param != null && param.Name != null && param.Data != null)
                        command.Parameters.AddWithValue(param.Name, param.Data);
                }
            // Executes query.
            command.ExecuteNonQuery();
        }


        /// <summary>
        /// Executes a command to the database, fills an adapter and returns the contents of the adapter.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        internal DataTable GetDataTable(string sql, ParamData[] parameters)
        {
            var dt = new DataTable();
            var connString = string.Format(ConnectionString, Server, NewDatabaseName);
            using var connection = new SqlConnection(connString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);

            if (parameters != null)
                foreach (var param in parameters)
                {
                    if (param != null && param.Name != null && param.Data != null)
                        command.Parameters.AddWithValue(param.Name, param.Data);
                }
            // Datatable gets filled using the adapter with the sql command.
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dt); 
            return dt;
        }

    }
}
