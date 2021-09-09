﻿namespace Övning_ADV_1___Bubbelsort
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // skapa array för 10 tal
            int[] numbers = new int[10];
            // Flagga för att se om arrayen ändrats
            // om den inte ändrats vid en iteration då är allt
            // sorterat
            bool changed;
            // Instansiera randomizer
            Random rnd = new Random();
            // lägg till slumpade värden i listan
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = rnd.Next(0, 100);
            }

            do
            {
                // nollställ flaggan 
                changed = false;
                // loopa igenom alla värden
                for (int pos = 0; pos < numbers.Length-1; pos++)
                {
                    // om värdet är större än nästa värde
                    if (numbers[pos]>numbers[pos+1])
                    {
                        // swap
                        int tmp = numbers[pos];
                        numbers[pos] = numbers[pos + 1];
                        numbers[pos + 1] = tmp;
                        changed = true;
                    }
                }
            } while (changed);
            // skriv ut alla talen
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
