using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Genealogy.Models
{
    //TODO: Fix so it works properly
    public class Place
    {
        [Key]
        public int ID { get; set; }

        public string LocationName { get; set; }


        //public Person person { get; set; }
        //public ICollection<Person> People { get; set; }
        // Planet events for fun?
    }
}
