// -----------------------------------------------------------------------------------------------
//   by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKodningRepetition
{
    using System;

    internal class NestledLoop
    {
        internal void Start()
        {
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (y > 0 && y < 9) // Om det är första eller sista raden
                        if (x == 0 || x == 9) 
                            Console.Write("X"); 
                        else 
                            Console.Write(".");
                    else
                        Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    }
}