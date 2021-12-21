using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarkFamily.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }

        [ForeignKey("Father")]
        public int? FatherId { get; set; }

        public virtual Person Father { get; set; }
        public virtual ICollection<Person> Children { get; set; }

        //[ForeignKey("Mother")]
        //public int? MotherId { get; set; }



        //public virtual Person Mother { get; set; }



    }
}
