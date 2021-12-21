using Genealogi.Models;

namespace Genealogi.ViewModels
{
    public class FamilyViewModel
    {
        public Person Person { get; set; }
        public IEnumerable<Person> Siblings { get; set;  }
        public IEnumerable<Person> Kids { get; set; }

        public FamilyViewModel(Person person, IEnumerable<Person> siblings, IEnumerable<Person> kids)
        {
            Person = person;
            Siblings = siblings;
            Kids = kids;
        }
    }
}
