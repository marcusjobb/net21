﻿// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Fortuna
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            // Loop 1 - Spelet
            while (true)
            {
                Console.Clear();
                int bank = 500;
                Console.WriteLine("Ditt saldo är " + bank + " pix");
                int bet;
                string input;
                // Loop 2 - Hur mycket du vill satsa
                while (true)
                {
                    Console.Write("Hur mycket vill du satsa? ");
                    input = Console.ReadLine();
                    _ = int.TryParse(input, out bet);
                    if (bet < 50)
                    {
                        Console.WriteLine("Du valde för litet värde");
                    }
                    else if (bet > bank)
                    {
                        Console.WriteLine("Du har inte så mycket pix");
                    }
                    else
                    {
                        break;
                    }
                }

                int lucky;
                // Loop 2 - Vad är ditt lyckotal
                while (true)
                {
                    Console.Write("Vad är ditt lyckotal? ");
                    input = Console.ReadLine();
                    _ = int.TryParse(input, out lucky);
                    if (lucky < 1)
                    {
                        Console.WriteLine("Du valde för litet värde");
                    }
                    else if (lucky > 6)
                    {
                        Console.WriteLine("Du valde för stort värde");
                    }
                    else
                    {
                        break;
                    }
                }
                bank -= bet;
                Console.WriteLine("Kastar tärningar");
                Random rnd = new();
                int t1 = rnd.Next(1, 7);
                int t2 = rnd.Next(1, 7);
                int t3 = rnd.Next(1, 7);
                Console.WriteLine($"Tärning 1 {t1}");
                Console.WriteLine($"Tärning 2 {t2}");
                Console.WriteLine($"Tärning 3 {t3}");
                int multi = 0;
                if (t1 == lucky && t2 == lucky && t3 == lucky)
                {
                    multi = 4;
                }
                else if ((t1 == lucky && t2 == lucky) || (t2 == lucky && t3 == lucky))
                {
                    multi = 3;
                }
                else if (t1 == lucky || t2 == lucky || t3 == lucky)
                {
                    multi = 2;
                }

                if (multi > 0)
                {
                    Console.WriteLine("Du vann " + (bet * multi));
                    bank += bet * multi;
                }

                Console.WriteLine("Ditt saldo är nu " + bank);

                if (bank < 50)
                {
                    break;
                }
                Console.WriteLine("Vill du köra en runda till? ([J]/N)");
                input = Console.ReadLine();
                if (input != "j" && input != "J" && input != "")
                {
                    break;
                }
            }
        }
    }
}