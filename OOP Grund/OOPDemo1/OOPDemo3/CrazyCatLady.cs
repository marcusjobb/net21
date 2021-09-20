using System;
using System.Collections.Generic;
namespace OOPDemo3
{
    internal class CrazyCatLady
    {
        Cat[] morecats = new Cat[10];

        List<Cat> Cats = new List<Cat>(); // Namn i plural
        internal void Start()
        {
            Cat newCat = new Cat
            {
                Name = "Misse",
                Age = 5,
                Colour = "Orange"
            };
            Cats.Add(newCat);
            Cat anotherCat = new Cat { Name = "Bombalurina", Age = 10, Colour = "Svartvit" };
            Cats.Add(anotherCat);

            anotherCat.Name = "       RumpleTeaser"; // byter namn
            anotherCat.Colour = "GulOrange"; // byter färg

            Cat myCat = new Cat();
            myCat.Name = "Katt    ";
            myCat.Age = -5;
            myCat.Colour = "Svart";
            myCat.Age++;
            myCat.Name = "Sötis";

            Cats.Add(myCat);
            PrintCats();
        }

        private void PrintCats()
        {
            foreach (var cat in Cats)
            {
                PrintCat(cat);
            }
        }

        private void PrintCat(Cat cat)
        {
            Console.WriteLine("+-----------------------------------");
            Console.WriteLine("| Namn  :" + cat.Name + ".");
            Console.WriteLine("| Ålder :" + cat.Age + ".");
            Console.WriteLine("| Färg  :" + cat.Colour + ".");
            Console.WriteLine("+-----------------------------------");
        }
    }
}