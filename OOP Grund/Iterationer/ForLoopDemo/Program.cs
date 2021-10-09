// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace ForLoopDemo
{
    class Program
    {
        static void Main()
        {
            for (int counter = 10; counter > 0; counter--)
            {
                if (counter == 4) continue;
                Console.WriteLine(counter);
            }
        }
    }
}
