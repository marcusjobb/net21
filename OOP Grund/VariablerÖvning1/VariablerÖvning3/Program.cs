// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace VariablerÖvning3
{
    using System;

    /* Pseudokod:
     * 
     * Deklarera namn
     * ta reda på namnets längd
     * Skriv ut längden
     */

    class Program
    {
        static void Main(string[] args)
        {
            string name = "Marcus Medina";
            int length = name.Length;
            Console.WriteLine(name + " är " + length + " bokstäver långt");
        }
    }
}
