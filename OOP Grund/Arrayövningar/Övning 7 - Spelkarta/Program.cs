﻿namespace Övning_7___Spelkarta
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // defieniera gränsvärden
            // const gör att värderna inte går att ändra i under
            // programkörning
            const int MaxWidth = 90;
            const int MaxHeight = 10;
            const int MaxScreenWidth = 117;
            const int InputColumn = 19;
            // instansiera randomizer
            Random rnd = new Random();

            // skapa array
            int[,] map = new int[MaxHeight, MaxWidth];

            // evig loop
            while (true)
            {
                // placera cursorn under kartans position
                Console.SetCursorPosition(0, MaxHeight + 2);
                // skriv frågorna
                Console.WriteLine("Ange X koordinat :");
                Console.WriteLine("Ange Y koordinat :");
                // sätt cursor och fråga 1
                Console.SetCursorPosition(InputColumn, MaxHeight + 2);
                string xInput = Console.ReadLine();
                // sätt cursor och fråga 2
                Console.SetCursorPosition(InputColumn, MaxHeight + 3);
                string yInput = Console.ReadLine();

                // Rensa skärmen
                Console.Clear();
                // rita ram-överdel
                Console.WriteLine("+" + new string('-', MaxScreenWidth - 2) + "+");
                // omvandla talen från string till int
                int.TryParse(xInput, out int x);
                int.TryParse(yInput, out int y);
                // kolla så att talen inte är för stora
                if (x >= MaxWidth) x = MaxWidth - 1;
                if (y >= MaxHeight) y = MaxHeight - 1;
                // sätt en etta i kartan
                map[y, x] = 1;

                // loopa raderna
                for (int ypos = 0; ypos < MaxHeight; ypos++)
                {
                    // skriv ut ram
                    Console.SetCursorPosition(0, ypos + 1);
                    Console.WriteLine("|" + new string(' ', MaxScreenWidth - 2) + "|");
                    // loopa kolumner
                    for (int xpos = 0; xpos < MaxWidth; xpos++)
                    {
                        // om det finns en etta, skriv ut den på vald position
                        if (map[ypos, xpos] == 1)
                        {
                            // addera ett för att inte skriva över ramen
                            Console.SetCursorPosition(xpos + 1, ypos + 1);
                            Console.Write("X");
                        }
                    }
                }
                // skriv ut ram-nederdel
                Console.SetCursorPosition(0, MaxHeight + 1);
                Console.WriteLine("+" + new string('-', MaxScreenWidth - 2) + "+");
            }
        }
    }
}