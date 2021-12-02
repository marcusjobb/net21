namespace Abstracts
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new List<AbstractPerson>
            {
                new Person { Name = "Kalle", BirthDate = new DateTime(1992, 12, 12), PhoneNr = "11111" },
                new Worker { Name = "Johan", BirthDate = new DateTime(1982, 1, 2), PhoneNr = "222222" }
            };

            foreach (var person in people)
            {
                person.Read();
                person.PrintPerson();
                person.Save();
            }
        }


    }
}
