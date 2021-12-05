using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Inlämning
{
    public static class Request
    {
        public static void GetDistinctCountries()
        {
            Console.WriteLine("How many countries are represented?");
            var input = Console.ReadKey();





            var database = new Database();

            var response = database.GetDataTable("SELECT COUNT (DISTINCT country) as NumberOfCountries " +
                "FROM[master].[dbo].[MOCK_DATA]");

            if (response != null)
            {
                if (response.Rows.Count > 0)
                {
                    foreach (DataRow row in response.Rows)
                    {
                        Console.WriteLine($"There is {row["NumberOfCountries"]} countries represented.");
                        Console.ReadKey();
                    }
                }
            }

            Console.WriteLine("For next question press enter :)");
            Console.ReadKey();
            Console.Clear();


        }

        public static void GetDistinctPasswordsAndUsername()
        {
            Console.WriteLine("Are the username and passwords unique?");
            var input = Console.ReadKey();

            var database = new Database();

            var response = database.GetDataTable("SELECT count(*) as u " +
                "from[master].[dbo].[MOCK_DATA] " +
                "group by username, password " +
                "having count(*) > 1");

            if (response != null)
            {
                if (response.Rows.Count > 0)
                {
                    Console.WriteLine("All Passwords and usernames are not unique");
                    Console.ReadKey();
                }
                if (response.Rows.Count > 0)
                {
                    foreach (DataRow row in response.Rows)
                    {
                        Console.WriteLine($"{row["passwords"]} {row["userName"]}");
                        Console.ReadKey();
                    }
                }

                else
                {
                    Console.WriteLine("All passwords and usernames are unique.");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("For next question press enter :)");
            Console.ReadKey();
            Console.Clear();
        }

        public static void GetFromTheNorthAndScandinavia()
        {
            Console.WriteLine("How many are from the north respectively from scandinavia?");
            var input = Console.ReadKey();

            var database = new Database();

            var response = database.GetDataTable("SELECT count(Distinct id) " +
                "as The_North_And_Scandinavia " +
                "from[master].[dbo].[MOCK_DATA] " +
                " where country in ('Sweden', 'Denmark', 'Norway', " +
                "'Finland', 'Iceland',) ");

            if (response != null)
            {
                if (response.Rows.Count > 0)
                {
                    foreach (DataRow row in response.Rows)
                    {
                        Console.WriteLine($"There is {row["The_North_And_Scandinavia"]} people from " +
                            $"the north and scandinavia.");
                        Console.ReadKey();
                    }
                }
               
            }
            Console.WriteLine("For next question press enter :)");
            Console.ReadKey();
            Console.Clear();
        }

        public static void GetMostCommonCountry()
        {
            Console.WriteLine("Whats the most common country in this database?");
            var input = Console.ReadKey();

            var database = new Database();

            var response = database.GetDataTable("SELECT top 1 country, count(id) AS users " +
                "FROM[master].[dbo].[MOCK_DATA] " +
                "GROUP BY country " +
                "order by count(id) desc");

            if (response != null)
            {
                if (response.Rows.Count > 0)
                {
                    foreach (DataRow row in response.Rows)
                    {
                        Console.WriteLine($"Its {row["country"]} with {row["users"]} many users");
                        Console.ReadKey();
                    }
                }

            }
            Console.WriteLine("For next question press enter :)");
            Console.ReadKey();
            Console.Clear();
        }

        public static void GetTopTenUsers()
        {
            Console.WriteLine("List the top 10 users whose name starts with L");
            var input = Console.ReadKey();

            var database = new Database();

            var response = database.GetDataTable("SELEcT top 10 * " +
                "from[master].[dbo].[MOCK_DATA] " +
                "where last_name LIKE 'L%'");

            if (response != null)
            {
                if (response.Rows.Count > 0)
                {
                    foreach (DataRow row in response.Rows)
                    {
                        Console.WriteLine($"{row["first_name"]} {row["last_name"]} " +
                            $"from {row["country"]}");
                    }
                }

            }
            Console.WriteLine("For next question press enter :)");
            Console.ReadKey();
            Console.Clear();
        }

        public static void GetUserWithSameLetter()
        {
            Console.WriteLine("List all the users whose firstname and lastname starts with same letter");
            var input = Console.ReadKey();

            var database = new Database();

            var response = database.GetDataTable("SELECT first_name, last_name " +
                "FROM[master].[dbo].[MOCK_DATA] " +
                "WHERE LEFT(first_name, 1) = LEFT(last_name, 1) " +
                "AND first_name <> last_name");

            if (response != null)
            {
                if (response.Rows.Count > 0)
                {
                    foreach (DataRow row in response.Rows)
                    {
                        Console.WriteLine($"{row["first_name"]} {row["last_name"]}");
                    }
                }

            }
            Console.WriteLine("For next question press enter :)");
            Console.ReadKey();
            Console.Clear();
        }
    }

}

