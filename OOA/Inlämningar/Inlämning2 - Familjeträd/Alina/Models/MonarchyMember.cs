using Genealogy_Tree.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogy_Tree.Models
{
    public class MonarchyMember
    {
        [Key]
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthDate { get; set; }
        public int DeathDate { get; set; }

        public virtual ICollection<MonarchyMember>? Parents { get; set; }

        public virtual Monarchy Monarchy { get; set; }

        public virtual ICollection<MonarchyMember>? Children { get; set; }
    }

    public class Monarchy
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<MonarchyMember> Members { get; set; }
    }
}
