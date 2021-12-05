namespace OOA_Inlamning1.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using static Helpers.ConsolePrintHelpers;
    using static Helpers.SqlHelpers;

    internal static class DbCheckHelper
    {
        internal static string DbName { get; } = ConfigurationManager.AppSettings["dbName"];
        private static string tableName = "";

        internal static bool CheckForDB()
        {
            CheckForDBServer();
            bool dbExists = false;

            string sql = $"SELECT COUNT(name) FROM master.dbo.sysdatabases WHERE name = '{DbName}'";
            if (ExecuteScalar(sql, "master") == 1) dbExists = true;
            return dbExists;
        }

        private static void CheckForDBServer()
        {
            try
            {
                ExecuteScalar("SELECT COUNT(@@VERSION)", "master");
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Could not connect to SQL server, exiting application.");
                Hold();
                Environment.Exit(0);
            }
        }

        private static int CheckForOtherTables()
        {
            int numberOfTables = 0;
            var file = ConfigurationManager.AppSettings["importedTables"];
            List<string> tables = new();
            if (File.Exists(file)) tables.AddRange(File.ReadAllLines(file));
            if (tables.Count > 0 && tableName == "") SetTableName(tables[0]);
            if (tables.Count > 0) numberOfTables = tables.Count;
            return numberOfTables;
        }

        internal static void SetTableName(string tableName)
        {
            DbCheckHelper.tableName = tableName;
            AccessDB.tableName = tableName;
            SqlAnswers.tableName = tableName;
            DbCreateItemHelper.tableName = tableName;
        }

        internal static bool CheckForTable(string name = "")
        {
            bool tableExists = false;
            string localName = name == "" ? tableName : name;
            string sql = $"SELECT count(name) FROM dbo.sysobjects where name = '{localName}' and xtype = 'U'";
            if (ExecuteScalar(sql) == 1)
            {
                SetTableName(localName);
                tableExists = true;
            }
            return tableExists;
        }

        internal static void ChangeTable()
        {
            List<string> tables = new();
            string file = ConfigurationManager.AppSettings["importedTables"];
            if (File.Exists(file)) tables.AddRange(File.ReadAllLines(file));
            int choice = ChangeTableMenu(tables);
            if (choice != -1) SetTableName(tables[choice]);
        }

        private static int ChangeTableMenu(List<string> tables)
        {
            char input;
            int choice;
            bool inRange = false;
            do
            {
                Console.Clear();
                Console.WriteLine($"Current table is: {tableName}");
                Console.WriteLine();
                for (int i = 0; i < tables.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {tables[i]}");
                }
                Console.WriteLine("\nP) Previous menu.");
                Wait(true);
                input = Console.ReadKey(true).KeyChar;
                choice = char.IsDigit(input) ? Int32.Parse(input.ToString()) : -1;
                if (choice > 0 && choice <= tables.Count)
                {
                    choice--;
                    inRange = true;
                }
            } while (!inRange && input.ToString().ToLower() != "p");
            return choice;
        }

        private static void CheckForImportFiles()
        {
            string tableNameFromFile;
            string[] files = Directory.GetFiles(ConfigurationManager.AppSettings["sqlDir"], "*.sql");
            if (files.Length > 0)
            {
                foreach (var file in files)
                {
                    tableNameFromFile = "";
                    foreach (var line in File.ReadLines(file))
                    {
                        if (line.ToLower().Contains("create table"))
                        {
                            int idxSecondSpace = line.Trim().IndexOf(' ', line.Trim().IndexOf(' ') + 1);
                            int length = line.Trim().IndexOf('(') - idxSecondSpace;
                            tableNameFromFile = line.Substring(idxSecondSpace, length).Trim();
                            break;
                        }
                    }
                    if (!CheckForTable(tableNameFromFile)) DbCreateItemHelper.AskToImportTable(tableNameFromFile, file);
                }
            }
        }

        internal static (bool, string, int) CheckData()
        {
            (bool exists, string tableName, int numberOfTables) data = (false, "", 0);
            if (!CheckForDB()) DbCreateItemHelper.AskToCreateDB();
            if (CheckForDB())
            {
                CheckForImportFiles();
                data.numberOfTables = CheckForOtherTables();
            }
            if (CheckForDB() && CheckForTable())
            {
                data.exists = true;
                data.tableName = tableName;
            }
            return data;
        }

        internal static void ExitCheckData()
        {
            Console.CursorVisible = true;
            if (CheckForDB() && CheckForTable()) DbDeleteItemHelper.AskToDeleteTable();
            if (CheckForDB()) DbDeleteItemHelper.AskToDeleteDB();
            Console.CursorVisible = false;
        }
    }
}