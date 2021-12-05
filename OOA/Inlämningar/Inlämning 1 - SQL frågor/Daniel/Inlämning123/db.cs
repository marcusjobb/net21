using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning123
{
    public class Get
    {
        // Få ut hur många länder som är representerade
        public static void Countriesrepresented()
        {
            Console.WriteLine("How many countries are represented?");
            
            var input = Console.ReadKey();

            var db = new Database();

            var sql = db.GetDataTable("SELECT COUNT (DISTINCT country) as Countriesrepresented " +
                "FROM[arlbring test].[dbo].[Lista]");

            if (sql != null)
            {
                if (sql.Rows.Count > 0)
                {
                    foreach (DataRow add in sql.Rows)
                    {
                        Console.WriteLine($"There is {add["CountriesRepresented"]} " + $"countries represented.");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Press any key to go back to the menu:");
                        Console.ReadKey();
                        
                    }
                }
            }

        }
        //Få ifall användarnamn och lösenorden är unika eller ej
        public static void Usernameandpassword()
        {
            Console.WriteLine("Are the username and password unique?");

            var db = new Database();

            var input = Console.ReadKey();

            var sql = db.GetDataTable("SELECT count(*) as u " +
                "from[arlbring test].[dbo].[Lista] " +
                "group by username, password " + "having count(*) > 1");

            if (sql != null)
            {
                if (sql.Rows.Count > 0)
                {
                    Console.WriteLine("All the username and passwords are not unique");
                    Console.ReadKey();
                }
                if (sql.Rows.Count > 0)
                {
                    foreach(DataRow add in sql.Rows)
                    {
                        Console.WriteLine($"{add["password"]} {add["username"]}");
                        Console.ReadKey();
                    }
                }

                else
                {
                    Console.WriteLine("All username and passwords are unique.");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Press any key to go back to the menu:");
                    Console.ReadKey();
                    Console.Clear();


                }
            }
        }
        // Få ut hur många som är från norden respektive skandinavien
        public static void Northandscandiviancountries()
        {
            Console.WriteLine("How many users are from Iceland, Finland and the rest of Scandinavia?");
            var  input = Console.ReadKey();

            var db = new Database();

            var sql = db.GetDataTable("SELECT count(Distinct id) " +
                "as Iceland_Finland_Scandinavia " +
                "from[arlbring test].[dbo].[Lista] " +
                " where country in ('Denmark', 'Sweden', 'Norway', " + "'Finland', 'Iceland') " + "having count(*) > 0");

            if (sql != null)
            {
                if (sql.Rows.Count > 0)
                {
                    foreach (DataRow add in sql.Rows)
                    {
                        Console.WriteLine($"There are {add["Iceland_Finland_Scandinavia"]} people from " +
                            $"Iceland, Finland and the rest of Scandinavia.");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Press any key to go back to the menu:");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

            }

        }
        // Här vill jag få ut det vanligaste landet
        public static void Mostcommoncountry()
        {
            Console.WriteLine("Which country is the most common?");
            var input = Console.ReadKey();

            var db = new Database();

            var sql = db.GetDataTable("SELECT top 1 country, count (id) as users " +
                "FROM[arlbring test].[dbo].[Lista] " +
                "GROUP BY country " + "order by count (id) DESC ");

            if (sql != null)
            {
                if (sql.Rows.Count > 0)
                {
                    foreach (DataRow add in sql.Rows)
                    {
                        Console.WriteLine($"It is {add["country"]} with {add["users"]} users");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("Press any key to go back to the menu:");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

            }
        }
        // Här ska man få ut 10 första efternamnen med bokastaven L
        public static void FirstlastnamewiththeletterL()
        {
            Console.WriteLine("Show the first 10 names with the last name starts with L");
            var input = Console.ReadKey();

            var db = new Database();

            var sql = db.GetDataTable("SELECT top 10 * " +
                "from[arlbring test].[dbo].[Lista] " + "where last_name LIKE 'L%'");

            if (sql != null)
            {
                if (sql.Rows.Count > 0)
                {
                    foreach (DataRow add in sql.Rows)
                    {
                        Console.WriteLine($"{add["first_name"]} {add["last_name"]} " + "" );
                            
                    }
                }

            }



            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press any key to go back to the menu:");
            
            Console.ReadKey();
            Console.Clear();
        }

        // Få ut användare som har samma bokstav på för och efternamn
        public static void Userswithsamename()
        {
            Console.WriteLine("Show users with first and last name beginning with the same letter:");
            var input = Console.ReadKey();

            var db = new Database();

            var sql = db.GetDataTable("SELECT first_name, last_name " + "FROM[arlbring test].[dbo].[Lista] " +
                "WHERE LEFT(first_name, 1) = LEFT(last_name, 1) " +
                "AND first_name <> last_name");

            if (sql != null)
            {
                if (sql.Rows.Count > 0)
                {
                    foreach (DataRow add in sql.Rows)
                    {
                        Console.WriteLine($"{add["first_name"]} {add["last_name"]}");
                    }
                }

            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Press any key to go back to the menu:");
            Console.ReadKey();
            Console.Clear();
        }
    }

}
