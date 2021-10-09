// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace EnumDemo
{
    using System;

    using EnumDemo.Enums;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en dag (1-7)");
            string input = Console.ReadLine();
            int.TryParse(input, out int day);
            // Skriv ut dagen
            Console.WriteLine((Veckodagar)day);
        }
    }
}
