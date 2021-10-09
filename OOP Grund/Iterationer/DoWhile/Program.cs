// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace DoWhile
{
    class Program
    {
        static void Main()
        {
            string password = "abc123";
            string input = "abc123";
            do
            {
                Console.WriteLine("Ange lösenord:");
                input = Console.ReadLine();
            } while (input != password);
        }
    }
}
