// -----------------------------------------------------------------------------------------------
//  PeopleHandler.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Inlämning2Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Linq;

    class PeopleHandler
    {
        private List<Person> people = new();

        // CRUDL
        public void Create(Person person)
        {
            people.Add(person);
        }

        public Person Read(string name)
        {
            foreach (var person in people)
            {
                if (person.Name.ToLower() == name.ToLower()) return person;
            }
            return null;
        }

        public void Update(Person personA, Person personB)
        {
            for (var i = 0; i < people.Count; i++)
            {
                var person = people[i];
                if (person.Name == personA.Name)
                {
                    if (person.LastName == personA.LastName)
                    {
                        if (person.Alias == personA.Alias)
                        {
                            people[i] = personB;
                            break;
                        }
                    }
                }
            }
        }

        public void Delete(Person person)
        {
            people.Remove(person);
        }

        public List<Person> List()
        {
            return people;
        }


    }
}
