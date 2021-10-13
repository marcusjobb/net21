namespace ChatUpNameList.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ChatUpNameList.DTO;

    internal class ContactHelper
    {
        private readonly List<Person> People = new();

        public int Count { get => People.Count; }

        public void Add(Person person)
        {
            People.Add(person);
        }

        public void Delete(Person person)
        {
            People.Remove(person);
        }

        public void Delete(int pos)
        {
            People.RemoveAt(pos);
        }

        public void Update(Person personA, Person personB)
        {
            int pos = People.IndexOf(personA);
            if (pos == -1) return;
            People[pos] = personB;
        }

        public Person Find(string alias)
        {
            foreach (var person in People)
            {
                if (person.Alias.ToLower().Contains(alias.ToLower())) return person;
            }
            return null;
        }

        public Person Fetch(int pos)
        {
            return People[pos];
        }

        internal void BubbleSort()
        {
            bool hasChanged = true;
            while (hasChanged)
            {
                for (int i = 0; i < People.Count - 1; i++)
                {
                    hasChanged = false;
                    if (People[i].Lastname.CompareTo(People[i + 1].Lastname) > 0)
                    {
                        hasChanged = true;
                        var mem = People[i];
                        People[i] = People[i + 1];
                        People[i + 1] = mem;
                    }
                }
            }
        }
    }
}
