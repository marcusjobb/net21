using System;
using System.Collections.Generic;
using System.Linq;

namespace Inlämningsuppgift_Tärningar
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Start game press any key or press N to exit");
                char answer = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (answer == 'N'||answer == 'n')
                {
                    Console.WriteLine("Okey have a nice day press enter to exit");
                    Console.ReadLine();
                    break;
                }


                int Saldo = 500;
                Console.WriteLine($"Your saldo is: {Saldo} pix");

                while (Saldo > 50)
                {
                    Console.WriteLine("Do you want to play a round press any key or press N to exit");
                    char anotherRound = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (anotherRound == 'N' || anotherRound == 'n')
                    {
                        Console.WriteLine("Okey thanks for playing, press enter to exit");
                        Console.ReadLine();
                        return;
                    }
                    int bet;

                    while (true)
                    {
                        Console.WriteLine("How much do you want to bet? Min 50 pix");
                        while (!int.TryParse(Console.ReadLine(), out bet))
                        {
                            Console.WriteLine("Your bet is not a valid bet!");
                        }

                        if (bet < 50)
                        {
                            Console.WriteLine("Your bet is insufficient!");
                            continue;
                        }

                        if (bet > Saldo)
                        {
                            Console.WriteLine("You dont have the amount of Pix to place bet");
                            continue;
                        }
                        break;
                    }
           
                    Console.WriteLine("Choose a lucky number");

                    int luckyNumber;

                    while (true)
                    {
                        Console.WriteLine("Please choose a number between 1-6");

                        while (!int.TryParse(Console.ReadLine(), out luckyNumber))
                        {
                            Console.WriteLine("Choose right number");
                        }
                        if (luckyNumber > 0 && luckyNumber < 7)
                        {
                            break;
                        }
                    }

                    List<int> dices = new List<int>();

                    Random rnd = new Random();
                    dices.Add(rnd.Next(1, 7));
                    dices.Add(rnd.Next(1, 7));
                    dices.Add(rnd.Next(1, 7));

                    if (dices.Count(d => d == luckyNumber) == 3)
                    {
                        Saldo += bet * 4;
                        Console.WriteLine("You got three hits! You now got: " + Saldo + " pix");
                        continue;
                    }

                    if (dices.Count(d => d == luckyNumber) == 2)
                    {
                        Saldo += bet * 3;
                        Console.WriteLine("You got two hits! You now got: " + Saldo + " pix");
                        continue;
                    }

                    if (dices.Count(d => d == luckyNumber) == 1)
                    {
                        Saldo += bet * 2;
                        Console.WriteLine("You got one hit! You now got: " + Saldo + " pix");
                        continue;
                    }

                    Saldo -= bet;
                    Console.WriteLine("You got no hits! You now got: " + Saldo + " pix");

                    if (Saldo < 50 )
                    {
                        Console.WriteLine("You have insufficient amount of pix!");
                    }
                }
            }
        }
    }
}
