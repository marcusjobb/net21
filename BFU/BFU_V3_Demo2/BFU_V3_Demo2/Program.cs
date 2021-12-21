// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace BFU_V3_Demo2
{
    class Test
    {
        private int classValue = 1;
        public int Value
        {
            get
            {
                return classValue;
            }

            set
            {
                classValue = value;
            }
        }
        public Test(int input)
        {
            classValue = input;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test(5);
            Console.WriteLine(t.Value);
        }
    }
}
