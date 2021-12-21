using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string? DeathDate { get; set; }
        public int? Mother { get; set; }
        public int? Father { get; set; }

        public Person()
        {

        }
        public Person(string first, string last, string birth, string? death = null, int? mother = null, int? father = null)
        {
            FirstName = first;
            LastName = last;
            BirthDate = birth;
            DeathDate = death;
            Mother = mother;
            Father = father;
        }
    }
}
