// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            int div1 = 10;
            int div2 = 0;
            int silly = 0;
            List<string> data = null;

            try
            {
                data.Add("Test");

                // Try catch ska innehålla minimalt med kod
                silly = div1 / div2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Du försökte dela med 0");
                ex.LogThis();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Duh! Objektet är null");
                ex.LogThis();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Något gick fel");
                ex.LogThis();
            }
            finally // Rensa alla spåren för att inget mer ska bråka
            {
                data = null;
            }
        }

        static void VBExample() // Skräckexempel!!!
        {
            try
            {
                // All kod i metoden

            }
            catch
            {
                Console.WriteLine("Något gick fel!");
            }
        }
    }
}
