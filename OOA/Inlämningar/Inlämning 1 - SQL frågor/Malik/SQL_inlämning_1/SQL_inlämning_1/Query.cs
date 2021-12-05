using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_inlämning_1
{
    class Query
    {
        public void NumOfCountries()
        {
            var db = new SqlDatabase();

            var query = db.GetDataTable("SELECT COUNT  (DISTINCT country) as Countries FROM MLK_DATA;");

            foreach (DataRow item in query.Rows)
            {
                Console.WriteLine($"There are [{item[0]}] different countries in my darabase.");
            }

            BackToMenu();
        }

        public void passAndUserName()
        {
            var db = new SqlDatabase();

            var userquery = db.GetDataTable("SELECT COUNT(id) FROM MLK_DATA GROUP BY username ORDER BY COUNT(id) DESC;");
            var passquery = db.GetDataTable("SELECT COUNT(id) FROM MLK_DATA GROUP BY password ORDER BY COUNT(id) DESC;");

            int i=0;

            foreach (DataRow item in userquery.Rows)
            {
                Int32.TryParse(item[0].ToString(), out i);

                if (i > 1)
                {
                    Console.WriteLine($"We have {i} persons who have the same Username");
                    break;
                }
            }

            if (i < 2) Console.WriteLine("All the usernames are different. They are unique");

            foreach (DataRow item in passquery.Rows)
            {
                Int32.TryParse(item[0].ToString(), out i);

                if (i > 1)
                {
                    Console.WriteLine($"We have {i} persons who have the same password");
                    break;
                }
            }

            if (i < 2) Console.WriteLine("All the passwords are different. They are unique");

            BackToMenu();
        }

        public void theNorthCountries()
        {
            var db = new SqlDatabase();

            var query = db.GetDataTable("SELECT country, COUNT(id) as count FROM MLK_DATA WHERE Country IN ('Sweden', 'Denmark', 'Norway', 'Finland', 'Iceland') GROUP BY country ORDER BY COUNT(id) DESC;");

            foreach (DataRow item in query.Rows)
            {
                Console.WriteLine($"\t {item[0]} \t: {item[1]}");
            }

            BackToMenu();
        }

        public void mostCountry()
        {
            var db = new SqlDatabase();

            var query = db.GetDataTable("SELECT country, COUNT(id) as count FROM MLK_DATA GROUP BY country ORDER BY COUNT(id) DESC;");

            foreach (DataRow item in query.Rows)
            {
                Console.WriteLine($"The most common country is [{item[0]}]");
                break;
            }

            BackToMenu();
        }

        public void top10Users()
        {
            var db = new SqlDatabase();

            var query = db.GetDataTable("SELECT TOP 10 * FROM MLK_DATA WHERE last_name LIKE 'L%';");

            Console.WriteLine("The first 10 users whose last name starts with the letter L : ");
            foreach (DataRow item in query.Rows)
            {
                Console.WriteLine($"\t ID: {item[0]} \t First name: {item[1]} \t Last name: {item[2]}");
            }

            BackToMenu();
        }


        public void firstAndLastName()
        {
            var db = new SqlDatabase();

            var query = db.GetDataTable("SELECT id, first_name, last_name  FROM MLK_DATA WHERE LEFT (first_name, 1) = LEFT (last_name, 1)");

            foreach (DataRow item in query.Rows)
            {
                Console.WriteLine($"\t ID: {item[0]} \t First name: {item[1]} \t Last name: {item[2]}");

            }

            BackToMenu();
        }

        public void BackToMenu()
        {
            Console.WriteLine("Press Enter to return to the main menu");
            Console.ReadLine();

            Console.Clear();

            Menu();
        }

        public void Menu()
        {
            int Number;

            Console.WriteLine("\t Welcome to my database \n Here I have some information about database \n");
            Console.WriteLine("Select number from the following:[ ]");
            Console.WriteLine("[1] How many different countries are represented?");
            Console.WriteLine("[2] Är alla username och password unika?");
            Console.WriteLine("[3] How many country are from the Nordic countries and Scandinavia respectively?");
            Console.WriteLine("[4] Which is the most common country?");
            Console.WriteLine("[5] List the first 10 users whose last name starts with the letter L");
            Console.WriteLine("[6] Show all users whose first and last names have the same initials");
            Console.WriteLine("[7] To exit the program");


            Console.SetCursorPosition(34, 3);
            string inputA = Console.ReadLine();
            int.TryParse(inputA, out Number);

            while (Number < 1 || Number > 7)
            {
                Console.SetCursorPosition(0, 3);
                Console.Write("You have selected the wrong choice. Select service number again:[ ]");
                Console.SetCursorPosition(65, 3);
                string input = Console.ReadLine();
                int.TryParse(input, out Number);
            }

            Console.Clear();




            switch (Number)
            {
                case 1: NumOfCountries(); break;
                case 2: passAndUserName(); break;
                case 3: theNorthCountries(); break;
                case 4: mostCountry(); break;
                case 5: top10Users(); break;
                case 6: firstAndLastName(); break;
                default:
                    Console.WriteLine("Welcome back");
                    Environment.Exit(0); break;
            }
        }

    }
}
