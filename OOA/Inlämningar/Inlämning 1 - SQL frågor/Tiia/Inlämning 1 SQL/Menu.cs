using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_1_SQL
{
    static class Menu
    {
        public static void StartMenu()
        {
            var db = new DatabaseConnection();
            db.DatabaseName = "Personlist";

            while (true)
            {
                Visual.MainMenu();
                var menuChoise = Helper.UserChoise();

                switch (menuChoise)
                {
                    case 1:
                        DistinctCountries(db);
                        break;
                    case 2:
                        UniqueValues(db);
                        break;
                    case 3:
                        NordicVsScandinavian(db);
                        break;
                    case 4:
                        CommonCountry(db);
                        break;
                    case 5:
                        TopTenWithL(db);
                        break;
                    case 6:
                        SameLetter(db);
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        if (menuChoise < 0 || menuChoise > 7)
                        {
                            Console.WriteLine("Felaktig siffra. Ange en siffra mellan 1 och 6");
                        }
                        break;
                }
                Helper.BackToMenu();
            }
        }

        //Hur många olika länder finns representerade?

        private static void DistinctCountries(DatabaseConnection db)
        {
            Helper.Question("Hur många olika länder finns representerade?");

            var queryCountry = "SELECT count (distinct country) from MOCK_DATA";
            var dtCountry = db.GetDataTable(queryCountry);

            foreach (DataRow item in dtCountry.Rows)
            {
                Console.WriteLine(item[0]);
            }
        }

        // Är alla username och password unika?

        private static void UniqueValues(DatabaseConnection db)
        {
            Helper.Question("Är alla username och password unika?");

            var queryUsername = "SELECT count (distinct username) from MOCK_DATA";
            var dtUsername = db.GetDataTable(queryUsername);

            var queryPassword = "SELECT count (distinct password) from MOCK_DATA";
            var dtPassword = db.GetDataTable(queryPassword);


            foreach (DataRow item in dtUsername.Rows)
            {

                foreach (DataRow item2 in dtPassword.Rows)
                {

                    if (item[0].ToString() == "1000" && item2[0].ToString() == "1000")
                    {
                        Console.WriteLine("Alla username och password är unika");
                    }
                    else Console.WriteLine($"Alla usernames är inte unika. Det finns {item[0]} unika username och {item2[0]} unika password");
                }
            }
        }

        // Hur många är från Norden respektive Skandinavien?

        private static void NordicVsScandinavian(DatabaseConnection db)
        {
            Helper.Question("Hur många är från Norden respektive Skandinavien?");

            var queryScandinavia = "SELECT count(country) from MOCK_DATA WHERE country IN('Denmark', 'Sweden', 'Norway')";
            var dtScandinavia = db.GetDataTable(queryScandinavia);


            foreach (DataRow item in dtScandinavia.Rows)
            {

                var queryNordic = "select count(country) from MOCK_DATA where country IN('Denmark', 'Sweden', 'Norway', 'Finland', 'Iceland', 'Greenland', 'The Faroe Islands')";
                var dtNordic = db.GetDataTable(queryNordic);


                foreach (DataRow item2 in dtNordic.Rows)
                {
                    Console.WriteLine($"Det finns {item[0]} personer från Scandinavien och {item2[0]} personer från Norden");
                }

            }
        }


        // Vilket är det vanligaste landet?

        private static void CommonCountry(DatabaseConnection db)
        {
            Helper.Question("Vilket är det vanligaste landet?");

            var queryPopulation = "SELECT TOP 1 COUNT(Id) as amount, country FROM MOCK_DATA GROUP BY country ORDER BY amount desc";
            var dtPopulation = db.GetDataTable(queryPopulation);


            foreach (DataRow item in dtPopulation.Rows)
            {
                Console.WriteLine($"Det vanligaste landet är {item[1]} som återkommer {item[0]} gånger");
            }

        }


        //Lista de 10 första användarna vars efternamn börjar på bokstaven L

        private static void TopTenWithL(DatabaseConnection db)
        {

            Helper.Question("Lista de 10 första användarna vars efternamn börjar på bokstaven L");

            var queryTopTen = "select top 10 * from MOCK_DATA where last_name like 'L%' order by last_name asc";
            var dtTopTen = db.GetDataTable(queryTopTen);


            foreach (DataRow item in dtTopTen.Rows)
            {
                Console.WriteLine($"{item[1]} {item[2]}");
            }

        }


        // Visa alla användare vars för- och efternamn har samma begynnelsebokstav(ex Peter Parker, Bruce Banner, Janis Joplin)

        private static void SameLetter(DatabaseConnection db)
        {
            Helper.Question("Visa alla användare vars för- och efternamn har samma begynnelsebokstav");

            var querySameLetter = "select first_name, last_name from MOCK_DATA where left(first_name,1) = left(last_name,1) order by first_name asc";
            var dtSameLetter = db.GetDataTable(querySameLetter);


            foreach (DataRow item in dtSameLetter.Rows)
            {
                Console.WriteLine($"{item[0]} {item[1]}");
            }
        }

    }
}

