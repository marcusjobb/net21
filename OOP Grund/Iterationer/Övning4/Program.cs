// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace Övning4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Vad heter du? ");
            string name = Console.ReadLine();
            foreach (char bokstav in name)
            {
                Console.WriteLine(bokstav);
            }
        }
    }
}
