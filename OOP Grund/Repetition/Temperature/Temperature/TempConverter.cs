// -----------------------------------------------------------------------------------------------
//  TempConverter.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Temperature
{
    internal class TempConverter
    {

        // F = °C * 1.8 +32
        // K = °C + 273.15
        // För att omvandla från och till Celcius, Fahrenheit och Kelvin
        // https://www.wikihow.com/Convert-Between-Fahrenheit%2C-Celsius%2C-and-Kelvin


        public double CelciusToFahrenheit(double celcius)
        {
            double fahrenheit = celcius * 1.8 + 32;
            return fahrenheit;
        }

        public double CelciusToKelvin(double celcius)
        {
            double kelvin = celcius + 273.15;
            return kelvin;
        }


    }
}