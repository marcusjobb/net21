// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace Övning1
{
    class Program
    {
        static void Main()
        {
            int memory = 0;
            int value = 0;
            // vi vet inte hur många gånger loopen ska köras
            while (value >= 0)
            {
                Console.Write("Ange ett värde:");
                string input = Console.ReadLine();
                int.TryParse(input, out value);
                memory += value;
            }
            Console.WriteLine("Sum is :" + memory);
        }
    }
}
