using System.Collections.Generic;

namespace Inlämning2byDB.Models
{
    public class ViewPerson
    {
        public Person Person { get; set; }
        public List<Person> Children { get; set; }
    }
}
