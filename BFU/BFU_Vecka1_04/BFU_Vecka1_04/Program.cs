// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace BFU_Vecka1_04
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter din favoritsuperhjälte");
            string hero = Console.ReadLine();
            Console.WriteLine(hero + " är super cool!");
        }

        //static string Input(string text)
        //{
        //    Console.WriteLine(text);
        //    string input = Console.ReadLine();
        //    return input;
        //}
    }
}
