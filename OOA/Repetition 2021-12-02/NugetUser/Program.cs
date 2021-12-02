namespace NugetUser
{
    using System;
    using System.Collections.Generic;

    using NugetDemo;

    using static NugetDemo.Calculator;
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            //var talk = new Talker();
            //talk.SayHello();

            var hello = new StaticStuff();
            hello.Name = "Bruce";
            StaticStuff.LastName = "Banner";
            hello.SayHelloAgain();

            var hello2 = new StaticStuff();
            hello2.SayHelloAgain();

            // Vanliga metoder anropas via instans
            hello.SayHelloAgain();

            hello.Name = "Clark";

            // Vanliga metoder anropas via instans
            hello.SayHelloAgain();

            // Statiska metoder anropas via klassnamn
            StaticStuff.SayHello();

            // personobjekt med static
            List<Person> Heroes = new()
            {
                new Person("Bruce", "Banner", 46), // Hulk
                new Person("Clark", "Kent", 25), // Superman
                new Person("Oliver", "Quinn", 27), // Green Arrow
                new Person("Bruce", "Wayne", 18), // Green Arrow
            };

            foreach (var hero in Heroes)
            {
                WriteLine($"{Person.Name} {hero.LastName} {hero.Age}");
            }

            // Överlagring Av Metoder
            var over = new ÖverlagringAvMetoder(51,"Marcus");
            over.ChangePerson(age:1);

            // Demo av using static namespace.class; (fungerar bara med statiska metoder)
            var add = Add(10, 10);
            WriteLine(add);

            var p2 = new Person2 { Birth = new DateTime(1991, 11, 19),Name= "Mr Spookie" };
            WriteLine(p2.Age);
            WriteLine(p2.AgeInMonths);
            WriteLine(p2.AgeInDays);

            var def = new PropertyMess("Pekka");
            def.Name = "Johan";

            Clear();
            //var c = new TryCatchDemo();
            //c.Crash();

            Console.WriteLine(def);
            Clear();

            var parent = new ParentClass();
            parent.Value = 2;
            Console.WriteLine(parent.MultiplyWithX());

            var child = new ChildClass();
            child.Value = 3;
            child.SetMultiplyer(10);
            Console.WriteLine(child.MultiplyWithX());
            Console.WriteLine(child.AddWithX());

        }
    }
}
