// -----------------------------------------------------------------------------------------------
//  NestledLoop.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
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
                        if (x == 0 || x == 9) // Om det är första eller sista kolumnen
                            Console.Write("X"); // Skriv ut ett X
                        else
                            Console.Write("."); // Skriv ut en punkt
                    else
                        Console.Write("X");
                }
                Console.WriteLine();
            }

            // --------------------------------------------------------------------------------------------------

            Console.WriteLine("Alternativ lösning");
            const int maxWidth = 20;
            const int maxHeight = 10;
            for (int y = 0; y < maxHeight; y++)
            {
                for (int x = 0; x < maxWidth; x++)
                {
                    bool wall = (y == 0 || y == maxHeight-1) || (x == 0 || x == maxWidth-1);
                    if (wall)
                        Console.Write("X"); // Skriv ut ett X
                    else
                        Console.Write("."); // Skriv ut en punkt
                }
                Console.WriteLine();
            }
        }
    }
}