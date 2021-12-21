using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Models
{
    public class BirthPlace
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public List<Person> People { get; set;} //"äger" flera personer
    }
}
