// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace BankDemo
{
    using System;

    class Program
    {
        // Deklarera nödvändiga variabler
        // Deklarar variablerna utanför metoden så att alla
        // metoder i klassen kan använda dem
        static string userName = "";
        static string account = "";
        static double cash = 0;
        static void Main()
        {

            Title("Snedbank");
            AskForPincode();

            int menuChoice = 0;
            while (menuChoice != 3)
            {
                Status(userName, account, cash);
                menuChoice = MainMenu();

                // Insättning
                if (menuChoice == 1) { Deposit(); }
                // Uttag
                if (menuChoice == 2) { Widthdraw(); }
            }
        }

        private static void Widthdraw()
        {
            Title("Uttag");
            double withdraw = AskForCash("Hur mycket pengar vill du ta ut?", cash);
            cash = ModifyAccount(cash, -withdraw);
        }

        private static void Deposit()
        {
            Title("Insättning");
            double deposit = AskForCash("Hur mycket pengar vill du sätta in? ", 10000);
            cash = ModifyAccount(cash, deposit);
        }

        private static void AskForPincode()
        {
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
            int menuChoice = 0;
            Title("Meny");
            Console.WriteLine(" 1) Insättning");
            Console.WriteLine(" 2) Uttag");
            Console.WriteLine(" 3) Logga ut");

            while (menuChoice < 1 || menuChoice > 3)
            {
                int.TryParse(AskAQuestion("Ditt val:"), out menuChoice);
            }
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
            return Console.ReadLine();
        }

        static void Title(string title)
        {
            Console.WriteLine("+------------------------------------+");
            Console.WriteLine("| " + title);
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
