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
            double celcius = 17;

            double fahrenheit = celcius * 1.8 + 32;
            double kelvin = celcius + 273.15;

            Console.WriteLine("A");
            Console.WriteLine("Celcius    :" + Math.Round(celcius,2));
            Console.WriteLine("Fahrenheit :" + Math.Round(fahrenheit, 2));
            Console.WriteLine("Kelvin     :" + Math.Round(kelvin, 2));
            Console.WriteLine();

            fahrenheit = 52;
            celcius = (fahrenheit - 32) / 1.8;
            kelvin = (fahrenheit + 459.67) / 1.8;

            Console.WriteLine("B");
            Console.WriteLine("Celcius    :" + Math.Round(celcius, 2));
            Console.WriteLine("Fahrenheit :" + Math.Round(fahrenheit, 2));
            Console.WriteLine("Kelvin     :" + Math.Round(kelvin, 2));
            Console.WriteLine();

            kelvin = 300;
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
