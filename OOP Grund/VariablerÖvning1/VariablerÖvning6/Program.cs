// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace VariablerÖvning6
{
    using System;

    /* Pseudokod:
     * 
     * Definiera C, F, och K
     * Tilldela värde till C och beräkna F och K
     * Skriv ut resultatet
     * 
     * Tilldela värde till F och beräkna C och K
     * Skriv ut resultatet
     * 
     * Tilldela värde till K och beräkna C och K
     * Skriv ut resultatet
     */

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ange celsius");
            var input = Console.ReadLine();
            double celcius = double.Parse(input);
            double fahrenheit = celcius * 1.8 + 32;
            double kelvin = celcius + 273.15;

            Console.WriteLine("A");
            Console.WriteLine("Celcius    :" + Math.Round(celcius, 2));
            Console.WriteLine("Fahrenheit :" + Math.Round(fahrenheit, 2));
            Console.WriteLine("Kelvin     :" + Math.Round(kelvin, 2));
            Console.WriteLine();

            fahrenheit = double.Parse(input);
            celcius = (fahrenheit - 32) / 1.8;
            kelvin = (fahrenheit + 459.67) / 1.8;

            Console.WriteLine("B");
            Console.WriteLine("Celcius    :" + Math.Round(celcius, 2));
            Console.WriteLine("Fahrenheit :" + Math.Round(fahrenheit, 2));
            Console.WriteLine("Kelvin     :" + Math.Round(kelvin, 2));
            Console.WriteLine();

            kelvin = double.Parse(input);
            celcius = kelvin - 273.15;
            fahrenheit = kelvin * 1.8 - 456.67;
            Console.WriteLine("C");
            Console.WriteLine("Celcius    :" + Math.Round(celcius, 2));
            Console.WriteLine("Fahrenheit :" + Math.Round(fahrenheit, 2));
            Console.WriteLine("Kelvin     :" + Math.Round(kelvin, 2));
            Console.WriteLine();
        }
    }
}
