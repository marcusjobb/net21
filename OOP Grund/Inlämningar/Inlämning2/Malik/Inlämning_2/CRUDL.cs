using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlämning_2
{
    class CRUDL
    {
        private List<Person> people = new();

        //CRUDL

        public void Create(Person person)
        {
            people.Add(person);
        }


        public Person Read(string name)
        {
            foreach (var person in people)
            {
                if (person.Name.ToLower() == name.ToLower())
                
                    return person;
                
            }
            return null;
        }

        public void Update(string name, Person personB)
        {
            for (int i = 0; i < people.Count; i++)
            {
                var person = people[i];

                if (person.Name.ToLower() == name.ToLower())
                {
                    if (personB.Name != "")
                    {
                        people[i].Name = personB.Name;
                    }
                    
                    if (personB.Lastname != "")
                    {
                        people[i].Lastname = personB.Lastname;
                    }

                    if (personB.Alias != "")
                    {
                        people[i].Alias = personB.Alias;
                    }
                    break;
                }
            }
        }

        public void Delete(string removname)
        {
            foreach (var delete in people)
            {
                if (delete.Name.ToLower() == removname.ToLower())
                {
                    people.Remove(delete);
                    break;
                }
            }

        }

        public List<Person> List()
        {
            return people;
        }
    }
}
