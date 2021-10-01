using System;

namespace Inlämningsuppgift1._1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //hur mycket pengar man börjar med.
            int saldo = 500;
            // hur många tärningar. St står för styckna
            int Tarningar = 3;
            //talet användaren skriver in
            int tal = 0;
            //samma tal tärningar
            int matchtal = 0;
            // använder den var för att hålla kolla på hur mycket BET ska ut delas
            int BET = 0;
            // använder den för att senare kunna avsluta programet och annat
            bool firstTime = true;
            // denna är för när jag frågar om de vi spela igen
            string again;
            // Denna är för att tärningarna ska vara slumpmämisga
            Random rnd = new Random();

            Console.WriteLine("Välkommen till Fortuna spelautomat. \n\nDu har: {0} kr", saldo);
            while (saldo >= 50)
            {
                if (!firstTime)
                {
                    // Frågar om användaren vill spela igen
                    Console.Write("\nspela igen? Mata in (ja) eller (nej): ");
                    again = Console.ReadLine();

                    if (again == "nej")
                    {
                        Console.WriteLine("Välkommen åter!");
                        break;
                    }
                    else if (again == "ja")
                    {
                        Console.Clear();
                        Console.WriteLine("\nDu har :{0} kr", saldo);
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt svar");
                        continue;
                    }
                }
                //för att det inte ska frågas igen och igen

                if (BET <= saldo)
                {
                    Console.WriteLine("\nDu får minst satsa 50 kr.");
                    Console.WriteLine("Hur mycket vill du satsa?");
                    int.TryParse(Console.ReadLine(), out BET);
                }

                // om de försöker överrstiga gränsen
                if (BET > saldo)
                {
                    Console.WriteLine("\nDu kan inte satsa mer än vad du har.\n");
                    BET = 0;
                    continue;
                }
                // om de försöker understiga gränsen
                else if (BET < 50)
                {
                    Console.WriteLine("Du får minst satsa 50 kr\n");
                    BET = 0;
                    continue;
                }

                //här får användare välja ett tal
                Console.WriteLine("\nVälj ett tal mellan 1 och 6?");
                int.TryParse(Console.ReadLine(), out tal);

                // om det väljer fel siffra
                if (tal > 6 || tal < 1)
                {
                    Console.WriteLine("Ogiltigt svar \n");

                    continue;
                }

                saldo -= BET;

                //här visar jag hur det ska se ut när tärningar ska kastas
                for (int i = 0; i < 3; i++)
                {
                    Tarningar = rnd.Next(1, 7);
                    Console.WriteLine("\nTärning: " + (i + 1) + " ger: " + Tarningar);
                    if (tal == Tarningar)
                    {
                        matchtal++;
                    }
                }
                // det är här man jag räknar hur mycket pengar de ska få
                if (matchtal > 0)
                {
                    Console.WriteLine("\nDu vann: ", matchtal, (1 + matchtal) * BET + "kr");
                    saldo += (1 + matchtal) * BET;
                }
                else
                {
                    Console.WriteLine("\nDu gissa fel");
                }
                Console.WriteLine("\nSaldo: {0} Du gissa rätt: {1} kr", saldo, matchtal);

                matchtal = 0;
                BET = 0;
                firstTime = false;

                if (saldo < 50)
                {
                    Console.WriteLine("För lite pengar välkomen åter");
                    break;
                }
            }
        }
    }
}