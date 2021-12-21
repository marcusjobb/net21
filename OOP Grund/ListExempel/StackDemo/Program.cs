// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace StackDemo
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string[] tmp = new string[]
            {
                "Skutta runt",
                "Dansa salsa",
                "Kolla mailen",
                "Svara på mail",
                "Lyssna på musik"
            };

            Stack<string> stack = new(tmp);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Peek " + stack.Peek());
            Console.WriteLine("Pull " + stack.Pop());
            Console.WriteLine("Pull " + stack.Pop());
        }
    }
}
