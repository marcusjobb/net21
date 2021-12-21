using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public BirthPlace BirthPlace { get; set; }
        public string BirthDate { get; set; }

        public DeathPlace DeathPlace { get; set; }
        public string DeathDate { get; set; }

        public int? MotherId { get; set; }

        public int? FatherId { get; set; }

        public override string ToString() => FirstName + " " +
                                 LastName;
    }
}