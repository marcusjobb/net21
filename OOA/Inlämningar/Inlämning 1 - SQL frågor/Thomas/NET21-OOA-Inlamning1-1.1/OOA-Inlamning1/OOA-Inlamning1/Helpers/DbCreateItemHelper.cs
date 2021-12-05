namespace OOA_Inlamning1.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using static Helpers.ConsolePrintHelpers;
    using static Helpers.SqlHelpers;

    internal static class DbCreateItemHelper
    {
        private static string DbName { get; } = ConfigurationManager.AppSettings["dbName"];
        internal static string tableName = "";

        internal static void ImportTable(string importFile)
        {
            string sql = File.ReadAllText(importFile);
            Execute(sql);
            string file = ConfigurationManager.AppSettings["importedTables"];
            List<string> importedTables = new();
            if (File.Exists(file)) importedTables.AddRange(File.ReadAllLines(file));
            if (!importedTables.Contains(tableName)) importedTables.Add(tableName);
            File.WriteAllLines(file, importedTables);
        }

        internal static void AskToImportTable(string nameFromFile, string file)
        {
            string input;
            do
            {
                Console.Write($"Table {nameFromFile} doesn't exist, would you like to (i)mport it or (s)kip? ");
                input = GetUserString(true).ToLower().Trim();
            } while (!(input == "i" || input == "import") && !(input == "s" || input == "skip"));
            if (input[0] == 'i')
            {
                DbCheckHelper.SetTableName(nameFromFile);
                ImportTable(file);
            }
        }

        internal static void AskToCreateDB()
        {
            string input;
            do
            {
                Console.Write($"Database {DbName} doesn't exist, would you like to (c)reate it or (s)kip? ");
                input = GetUserString(true);
            } while (!(input == "c" || input == "create") && !(input == "s" || input == "skip"));
            if (input[0] == 'c') CreateDB(DbName);
        }

        private static void CreateDB(string dbName)
        {
            string sql = $"IF NOT EXISTS (SELECT NAME FROM master.dbo.sysdatabases WHERE name = '{dbName}') CREATE DATABASE {dbName}";
            Execute(sql, "master");
        }
    }
}