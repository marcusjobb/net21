// -----------------------------------------------------------------------------------------------
//  Person.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Inlämning2Demo
{
    using System;

    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }

        public void Print()
        {
            Console.WriteLine("Name        :" + Name);
            Console.WriteLine("Last Name   :" + Name);
            Console.WriteLine("Alias       :" + Name);
        }
    }
}