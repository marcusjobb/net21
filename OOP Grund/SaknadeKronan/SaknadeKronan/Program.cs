// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace SaknadeKronan
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int bullar = 25; // pris
            int kalle = 10; // Cash
            int pelle = 10; // Cash
            int tjalle = 10;// Cash
            int rödaKorset = 0; // Donation

            Console.WriteLine($"Bullarna kostar {bullar}");
            Console.WriteLine($"Kalle har {kalle}");
            Console.WriteLine($"Pelle har {pelle}");
            Console.WriteLine($"Tjalle har {tjalle}");
            Console.WriteLine();

            Console.WriteLine($"De betalar {kalle + pelle + tjalle}");
            int kvarEfterKöp = (kalle + pelle + tjalle) - bullar;
            kalle -= 10;
            pelle -= 10;
            tjalle -= 10;
            Console.WriteLine($"Kalle har nu {kalle}");
            Console.WriteLine($"Pelle har nu {pelle}");
            Console.WriteLine($"Tjalle har nu {tjalle}");
            Console.WriteLine($"Och får tillbaka {kvarEfterKöp}");
            Console.WriteLine();

            Console.WriteLine($"De delar så att de får en krona var");
            kalle++;
            pelle++;
            tjalle++;
            kvarEfterKöp -= 3;
            rödaKorset += kvarEfterKöp;
            Console.WriteLine($"Kalle har nu {kalle}");
            Console.WriteLine($"Pelle har nu {pelle}");
            Console.WriteLine($"Tjalle har nu {tjalle}");
            Console.WriteLine($"Och donerar {kvarEfterKöp} till Röda korset");
            kvarEfterKöp = 0;
            Console.WriteLine();

            Console.WriteLine($"Summa summarum:");
            int utlägg = (10 - 1) * 3;
            Console.WriteLine($"De betalade 10-1 kronor var, alltså 9*3 = {utlägg}");
            Console.WriteLine($"och donerade 2 kronor");
            utlägg += 2;
            Console.WriteLine($"Summan blir: {utlägg}");
            if (utlägg != 30) Console.WriteLine($"Error 404: Krona not found");
        }
    }
}
