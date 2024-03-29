﻿// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Arrayövningar
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            // -------------------------------------------------------------------
            // Fråga efter namn
            // -------------------------------------------------------------------
            Console.WriteLine("Vad heter du?");

            // -------------------------------------------------------------------
            // Trim tar bort onödiga mellanslag i början och slutet av texten
            // -------------------------------------------------------------------
            string input = Console.ReadLine();
            input = input.Trim();
            while (input.Contains("  "))
            {
                input = input.Replace("  ", " ");
            }

            // -------------------------------------------------------------------
            // Skriver ut resultatet
            // -------------------------------------------------------------------
            Console.WriteLine("Namn : " + input);
            Console.WriteLine("Första bokstaven : " + input[0]);
            Console.WriteLine("Sista bokstaven : " + input[input.Length - 1]);
            // -------------------------------------------------------------------
            // Istället för att dra av ett från längden av strängen (eller arrayen)
            // Kan man skriva ^1
            // ^1 = Första bokstaven i slutet
            // -------------------------------------------------------------------
        }
    }
}