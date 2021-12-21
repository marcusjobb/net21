// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace TernaryIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en nuffra");
            string input = Console.ReadLine();
            int value = 0;
            bool isOK = int.TryParse(input, out value);
            if (isOK)
            {
                string message = (value > 10 ? "Större än 10" : "Inte större än 10");
                Console.Write("Ditt värde är " + message);
            }
        }
    }
}
