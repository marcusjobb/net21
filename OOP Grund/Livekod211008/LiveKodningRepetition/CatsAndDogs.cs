// -----------------------------------------------------------------------------------------------
//   by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
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
            List<Animal> animals = new()
            {
                new Cat { Name = "Bombalurina", Age = 5 },
                new Dog { Name = "Rover", Age = 7 }
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.Talk();
            }
        }
    }
}