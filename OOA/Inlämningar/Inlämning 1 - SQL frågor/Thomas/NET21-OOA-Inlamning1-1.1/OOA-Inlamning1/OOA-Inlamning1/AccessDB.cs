namespace OOA_Inlamning1
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using static Helpers.ConsolePrintHelpers;
    using static Helpers.SqlHelpers;

    internal static class AccessDB
    {
        private static List<Person> people = new();
        internal static string tableName = "";
        private static SqlNoDapper snd = new();

        internal static void UsernameAndPassword()
        {
            var sql = $"SELECT COUNT(DISTINCT id),COUNT(DISTINCT username),COUNT(DISTINCT password) FROM {tableName}";
            var values = QueryTupleIntIntInt(sql);
            Console.WriteLine($"There are {values[0].Item1} unique users, {values[0].Item2} unique usernames and {values[0].Item3} unique passwords.");
            Wait();
        }

        internal static void FirstLastAlliteration()
        {
            string sql = $"SELECT id,first_name,last_name FROM {tableName} WHERE LEFT(first_name,1) = LEFT(last_name,1) GROUP BY first_name,last_name,id";
            people = QueryPerson(sql);
            Console.WriteLine("Users with first and last name beginning with the same letter:");
            Console.WriteLine("---------------------------------------------------------------");
            PrintPeopleList(people);
        }

        internal static void FirstTenLastNameStartWithL()
        {
            string sql = $"SELECT TOP 10 id,first_name,last_name FROM {tableName} WHERE LOWER(last_name) LIKE 'l%'";
            people = QueryPerson(sql);
            Console.WriteLine("First 10 users with last name beginning with the letter \"L\"");
            Console.WriteLine("-----------------------------------------------------------");
            PrintPeopleList(people);
        }

        internal static void MostRepresentedCountry()
        {
            string sql = $"SELECT TOP 1 country,COUNT(country) FROM {tableName} GROUP BY country ORDER BY COUNT(country) DESC";
            var countryList = QueryTupleStringInt(sql);
            Console.WriteLine($"\nMost represented country is {countryList[0].Item1} with {countryList[0].Item2} unique users.");
            Wait();
        }

        internal static void FromNordenVsScandinavia()
        {
            var sql = $"SELECT (SELECT COUNT(id) FROM {tableName} WHERE country IN ('Sweden','Denmark','Norway')),(SELECT COUNT(id) FROM {tableName} WHERE country IN ('Sweden','Denmark','Finland','Norway','Iceland'))";
            var usersFromDiffrentParts = QueryTupleIntIntInt(sql);
            Console.WriteLine($"\nThere are {usersFromDiffrentParts[0].Item1} users from Norden and {usersFromDiffrentParts[0].Item2} users from Scandinavia.");
            Wait();
        }

        internal static void DoSingleColumnQuery()
        {
            DoQuery(true);
        }

        internal static void DiffrentCountries()
        {
            var sql = $"SELECT COUNT(DISTINCT country) FROM {tableName}";
            var numberOfDiffrentCountries = ExecuteScalar(sql);
            Console.WriteLine($"\nThere are people from {numberOfDiffrentCountries} diffrent countries in the table.");
            Wait();
        }

        internal static void DoQuery(bool doSingleColumn = false)
        {
            var getTableNames = $"select name from sys.columns where object_id = object_id('dbo.{tableName}')";
            var columnNames = QueryTupleStringInt(getTableNames);
            char input = '0';
            bool inputInRange = false;
            while (input.ToString().ToLower() != "p")
            {
                do
                {
                    input = QueryMenu(columnNames, doSingleColumn);
                    int x = char.IsDigit(input) ? int.Parse(input.ToString()) : 0;
                    inputInRange = x > 0 && x <= columnNames.Count;
                } while (!inputInRange && input.ToString().ToLower() != "p");
                if (inputInRange)
                {
                    string column = columnNames[int.Parse(input.ToString()) - 1].Item1;
                    Console.Write($"\nSearch \"{column[..1].ToUpper() + column[1..].Replace('_', ' ')}\" for: ");
                    var inputStr = GetUserString();
                    if (!doSingleColumn)
                    {
                        DapperQuery(column, inputStr);
                    }
                    else
                    {
                        NoDapperQuery(column, inputStr);
                    }
                }
            }
        }

        private static void NoDapperQuery(string column, string inputStr)
        {
            string sql = $"SELECT {column} FROM {tableName} WHERE {column} LIKE @TOSEARCHFOR";
            DataTable dt = snd.GetDataTable(sql, new (string, string)[] { ("@TOSEARCHFOR", inputStr + "%") });
            PrintDtSingleColumns(column, dt);
        }

        private static void DapperQuery(string column, string inputStr)
        {
            people = UserQuery(column, tableName, inputStr);
            PrintPeopleFullInfoList(people);
        }

        private static char QueryMenu(List<(string name, int unused)> columnNames, bool singleColumnAnswer)
        {
            Console.Clear();
            int counter = 1;
            string header = singleColumnAnswer ? "Query with single column answer" : "Query with all information answer";
            Console.WriteLine(header);
            Console.WriteLine(new string('-', header.Length));
            Console.WriteLine("Columns in table:\n");
            foreach (var name in columnNames)
            {
                Console.WriteLine($"{counter}) {name.Item1[..1].ToUpper() + name.Item1[1..].Replace('_', ' ')}");
                counter++;
            }
            Console.WriteLine("\nP) to return to previous menu.");
            Console.Write("\nWhat would you like to search for?");
            Wait(true);
            return Console.ReadKey(true).KeyChar;
        }
    }
}