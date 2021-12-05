using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Project1_JosefinPersson
{
    class Menu
    {
        public void mainMenu()
        {
            bool run = true;

            while (run)
            {
                Console.WriteLine("Ange ett nummeralternativ för att få svar på frågor om människorna i tabellen!");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("1) Hur många länder finns representerade?");
                Console.WriteLine("2) Är alla username och password unika?");
                Console.WriteLine("3) Hur många är från Norden respektive Skandinavien?");
                Console.WriteLine("4) Vilket är det vanligaste landet?");
                Console.WriteLine("5) Lista de 10 första användarna vars efternamn börjar på bokstaven L.");
                Console.WriteLine("6) Visa alla användare vars för- och efternamn har samma begynnelsebokstav.");
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("7) Avsluta programmet");

                string userInput = Console.ReadLine();
                int input = 0;
                int.TryParse(userInput, out input);

                var sql = "";
                
                switch (input)
                {
                    case 1:
                        sql = "SELECT COUNT(DISTINCT country) FROM MOCK_DATA";  
                        var dt = Helper.GetDataTable(sql);  

                        Helper.PrintRow(dt);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:                                                                 
                        sql = "SELECT DISTINCT username FROM MOCK_DATA";
                        dt = Helper.GetDataTable(sql); 

                        if (dt.Rows.Count == 1000)
                        {
                            Console.WriteLine("Alla användarnamn är unika!");
                        }
                        else Console.WriteLine("Alla användarnamn är INTE unika!");

                        sql = "SELECT DISTINCT password FROM MOCK_DATA";
                        dt = Helper.GetDataTable(sql);  

                        if (dt.Rows.Count == 1000)
                        {
                            Console.WriteLine("Alla lösenord är unika!");
                        }
                        else Console.WriteLine("Alla lösenord är INTE unika!");

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:                                                               
                        Console.WriteLine("Tillhörande Norden:"); 
                        sql = "SELECT COUNT(country) FROM MOCK_DATA WHERE country = 'Sweden' OR country = 'Denmark' OR country = 'Finland' OR country = 'Norway' OR country = 'Iceland' OR country = 'Greenland' OR country = 'Faroe Islands' OR country = 'Åland Islands'";
                        dt = Helper.GetDataTable(sql);  

                        Helper.PrintRow(dt);

                        Console.WriteLine("Tillhörande Skandinavien:");
                        sql = "SELECT COUNT(country) FROM MOCK_DATA WHERE country = 'Sweden' OR country = 'Denmark' OR country = 'Norway'";
                        dt = Helper.GetDataTable(sql);

                        Helper.PrintRow(dt);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:                                                                   
                        sql = "SELECT TOP 1 country, COUNT(country) AS value_occurrence FROM MOCK_DATA GROUP BY country ORDER BY value_occurrence DESC;";
                        dt = Helper.GetDataTable(sql);   

                        Helper.PrintRow(dt);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        sql = "SELECT top 10 last_name FROM MOCK_DATA WHERE last_name LIKE @param";
                        dt = Helper.GetDataTable(sql, "@param", "L%"); // Lade till en @param här. Osäker på om jag kanske borde gjort det på alla SQL-strängar för security?
                                                                       // Bestämde mig för att inte göra det då programmet utgörs av redan färdiga frågor
                                                                       // och därför inte kommer ta emot en eventuellt skadlig input från användaren(?).

                        Helper.PrintRow(dt);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        sql = "SELECT first_name, last_name FROM MOCK_DATA WHERE UPPER(LEFT(first_name, 1)) = UPPER(LEFT(last_name, 1))";
                        dt = Helper.GetDataTable(sql);  

                        Helper.PrintRow(dt);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Ange en siffra mellan 1-7.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
