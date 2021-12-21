// -----------------------------------------------------------------------------------------------
//  BaseTest.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
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

    class B : A
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
            // Instansierar A, sedan B och slutligen C.
            // Då C ärver B och B ärver A
            var test = new C();
            // Skriver ut C B A då base anropas
            Console.WriteLine(test);
        }
    }
}