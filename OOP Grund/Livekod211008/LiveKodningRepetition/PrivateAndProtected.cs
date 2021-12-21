// -----------------------------------------------------------------------------------------------
//  PrivateAndProtected.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace LiveKodningRepetition
{
    using System;

    internal class Human
    {
        protected int age; // protected är som private men inte hemlig för arv
        public bool IsDead { get; set; } = false;
        public string Name { get; set; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0) return;
                IsDead = value > 120;
                age = value;
            }
        }
    }

    internal class Male : Human
    {
        public Male()
        {
            Name = "Kalle";
            age = 160; // Sätter värdet utan att använda property!
        }
    }

    internal class Female : Human
    {

    }

    internal class PrivateAndProtected
    {
        internal void Start()
        {
            Human man = new Male();
            Console.WriteLine(man.Age);
            Console.WriteLine(man.IsDead);
            Console.WriteLine();
            man.Age = 152; // Använder property
            Console.WriteLine(man.Age);
            Console.WriteLine(man.IsDead);
        }
    }
}