using Genealogi.Data;
using Genealogi.Models;

namespace Genealogi.ViewModels
{
    public class EditViewModel
    {
        public List<String> ParentOptions { get; set; } = new() { "* Create new parent *", "* No Parent *" };
        public List<Person> AllPeople { get; set; } = new();
        public Person Person { get; set; }
        public EditViewModel(List<Person> people, Person person)
        {
            Person = person;
            AllPeople = people;

            foreach(var option in AllPeople)
            {
                ParentOptions.Add(option.Name + " " + option.LastName);
            }
        }

        public EditViewModel()
        {
            ParentOptions = new();
            AllPeople = new();
            Person = new Person();
        }
    }
}
