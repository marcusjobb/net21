// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            TempConverter temp = new TempConverter();
            string input = "";
            double celcius = 0;
            do
            {
                Console.WriteLine("Ange temperaturen i Celcius");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out celcius));

            double fahrenheit = temp.CelciusToFahrenheit(celcius);
            double kelvin = temp.CelciusToKelvin(celcius);
            Console.WriteLine(celcius + " grader i Celcius är " + fahrenheit + " grader i Fahrenheit");
            Console.WriteLine(celcius + " grader i Celcius är " + kelvin + " grader i Kelvin");

            // Du har en klass som omvandlar
            // Celcius till Fahrenheit
            // Celcius till Kelvin

            // Gör nu så att den ska omvandla åt andra hållet
            // Fahrenheit till Celcius
            // Fahrenheit till Kelvin
            // Kelvin till Celcius
            // Kelvin till Fahrenheit

        }
    }
}
