namespace SQL.Inlämning
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("______________________________________________________________________________");
            Console.WriteLine("|                                                                            |");
            Console.WriteLine("|                                  MENU                                      |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[1]- How many countries are represented?                                    |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[2]- Are all usernames and passwords unique?                                |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[3]- How many are from the north respectively from scandinavia?             |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[4]- Whats the most common country in this database?                        |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[5]- List the top 10 users whose name starts with L                         |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[6]- List all the users whose firstname and lastname starts with same letter|");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.WriteLine("|[7]-                              Exit                                      |");
            Console.WriteLine("|____________________________________________________________________________|");
            Console.Write("\r\nEnter Choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    GetCountries.Countries();
                    return;

                case "2":
                    GetDistinctPasswordsAndUsername.PasswordsAndUsername();
                    return;

                case "3":
                    GetFromTheNorthAndScandinavia.TheNorthAndScandinavia();
                    return;

                case "4":
                    GetMostCommonCountry.CommonCountry();
                    return;

                case "5":
                    GetTopTenUsers.TopTenUsers();
                    return;

                case "6":
                    GetUserWithSameLetter.SameLetter();
                    return;

                case "7":
                    Environment.Exit(0);
                    return;
            }
        }

        public static void NextQs()
        {
            Console.WriteLine("\n[Press enter to continue]");
            Console.ReadLine();
            Console.Clear();
            MainMenu();
        }
    }
}