using System;

namespace Fortuna_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 500;
            int bet = 0;
            string input;

            Console.WriteLine("Welcome to the Play and pay game!");

            Console.WriteLine("Your current balance is" + " " + balance + "pix");

            while (true)
            {
                Console.WriteLine("How much pix do you want to bet? (You need to bet minimum of 50pix)");
                input = Console.ReadLine();
                int.TryParse(input, out bet);

                if (bet < 50)
                {
                    Console.WriteLine("You choose a smaller amount!");
                }
                else if (bet > balance)
                {
                    Console.WriteLine("You dont have that much of amount!");
                }
                else
                {
                    break;
                }
            }

            int lucky;

            while (true)
            {
                Console.Write("Choose a lucky number between 1-6! ");
                input = Console.ReadLine();
                int.TryParse(input, out lucky);

                if (lucky < 1)
                {
                    Console.WriteLine("You choose a smaller number! Please choose a number between 1-6");
                }
                else if (lucky > 6)
                {
                    Console.WriteLine("You choose a large number! Please choose a number between 1-6");
                }
                else
                {
                    break;
                }
            }
                
            balance -= bet;

            Console.WriteLine("Throw a dice");

            Random TorseDice = new Random();

            int torse1 = TorseDice.Next(1, 7);
            int torse2 = TorseDice.Next(1, 7);
            int torse3 = TorseDice.Next(1, 7);

            Console.WriteLine($"Dice 1 {torse1}");
            Console.WriteLine($"Dice 2 {torse2}");
            Console.WriteLine($"Dice 3 {torse3}");

            int multi = 0;
            if (torse1 == lucky && torse2 == lucky && torse3 == lucky)
            {
                multi = 4;
            }
            else if ((torse1 == lucky && torse2 == lucky) || (torse2 == lucky && torse3 == lucky))
            {
                multi = 3;
            }
            else if (torse1 == lucky || torse2 == lucky || torse3 == lucky)
            {
                multi = 2;
            }

            if (multi > 0)
            {
                Console.WriteLine("You worn " + (bet * multi));
                balance += bet * multi;
            }

            Console.WriteLine("Your tolal balance is " + balance);

           
            if (balance < 50)
            {
                return;
            }
            Console.WriteLine("Will you play again?");
            string playAgain = Console.ReadLine();

            if (playAgain == "n")
            {
                Console.WriteLine("Thank you for playing!");            
            }
            else if (playAgain == "y")
            {
                Console.Clear();
            }
        }
    }
}
