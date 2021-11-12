// -----------------------------------------------------------------------------------------------
//   by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace LinqLive1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class PeopleCrud
    {
        private List<Person> People = new();

        public PeopleCrud()
        {
            People.AddRange(new Person[]
            {
                new Person{FirstName="Isaak", LastName="Asimov Clone", Age=53},
                new Person{FirstName="Leonard", LastName="Nimoy", Age=45},
                new Person{FirstName="Ernst", LastName="Hemingway", Age=23},
                new Person{FirstName="Isaac", LastName="Asimov", Age=53},
            });
        }

        internal void List()
        {
            People = People.OrderByDescending(p => p.Age).OrderBy(p => p.Age).ToList();
            People.ForEach(p => Console.WriteLine(p.FirstName + " " + p.LastName + " " + p.Age));
        }
    }
}