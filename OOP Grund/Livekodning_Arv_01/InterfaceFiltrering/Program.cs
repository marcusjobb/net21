namespace InterfaceFiltrering
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            var human = new Human() { Name = "James Woods", Age = 150 };
            List< INameAble> names = new ()
            {
                human,
                new Pet() { Name = "Wolfie", Race="Dog"},
            };


            //foreach (var item in names)
            //{
            //    Console.WriteLine(item.Name);
            //    if (item is IAgeAble) Console.WriteLine(((IAgeAble)item).Age);
            //    if (item is IAgeAble) Console.WriteLine(item.Name+" has age");
            //}

            PrintNames(names);
            // OfType plockar ut alla som matchar det interface eller klass man söker i listan
            PrintAge(names.OfType<IAgeAble>().ToList());
        }

        private static void PrintNames(List<INameAble> names)
        {
            foreach (var item in names)
            {
                Console.Write(item.Name + " is ");
                Console.WriteLine(item.GetType());
            }
        }

        private static void PrintAge(List<IAgeAble> names)
        {
            foreach (var item in names)
            {
                Console.Write("has age " + item.Age);
            }
        }
    }
}
