namespace LinqFTW
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person(){Name="Barbara Gordon", Age=18},
                new Person(){Name="Clark Kent", Age=32},
                new Person(){Name="Bruce Wayne", Age=45},
                new Person(){Name="Bruce Banner", Age=32},
                new Person(){Name="Lois Lane", Age=34},
                new Person(){Name="Lana Lang", Age=30},
            };

            Console.WriteLine("FirstOrDefault / Find");
            //var searchOne = people.Find(p=>p.Name.Contains("Bruce"));
            var searchOne = (from p in people
                             where p.Name.Contains("Bruce")
                             select p)
                             .FirstOrDefault();
            PrintPerson(searchOne);

            Console.WriteLine("\nWhere");
            //var searchMany = people.Where(p => p.Name.Contains("Bruce")).ToList();
            var searchMany = (from p in people
                              where p.Name.Contains("Bruce")
                              select p).ToList();
            PrintPeople(searchMany);

            Console.WriteLine("\nWhere (is person)");
            //var searchMany = people.Where(p => p.Name.Contains("Bruce")).ToList();
            searchMany = (from p in people
                              where p is Person
                              select p).ToList<Person>();
            PrintPeople(searchMany);

            Console.WriteLine("\nOrderBy");
            searchMany = (from p in people
                          orderby p.Name
                          select p).ToList();
            PrintPeople(searchMany);

            Console.WriteLine("\nOrderByDesc");
            searchMany = (from p in people
                          orderby p.Name descending
                          select p).ToList();

            searchMany = people.OrderByDescending(x => x.Name).ToList();
            PrintPeople(searchMany);

        }

        private static void PrintPerson(Person person)
        {
            Console.WriteLine(person.Name + " " + person.Age);
        }

        private static void PrintPeople(List<Person> search)
        {
            for (var i = 0; i < search.Count; i++)
            {
                var person = search[i];
                Console.WriteLine((i + 1) + " " + person.Name + " " + person.Age);
            }
        }
    }
}
