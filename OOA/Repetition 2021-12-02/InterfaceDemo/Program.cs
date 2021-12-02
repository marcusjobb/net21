namespace InterfaceDemo
{
    using System;

    using InterfaceDemo.Interfaces;
    using InterfaceDemo.Models;

    internal class Program
    {
        static void Main(string[] args)
        {
            object person = new Person() {Name="James Bond", Birth=DateTime.Parse("April 13, 1968") };
            Console.WriteLine(person is Person);
            Console.WriteLine(person is IHasAge);

            var personObj = (Person)person;
            var ageObj = (IHasAge)person;
            var nameObj = (IHasName)person;
            var back = (Person)nameObj;

            Console.WriteLine(personObj.Name);
            Console.WriteLine(ageObj.Age);
            Console.WriteLine(nameObj.Name);
            Console.WriteLine(back.Name);
        }
    }
}
