// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace BFU_Vecka1_08
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            bool answer = true;
            Console.Write("Är du smart? (j/n)");
            string input = Console.ReadLine().ToUpper();

            if (input[0] == 'J') //första bokstaven
                answer = true;
            else
                answer = false;

            Console.WriteLine(answer);
        }
    }
}
