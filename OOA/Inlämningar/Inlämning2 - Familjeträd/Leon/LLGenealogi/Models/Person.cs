using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLGenealogi.Models
{
    public class Person
    {
        // PK. Använd [Key] när Id inte heter Id eller inte slutar på Id
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public int Mor { get; set; }
        public int Far { get; set; }
    }
}
