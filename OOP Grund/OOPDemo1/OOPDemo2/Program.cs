// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace OOPDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLifetime cl = new ClassLifetime();

            cl.Value = 200;
            Console.WriteLine("value is " + cl.Value);

            Console.ReadLine();
        }
    }
}
