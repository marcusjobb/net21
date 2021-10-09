// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Balls_demo
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            // Bollens position
            int x = 120 / 2;
            int y = 28 / 2;
            // Riktning bollen rör sig i
            int dirX = 1;
            int dirY = 1;
            // Gränser för bollens rörelser
            int maxX = 119;
            int maxY = 28;
            int minX = 1;
            int minY = 1;
            // Färg-räknare 
            int colorCounter = 0;
            // Färgens riktning
            int dirColor = 1;
            // Symbol som ska ritas ut
            char symbol = '.';

            // Göm pekaren
            Console.CursorVisible = false;
            
            // Loopa för evigt
            while (true)
            {
                // Ändra bollens position enligt riktning
                x += dirX;
                y += dirY;
                // Om bollen är utanför gränsen ändra riktning
                if (x > maxX || x < minX)
                {
                    dirX = -dirX;
                    continue;
                }
                if (y > maxY || y < minY)
                {
                    dirY = -dirY;
                    continue;
                }
                // Ta nästa färg
                colorCounter += dirColor;
                // Om färgen är för hög eller för låg, ändra riktning på färgen
                if (colorCounter > 2 || colorCounter < 1)
                {
                    dirColor = -dirColor;
                }

                // Sätt färg på texten som ska skrivas på skärmen
                Console.ForegroundColor = (ConsoleColor)colorCounter;
                // Placera bollen i x,y position
                Console.SetCursorPosition(x, y); Console.Write(symbol);
                //Console.SetCursorPosition(maxX-x, y); Console.Write(' ');
                //Console.SetCursorPosition(x, maxY-y); Console.Write(' ');
                Console.SetCursorPosition(maxX - x, maxY - y); Console.Write(symbol);
                // Släpp igenom windows trådar så att datorn inte låser sig
                Thread.Sleep(15);
                //Console.SetCursorPosition(x, y); Console.Write(" ");
                //Console.SetCursorPosition(maxX - x, y); Console.Write(" ");
                //Console.SetCursorPosition(x, maxY - y); Console.Write(" ");
                //Console.SetCursorPosition(maxX - x, maxY - y); Console.Write(" ");
            }
        }
    }
}
