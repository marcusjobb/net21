﻿// -----------------------------------------------------------------------------------------------
//  MetoderRepetition.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Livekod210924
{
    using System;
    using System.Collections.Generic;

    using Livekod210924.Extensions;

    public class MetoderRepetition
    {
        // Deklarera
        private int MaxValue = 100;
        private int _minValue = 0; // Gammaldags
        private const int MiddleValue = 10; // Denna får inte ändras under körningen

        public void Start()
        {
            // Deklarera
            int number1 = 10;
            int number2 = 15;

            // Kontrollera
            if (number1 > number2)
            {
                Swap(ref number1, ref number2);
            }

            // Använd data
            SayHello("Hello World");
            Console.WriteLine(GetSum(number1, number2));
            new string[] { "Hejsan", "Hoppsan" }.PrintArray();
            Console.WriteLine();
            PrintArrayExtra("----------", "Hello", "World", "From Net21", "----------");
            new List<string> { "Hejsan", "Hoppsan", "Tralalalaaa" }.PrintArray();

        }

        private void PrintArrayExtra(params string[] rows)
        {
            rows.PrintArray();
        }

        /// <summary>
        /// Byter plats på nummer1 och nummer2.
        /// </summary>
        /// <param name="number1">Ett nummer.</param>
        /// <param name="number2">Ett nummer.</param>
        private static void Swap(ref int number1, ref int number2)
        {
            // Deklarerar
            int temp = number1;
            // Använd data
            number1 = number2;
            number2 = temp;
        }

        internal string[] GetArray()
        {
            return new string[] { "Hello", "World" };
        }

        internal List<string> GetList()
        {
            return new List<string> { "Hello", "World" };
        }
        private int GetSum(int number1, int number2)
        {
            return number1 + number2;
        }

        private void SayHello(string message)
        {
            // Presentera data
            Console.WriteLine(message);
        }
    }
}