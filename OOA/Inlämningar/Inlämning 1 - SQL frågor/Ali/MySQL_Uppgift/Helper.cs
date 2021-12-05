using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MySQL_Uppgift;

namespace MySQL_Uppgift
{
    public class Helper
    {
        int MenuChoice = 0;
        bool Exit = false;
        int Counter = 0;


        public static DataTable GetDataTable(string sql)
        {
            var connString = "server=(localdb)\\mssqllocaldb;integrated security=true; database=RandomUsers";
            var dt = new DataTable();
            using (var connection = new SqlConnection(connString))

            {
                connection.Open();

                using (var command = new SqlCommand(sql, connection))
                {
                    
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }

            }
            return dt;
        }

        internal void StartProgram()
        {
            Console.Clear();
            GraphicMeny();
            Console.Write("Enter Choice: ");
            MenuChoice = TryCatch(MenuChoice);
            while (Exit == false)
            {
                GraphicMeny();
                Console.Clear();
                switch (MenuChoice)
                {
                    case 1:
                        First_UniqueCountries();
                        break;

                    case 2:
                        SecondSearch();
                        break;

                    case 3:
                        ThirdSearch();
                        break;

                    case 4:
                        FourthSearch();
                        break;

                    case 5:
                        FifthSearch();
                        break;

                    case 6:
                        SixthSearch();  
                        break;

                    case 7:
                        Exit = true;
                        break;

                    default:
                        StartProgram();
                        break;


                }

            }
        }

        private void GraphicMeny()
        {
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("*|                                                                              |*");
            Console.WriteLine("*|       1.    Show how many unique countries there are.                        |*");
            Console.WriteLine("*|                                                                              |*");
            Console.WriteLine("*|       2.    Show the country the most people come from.                      |*");
            Console.WriteLine("*|                                                                              |*");
            Console.WriteLine("*|       3.    List the 10 first users with a name starting with L              |*");
            Console.WriteLine("*|                                                                              |*");
            Console.WriteLine("*|       4.    Show all users that have the same letter as first and last name. |*");
            Console.WriteLine("*|                                                                              |*");
            Console.WriteLine("*|       5.    Count how many countries are from Nordic and Scandinavian.       |*");
            Console.WriteLine("*|                                                                              |*");
            Console.WriteLine("*|       6.    Are all username and passwords unique?                           |*");
            Console.WriteLine("*|                                                                              |*");
            Console.WriteLine("*|       7.    Exit.                                                            |*");
            Console.WriteLine("*|                                                                              |*");
            Console.WriteLine("**********************************************************************************");
        }

        static void ExecuteSQL(string sql, string paramName, string paramValue)
        {
            var connString = "server=(localdb)\\mssqllocaldb;integrated security=true; database=RandomUsers";
            var dt = new DataTable();
            using (var connection = new SqlConnection(connString))

            {
                connection.Open();

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue(paramName, paramValue);
                    command.ExecuteNonQuery();

                }

            }


        }

        public void First_UniqueCountries()
        {

            Counter = 0;
            var sql = "select country, count(distinct country) as 'unique country' from RandomUsers group by country";
            var dt = GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                Counter++;
                Console.WriteLine(row["country"] + " " + Counter);
                

            }
            Console.WriteLine("");
            Console.WriteLine("There are " + Counter + " Unique Countries");

            PressSomething();
        }


        public int TryCatch(int Choose)
        {
            try
            {
                Choose = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Choose = 0;
                Console.Clear();
            }

            return Choose;
        }

        public void SecondSearch()
        {
            var sql = "SELECT top 1  country,  COUNT(country) AS country_occurrence from RandomUsers group by country ORDER BY   country_occurrence DESC";
            var dt = GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                
                Console.WriteLine("Most people come from " + row["country"] + " " + "There are " + row["country_occurrence"] +  " from there");


            }
            PressSomething();
        }

        public void ThirdSearch()
        {
            Counter = 0;
            var sql = "SELECT top 10 last_name from RandomUsers where last_name like 'L%'";
            var dt = GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                Counter++;
                Console.WriteLine(Counter + " Last name: " + row["last_name"]);


            }
            PressSomething();
        }

        public void FourthSearch()
        {
            var sql = "SELECT first_name, last_name from RandomUsers where left(first_name, 1) = left(last_name, 1)";
            var dt = GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                Counter++;
                Console.WriteLine(row["First_name"] + " " + row["last_name"]);


            }
            PressSomething();
        }

        public void FifthSearch()
        {
            var sql = "SELECT count(country) as 'Skandinaviska' from RandomUsers where country like 'sweden' or country like 'denmark' or country like 'norway'";
            var dt = GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                Counter++;
                Console.WriteLine("There are " + row["Skandinaviska"] + " countries from scandinavium.");


            }

             sql = "SELECT count(country) as 'Nordic Countries' from RandomUsers where country like 'finland' or country like 'denmark' or country like 'norway' or country like 'sweden' or country like 'iceland'";
             dt = GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                Counter++;
                Console.WriteLine("There are " + row["Nordic Countries"] + " Nordic Countries.");


            }

            PressSomething();
        }

        public void SixthSearch()
        {
            var sql = "SELECT count(distinct password) as 'Unique Passwords', count(distinct username) as 'Unique Usernames'  from RandomUsers";
            var dt = GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                

                Console.WriteLine("There are " + row["Unique Passwords"] + " unique passwords"+  " and " + row["Unique Passwords"] + " unique usernames");

            }
            PressSomething();
        }

        public void PressSomething()
        {
            Console.WriteLine("");
            Console.WriteLine("[Enter to continue.]");
            Console.ReadKey();
            StartProgram();
        }
    }
}