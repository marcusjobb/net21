﻿// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace Övning_5a___Boll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            // Bollens position
            int bollX = 10;
            int bollY = 10;

            // Bollens riktning / hastighet
            int bollXH = -1;
            int bollYH = 1;

            // Skärmgränser
            int maxX = 110;
            int maxY = 24;
            int minX = 1;
            int minY = 1;
            while (true)
            {

                bollX += bollXH;
                bollY += bollYH;

                if (bollX >= maxX)
                {
                    bollXH = -bollXH;
                    continue;
                }
                if (bollY >= maxY)
                {
                    bollYH = -bollYH;
                    continue;
                }

                if (bollY < minY)
                {
                    bollYH = -bollYH;
                    continue;
                }

                if (bollX < minX)
                {
                    bollXH = -bollXH;
                    continue;
                }

                Console.SetCursorPosition(bollX, bollY);
                Console.WriteLine(".---.");
                Console.SetCursorPosition(bollX, bollY + 1);
                Console.WriteLine("'---'");
                System.Threading.Thread.Sleep(50);
                Console.SetCursorPosition(bollX, bollY);
                Console.WriteLine("     ");
                Console.SetCursorPosition(bollX, bollY + 1);
                Console.WriteLine("     ");
            }


        }
    }
}
