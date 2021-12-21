// -----------------------------------------------------------------------------------------------
//  CatsAndDogs.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace LiveKodningRepetition
{
    using System;
    using System.Collections.Generic;

    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Talk()
        {
            Console.WriteLine(":)");
        }
        public override string ToString()
        {
            return $"Hello my name is {Name} and I am {Age} years old.";
        }
    }

    internal class Cat : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Meow");
        }
    }

    internal class Dog : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Wooff");
        }
    }
    internal class CatsAndDogs
    {
        internal void Start()
        {
            // Alla djur kan finnas i Animal listan
            List<Animal> animals = new()
            {
                new Cat { Name = "Bombalurina", Age = 5 },
                new Dog { Name = "Rover", Age = 7 }
            };

            // Dock kan vi inte se specifika djuregenskaper utan bara de
            // egenskaper som tillhör Animal klassen och är gemensamma för
            // alla som ärver Animal
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.Talk();
            }
        }
    }
}