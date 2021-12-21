// -----------------------------------------------------------------------------------------------
//  PeopleHandler.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Inlämning2Demo
{
    using System.Collections.Generic;

    internal class PeopleHandler
    {
        //-------------------------------------------------------------------------------------------------
        // Skapa en lista med People
        //-------------------------------------------------------------------------------------------------
        private List<Person> people = new();

        // [C]RUDL
        public void Create(Person person)
        {
            people.Add(person);
        }

        // CRU[D]L
        public void Delete(Person person)
        {
            people.Remove(person);
        }

        // CRUD[L]
        public List<Person> List()
        {
            return people;
        }

        // C[R]UDL
        public Person Read(string name)
        {
            foreach (var person in people)
            {
                if (person.Name.ToLower() == name.ToLower()) return person;
            }
            return null;
        }

        // CR[U]DL
        public void Update(Person personA, Person personB)
        {
            for (var i = 0; i < people.Count; i++)
            {
                var person = people[i];
                if (person.Name == personA.Name && person.LastName == personA.LastName && person.Alias == personA.Alias)
                    {
                        people[i] = personB;
                        break;
                    }
                }
            }
        }
    }
}