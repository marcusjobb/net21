namespace EF_minimal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using EF_minimal.Models;

    using Microsoft.EntityFrameworkCore;

    internal class Program
    {
        static void Main()
        {
            using (var db = new Database.MinimalDB())
            {
                Console.Write("Enter name:");
                var name = Console.ReadLine();
                Console.WriteLine("Enter age:");
                var ageString = Console.ReadLine();
                int.TryParse(ageString, out var age);

                // Anropar metoden för att spara informationen
                SkapaPerson(db, name, age);
            }

            var test=new List<Person>();
            var t = new Person();
            t.Name = "Marcus";
            t.Age = 51;
            test.Add(t);
        }

        /// <summary>
        /// Skapar en person i databasen.
        /// </summary>
        /// <param name="db">Databascontext.</param>
        /// <param name="name">Namnet som ska skapas.</param>
        /// <param name="age">Ålder på personen.</param>
        /// <returns>Returnerar true om allt gått bra.</returns>
        private static bool SkapaPerson(Database.MinimalDB db, string name, int age)
        {
            var p = new Person();
            p.Name = name;
            p.Age = age;
            db.People.Add(p);
            db.SaveChanges();
            return true;
        }
    }
}
