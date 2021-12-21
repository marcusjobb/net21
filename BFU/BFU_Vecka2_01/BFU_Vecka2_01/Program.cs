// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace BFU_Vecka2_01
{
    class Program
    {
        // Deklarera det som ska användas i hela klassen

        static void Main()
        {
            // Deklarera det som ska användas i hela metoden

            // Skapa ett program som har en variabel för biljettpris där vi lägger in 120. 
            double ticket = 120;

            // Inhämntning av data
            int age = 0;
            int month = 0;
            int hour = 0;

            while (age == 0)
            {
                Console.WriteLine("Hur gammal är du?");
                string input = Console.ReadLine();
                int.TryParse(input, out age);
            }

            while (month < 1 || month > 12)
            {
                Console.WriteLine("Vilken månad (1-12)?");
                string input = Console.ReadLine();
                int.TryParse(input, out month);
            }

            while (hour != 12 && hour != 14 && hour != 16 && hour != 18 && hour != 20 && hour != 22)
            {
                Console.WriteLine("Vilken föreställning (12,14,16,18,20 eller 22)?");
                string input = Console.ReadLine();
                int.TryParse(input, out hour);
            }

            // Bearbeta data

            // Mitt på dagen brukar det vara svårt att locka folk därför ger vi 30% rabatt om man har
            // bokad en föreställning som börjar innan klockan 16.
            if (hour < 16)
            {
                ticket *= 0.70; // Dra av 30%
            }
            // Den första rabatten gäller för barn under 12år, be användare mata in sin ålder i 
            // konsolen (konvertera på samma sätt som vi gjorde förra veckan) testa om åldern är
            // mindre än 12 genom en if-sats, i så fall ge dem en rabatt på 20% innan priset skrivs ut.
            // Vi ger också samma rabatt för personer som är 62 år eller äldre, så ändra din if-sats 
            // så att du kollar om personen är yngre än 12 eller är 62 eller äldre.
            else if (age < 12 || age >= 62)
            {
                ticket *= .80; // Dra av 20%
            }
            // Under sommaren har vi ett specialerbjudande, så be användaren mata in en månad när han/hon/hen 
            // vill boka sin biljett (Här kan du välja om du vill representera månaden som ett nummer eller en sträng) 
            // och om det är en sommarmånad så dra av 15%.
            else if (month == 6 || month == 7 || month == 8)
            {
                ticket *= 0.85; // Dra av 15%
            }

            // Presentera resultatet
            // När programmet körs skall ” Din biljett kostar 120kr” skrivas ut.
            Console.WriteLine($"Din biljett kostar {ticket}kr");
        }
    }
}