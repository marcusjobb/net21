using System;
using System.Threading;

namespace Oh_Fortuna
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabler.
            int userPix = 500; // Antal Pix du startar med.
            int userBet = 0;
            int userLuckyNum;
            int number = 0;
            int dice;
            Random rnd = new Random();

            // Välkommen.
            Console.WriteLine("+---------------------------------------------+");
            Console.WriteLine("| WELCOME TO OH FORTUNA MADE MY DENNIS BYBERG |");
            Console.WriteLine("+---------------------------------------------+");

            // Ange ditt användarnamn för ett mer personligt spelande.
            Console.Write("Please choose your username: ");
            string userName = Console.ReadLine();
            Console.Clear();
            Console.Write($"Hi {userName}! Lets get started!\n\nLoading.");
            Thread.Sleep(1500);
            Console.Write(".");
            Thread.Sleep(1500);
            Console.Write(".");
            Thread.Sleep(1500);
            Console.Write(".");
            Console.Clear();


            while (userPix >= 50)
            {
                // Anger hur mycket vi vill betta.
                if (userBet == 0)
                {
                    Console.WriteLine($"How many Pix do you want to bet? | Pix Available: {userPix} |");
                    int.TryParse(Console.ReadLine(), out userBet);
                }

                if (userBet > userPix)
                {
                    Console.WriteLine("You don't have enough Pix.");
                    userBet = 0;
                    continue;
                }

                if (userBet < 50)
                {
                    Console.WriteLine("You must bet atleast 50 Pix");
                    userBet = 0;
                    continue;
                }

                // Ange ditt nummer du vill spela på.
                Console.WriteLine("\nPick your lucky number between (1-6)?");
                int.TryParse(Console.ReadLine(), out userLuckyNum);

                if (userLuckyNum > 6 || userLuckyNum < 1)
                {
                    Console.WriteLine("Invalid Answer!");
                    continue;
                }

                Console.Write("\nThrowing dices.");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".\n");

                userPix -= userBet;

                // Tärningar kastas och slumpas.
                for (int i = 0; i < 3; i++)
                {
                    dice = rnd.Next(1, 7);
                    Console.WriteLine("+-----------+");
                    Console.WriteLine("|DICE #{0}: {1} |", i + 1, dice);
                    Console.WriteLine("+-----------+");

                    if (dice == userLuckyNum)
                    {
                        number++;
                    }
                }

                // Skriver ut till konsollen om vi har RÄTT.
                if (number > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nice throw " + userName + "!\nYou got {0} correct guess(es)! You win {1} pix!", number, (number + 1) * userBet);
                    userPix += (number + 1) * userBet;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // Skriver ut till konsollen om vi har FEL. 
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry " + userName + "!\nNo correct guesses this time!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                // Antal Pix vi har att spela för.
                Console.WriteLine($"\n| Pix Available: {userPix} |");

                number = 0;
                userBet = 0;

                // Frågar om vi vill spela igen.
                if (userPix > 50)
                {
                    Console.WriteLine("Do you want to play again? (y/n)");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer == "y")
                    {
                        Console.Clear();
                        continue;
                    }
                    else if (userAnswer == "n")
                    {
                        Console.WriteLine($"Thanks for playing {userName}!");
                        Thread.Sleep(2000);
                        break;
                    }

                    // Skriver ut och avslutar programmet om användaren har mindre än 50 Pix.
                    if (userPix < 50)
                    {
                        Console.WriteLine("\nYou dont have enought Pix left to play!");
                        Console.WriteLine($"Thanks for playing my game {userName} and have a nice day!");
                        Thread.Sleep(2000);
                    }
                    break;
                }
            }
        }
    }
}