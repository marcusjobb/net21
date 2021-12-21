// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
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
