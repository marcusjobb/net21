using EF_inlämning_2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_inlämning_2.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int FatherId { get; set; }
        public int MotherId { get; set; }
  
       
    }
}
