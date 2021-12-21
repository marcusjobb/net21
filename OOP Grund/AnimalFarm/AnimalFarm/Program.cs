// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace AnimalFarm
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Hyenna()  {Name = "Hihi" },
                new Horse()   {Name = "Gnägg" },
                new Cat()     {Name = "Mjau"},
                new Cat()     {Name = "Misse"},
                new Dog()     {Name = "Voffsing"},
                new Pegasus() {Name = "Cencen"},
                new Bird()    {Name = "Gull"}
            };

            //Dog hyenna = new Hyenna();
            //Cat hyenna = new Hyenna(); // funkar inte!!!
            //Animal hyenna2 = new Hyenna();

            foreach (Animal animal in animals)
            {
                if (animal is IHasWings)
                    Console.WriteLine(animal.Name + " has color " + animal.Colour);
            }

        }
    }
}
