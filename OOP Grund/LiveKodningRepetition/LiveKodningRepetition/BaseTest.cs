// -----------------------------------------------------------------------------------------------
//   by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LiveKodningRepetition
{
    using System;

    class A
    {
        public A() // constructor
        {
            Console.WriteLine("A is initiated");
        }
        public override string ToString() => "A ";
    }

    class B :A
    {
        public B()
        {
            Console.WriteLine("B is initiated");
        }
        public override string ToString() => "B " + base.ToString();
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine("C is initiated");
        }
        public override string ToString() => "C " + base.ToString();
    }

    internal class BaseTest
    {
        internal void Start()
        {
            var test = new C();
            Console.WriteLine(test);
        }
    }
}