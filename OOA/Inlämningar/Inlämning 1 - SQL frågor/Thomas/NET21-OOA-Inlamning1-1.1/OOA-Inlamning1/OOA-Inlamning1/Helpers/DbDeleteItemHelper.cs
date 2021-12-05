namespace OOA_Inlamning1.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using static Helpers.ConsolePrintHelpers;
    using static Helpers.SqlHelpers;

    internal class DbDeleteItemHelper
    {
        private static string DbName { get; } = ConfigurationManager.AppSettings["dbName"];

        internal static void AskToDeleteDB()
        {
            string input;
            string sql = $"SELECT count(id) FROM dbo.sysobjects where xtype = 'U'";
            var numberOfTables = ExecuteScalar(sql);
            do
            {
                Console.WriteLine($"\nWould you like to delete the database {DbName} (there are {numberOfTables} tables in the DB)?");
                Console.Write("Please type the whole word \"delete\" to delete it, or \"c\" or \"cancel\" to abort: ");
                input = GetUserString(true);
            } while (!(input == "c" || input == "cancel") && !(input == "delete"));
            if (input == "delete" && numberOfTables == 0) DeleteDB();
            else if (input == "delete")
            {
                Console.WriteLine($"\nAre you sure? There are still {numberOfTables} tables in the database, their data will be lost.");
                Console.Write("Type the whole word \"delete\" again to delete, or anything else to cancel: ");
                if (GetUserString(true) == "delete") DeleteDB();
            }
        }

        private static void DeleteDB()
        {
            File.WriteAllText(ConfigurationManager.AppSettings["importedTables"], "");
            var sql = $"ALTER DATABASE {DbName} SET SINGLE_USER WITH ROLLBACK IMMEDIATE;DROP DATABASE {DbName}";
            Execute(sql, "master");
        }

        internal static void AskToDeleteTable()
        {
            List<string> tables = new();
            var tableFile = ConfigurationManager.AppSettings["importedTables"];
            if (File.Exists(tableFile)) tables.AddRange(File.ReadAllLines(tableFile));
            foreach (var table in tables)
            {
                string input;
                do
                {
                    Console.WriteLine($"\nWould you like to delete the table {table}?");
                    Console.Write("Please type the whole word \"delete\" to delete it, or \"c\" or \"cancel\" to abort: ");
                    input = GetUserString(true);
                } while (!(input == "c" || input == "cancel") && !(input == "delete"));
                if (input == "delete") DeleteTable(table);
            }
        }

        private static void DeleteTable(string table)
        {
            var file = ConfigurationManager.AppSettings["importedTables"];
            List<string> importedTables = new();
            if (File.Exists(file)) importedTables.AddRange(File.ReadAllLines(file));
            if (importedTables.Count > 0)
            {
                importedTables.RemoveAt(importedTables.FindIndex(x => x == table));
            }
            File.WriteAllLines(file, importedTables);

            var sql = $"DROP TABLE {table}";
            Execute(sql);
        }
    }
}