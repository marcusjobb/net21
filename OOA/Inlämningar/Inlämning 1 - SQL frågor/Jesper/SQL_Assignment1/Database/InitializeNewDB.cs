using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Assignment1.Database;

namespace SQL_Assignment1.Database
{
    internal class InitializeNewDB
    {
        // Initializes a new instance of the SQLDatabase class, which also creates a new database if there's no db with the same name.
        internal static SQLDatabase dt = new();
        
        /// <summary>
        /// Creates a new table in the chosen database.
        /// </summary>
        internal static void CreateTables()
        {
            // If the table exists, drops it and creates a new one to avoid "table already exists error".
            // Hopefully uses the new database before dropping the table, so it doesn't accidentaly drop some other table.
            var createTables =  $"USE {dt.NewDatabaseName} DROP TABLE if EXISTS MOCKUP_DATA CREATE TABLE MOCKUP_DATA (id INT, first_name VARCHAR(50), last_name VARCHAR(50), email VARCHAR(50), username VARCHAR(50), password VARCHAR(50), country VARCHAR(50))";
            dt.ExecuteSQL(createTables, null);
        }


        /// <summary>
        /// Reads an sql file with table data, stored in the solution directory. For each line stored in the file, executes an sql command which populates the created table.
        /// </summary>
        internal static void PopulateTableFromSQLFile()
        {

            // The mockup data is stored in the project directory,
            var userFolder = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(userFolder, "MOCKUP_DATA.sql");
            
            if (File.Exists(filePath))
            {
                var sqlText = File.ReadAllLines(filePath);
                foreach (var line in sqlText)
                {
                    dt.ExecuteSQL(line, null);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No DB file found. The program won't work correctly.");
                Helpers.UserExperience.PressEnterToContinue();
            }

        }

    }
}
