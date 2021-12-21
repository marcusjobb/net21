using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Genealogy.Models
{
    // TODO: Fix so it maps properly
    public class Spouse
    {
        [Key]
        public int ID { get; set; }

        public Person SpouseX { get; set; }

        //public Person SpouseX { get; set; }

        //public Person SpouseY { get; set; }

    }
}
