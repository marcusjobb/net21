using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Genealogy.Models
{

    public class Person
    {
        //TODO: Birth location and homeplanet arent the same..

        [Key]
        public int ID { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }


        public string BirthDate { get; set; }
        public string DeathDate { get; set; }


        
        public int? MotherID { get; set; }
        
        public int? FatherID { get; set; }





        // TODO: Switched to string for a location instead of a location class. Fix if time?
        //public Place BirthLocation { get; set; }
        public string BirthLocation { get; set; }
        //public Place DeathLocation { get; set; }
        public string DeathLocation { get; set; }


        public List<HistoricalEvent> PersonHistory { get; set; }

        

        // TODO: Spouse added as int instead of a Spouse object. Fix if time?
        public int? SpouseID { get; set; }
        //public List<Spouse>? Spouses { get; set; }

    }
}
