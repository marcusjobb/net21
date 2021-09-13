namespace BankDemo
{
    using System;

    class Program
    {
        static void Main()
        {
            // Deklarera nödvändiga variabler
            string userName = "";
            string account = "";
            double cash = 0;

            Title("Snedbank");

            do
            {
                // Fråga om pinkod
                string pincode = AskAQuestion("Ange din Pinkod: ");

                // Kontrollera pinkod
                if (pincode == "1337")
                {
                    userName = "Mr Leet";
                    account = "2672347-324";
                    cash = 50000.32;
                }
                else
                {
                    Console.WriteLine("Fel pinkod!");
                }
            } while (account == "");

            Status(userName, account, cash);

            int menuChoice = 0;
            while (menuChoice < 1 || menuChoice > 3)
            {
                menuChoice = MainMenu();

            }

            // Insättning
            if (menuChoice == 1)
            {
                Title("Insättning");

                double deposit = AskForCash("Hur mycket pengar vill du sätta in? ", 10000);
                cash = ModifyAccount(cash, deposit);
                Status(userName, account, cash);

                //string input = AskAQuestion("Hur mycket pengar vill du sätta in?");
                //double.TryParse(input, out double deposit);
                //if (deposit > 0)
                //{
                //    cash += deposit;
                //    Console.WriteLine("Saldo: " + cash);
                //}
                //else
                //{
                //    Console.WriteLine("Du angav ett negativt värde!");
                //}
            }
            // Uttag
            if (menuChoice == 2)
            {
                Title("Uttag");
                double withdraw = AskForCash("Hur mycket pengar vill du ta ut?", cash);
                cash = ModifyAccount(cash, -withdraw);
                Status(userName, account, cash);

                //string input = AskAQuestion("Hur mycket pengar vill du ta ut?");
                //double.TryParse(input, out double withdraw);
                //if (withdraw > cash)
                //{
                //    Console.WriteLine("Du har inte så mycket pengar!");
                //}
                //else if (withdraw < 0)
                //{
                //    Console.WriteLine("Du angav ett negativt värde!");
                //}
                //else
                //{
                //    cash -= withdraw;
                //    Console.WriteLine("Saldo: " + cash);
                //}
            }
        }

        private static void Status(string userName, string account, double cash)
        {
            // Presentera information
            Console.Clear();
            Title("Konto:");
            Console.WriteLine("Namn   :" + userName);
            Console.WriteLine("Konto  :" + account);
            Console.WriteLine("Saldo  :" + cash);
        }

        private static int MainMenu()
        {
            int menuChoice;
            Title(" - Meny -");
            Console.WriteLine(" 1) Insättning");
            Console.WriteLine(" 2) Uttag");
            Console.WriteLine(" 3) Logga ut");

            int.TryParse(AskAQuestion("Ditt val:"), out menuChoice);
            return menuChoice;
        }

        private static double ModifyAccount(double cash, double deposit)
        {
            cash += deposit;
            Console.WriteLine("Saldo : " + cash);
            return cash;
        }

        static string AskAQuestion(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();
            return input;
        }

        static void Title(string title)
        {
            Console.WriteLine("+------------------------------------+");
            Console.WriteLine("| " + title.ToUpper());
            Console.WriteLine("+------------------------------------+");
        }
        static double AskForCash(string question, double maxValue)
        {
            string input = AskAQuestion(question);
            double.TryParse(input, out double value);

            if (value < 0)
            {
                Console.WriteLine("Du angav ett negativt värde");
                value = 0;
            }
            if (value > maxValue)
            {
                Console.WriteLine("Du angav ett för stort värde");
                value = 0;
            }
            return value;
        }
    }
}
