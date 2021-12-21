using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2_Tiia
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int? MotherId { get; set; }
        public int? FatherId { get; set; }

        public override string ToString() => FirstName + " " + LastName;

    }  
}
