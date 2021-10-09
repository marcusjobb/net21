// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace VariablerÖvning1
{
    using System;

    /* Pseudokod:
     * 
     * Deklarera a,b,c
     * Beräkna omkrets: a+b+c
     * Beräkna ara: (kortaste sidorna)
     * Skriv ut omkrets
     * Skriv ut area
     */

    class Program
    {
        static void Main(string[] args)
        {
            //hej hej
            // Definiera
            // Hej

            float sidaA = 3.5f;
            float sidaB = 2.4f;
            float sidaC = 2.2f;


            // Bearbeta
            float omkrets = sidaA + sidaB + sidaC;
            float area = sidaB * sidaC;

            // Presentera
            Console.WriteLine("Omkretsen är " + omkrets);
            Console.WriteLine("Arean är " + area);

        }
    }
}
