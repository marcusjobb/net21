// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace Arrays_live
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 22;
            //int c = 32;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            int[] nuffror = new int[3];
            nuffror[0] = 10;
            nuffror[1] = 22;
            nuffror[2] = 32;

            // Redim  = Skapa en ny dimension

            int[] temp = new int[10];
            Array.Copy(nuffror, temp, nuffror.Length); // kopierar alla värden till en annan plats i minnet
            nuffror = temp; // nuffror finns nu på samma plats som temp i minnet

            nuffror[3] = 55;

            foreach (int nuffra in nuffror)
            {
                Console.WriteLine(nuffra);
            }

        }
    }
}
