// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Variabler_live //hus
{
    using System; // hus
    class Program // rum
    {
        static int TheAnswer = 42;
        static void Main() // möbel
        {
            //int kolumn = 50;
            //int rad = 10;
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.Clear(); // rensa skärmen
            //Console.SetCursorPosition(kolumn, rad);
            //Console.WriteLine("Hello");

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.BackgroundColor = ConsoleColor.DarkCyan;
            //Console.SetCursorPosition(kolumn, rad + 2);
            //Console.WriteLine("Hejsan svejsan");

            //Console.ReadLine(); // paus
            //Console.ResetColor();
            //Console.Clear(); // rensa skärmen

            // Grunddata
            int pelle = 8;
            int kalle = 12;
            string frukt = "bananer";

            // Bearbeta
            pelle += 2;
            kalle -= 2;
            int total = pelle + kalle;
            string apples = "Pelle har " + pelle + " " + frukt + " och Kalle har " + kalle;
            string totalText = "Tillsammans har de " + total + " " + frukt;

            // camelCase 

            // Presentera
            Console.WriteLine(apples);
            Console.WriteLine(totalText);
            Console.WriteLine("Svaret på allt " + TheAnswer);
        }
    }
}
