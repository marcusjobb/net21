// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace Inlämning2Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ph = new PeopleHandler();
            var person = new Person { Name = "Marcus", LastName = "Medina", Alias = "Marmed" };
            var cheryl = new Person { Name = "Cheryl", LastName = "Mason", Alias = "Cheryl" };
            ph.Create(person);
            ph.Create(cheryl);

            PrintList(ph);

            Console.WriteLine();
            var heather = new Person { Name = "Heather", LastName = "Morris", Alias = "Heather" };
            ph.Update(cheryl, heather);

            //PrintList(ph);

            //var deleteThis = new Person { Name = "Heather", LastName = "Morris", Alias = "Heather" };
            var deleteThis = ph.Read("Heather");
            Console.WriteLine("Heather:" + heather.GetHashCode());
            Console.WriteLine("Delete:" + deleteThis.GetHashCode());

            ph.Delete(deleteThis);
            PrintList(ph);
        }

        private static void PrintList(PeopleHandler ph)
        {
            foreach (var contact in ph.List())
            {
                Console.WriteLine(contact.Name + " " + contact.LastName + " " + contact.Alias);
            }
        }
    }
}