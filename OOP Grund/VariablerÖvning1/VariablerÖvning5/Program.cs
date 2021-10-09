// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace VariablerÖvning5
{
    using System;

    /* Pseudokod:
     * 
     * Definiera rain
     * Definiera willRain
     * Definiera needUmbrella = Om det regnar eller kommer att regna
     * Skriv ut resultat
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            bool rain = false;
            bool willRain = true;
            bool needUmbrella = rain || willRain;

            Console.WriteLine("Behöver jag paraply? " + needUmbrella);
        }
    }
}
