﻿// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace WhileDemo
{
    class Program
    {
        static void Main()
        {
            //int value = 0;
            //while (value<110)
            //{
            //    Console.SetCursorPosition(value,10);
            //    Console.WriteLine("*");
            //    value++;
            //    Thread.Sleep(100);
            //}

            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Skriv lösenordet:");
                string input = Console.ReadLine();
                isValid = (input == "abc123");
            }


        }
    }
}
