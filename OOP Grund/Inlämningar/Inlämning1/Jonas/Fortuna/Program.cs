using System;

namespace Fortuna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int pix = 500;
            int luckyNumber = 0;        // Engelska p.g.a blir nervös av åäö i var.
            int numberCorrect = 0;
            int bet = 0;
            int diceRoll = 0;
            const int diceSides = 6;
            const int numberRolls = 3;
            const int minimumBet = 50;
            const int minimumBalance = 50;
            string input = "";
            int[] winningsMultiplier = new int[] { 0, 2, 3, 4 };
            Random rnd = new Random();
            bool go_on = true;

            while (go_on)
            {
                numberCorrect = 0; // Reset  

                Console.WriteLine("Ange ditt lyckotal mellan 1 - " + diceSides);
                luckyNumber = InputPositiveInteger(1, diceSides);

                Console.WriteLine("Ange din insats (minst " + minimumBet + " pix, max " + pix + " pix)");

                bet = InputPositiveInteger(minimumBet, pix);

                for (int i = 1; i < (numberRolls + 1); i++)
                {
                    diceRoll = rnd.Next(1, (diceSides + 1));                         // +1 ty annars blir resultatet aldrig = diceSides. Det blir dock = 1. fattar inte varför
                    Console.WriteLine("Tärningskast " + i + " blev " + diceRoll);  // ^^^^ Jo, nu fattar jag.
                    if (diceRoll == luckyNumber)
                    {
                        numberCorrect++;
                    }

                }

                pix -= bet;
                Console.WriteLine("numberCorrect " + numberCorrect);

                pix += bet * winningsMultiplier[numberCorrect];
                Console.WriteLine("Du har " + pix + " pix");
                if (pix < minimumBalance)
                {
                    Console.WriteLine("Saldo för lågt. Socialstyrelsen har bestämt att du inte får spela mer");
                    go_on = false;
                }
                else
                {
                    do
                    {

                        Console.WriteLine("Avsluta? j/n ");
                        input = Console.ReadLine();
                        if (input == "j")
                        {
                            go_on = false;
                        }
                    } while (input != "n" && input != "j");
                }
            }
        }

        static int InputPositiveInteger(int min, int max)
        {
            bool finished = false;
            int returnMe = 0;
            do
            {
                string input = Console.ReadLine();
                finished = int.TryParse(input, out returnMe);
                if ((returnMe > max || returnMe < min) && finished == true)
                {
                    Console.WriteLine("Talet ej mellan " + min + " och " + max + " försök igen");
                    finished = false;
                }
                else if (finished == false)
                {
                    Console.WriteLine("Inmatningen förstås ej, försök igen");
                }

            } while (finished == false);
            return returnMe;
        }
    }
}







