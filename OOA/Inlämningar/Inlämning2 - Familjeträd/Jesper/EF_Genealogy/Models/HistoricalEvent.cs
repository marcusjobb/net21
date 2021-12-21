using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Genealogy.Models
{
    
    public class HistoricalEvent
    {
        public int ID { get; set; }

        public int? EventDate { get; set; }
        public string EventDescription { get; set; }


        public Person EventPerson { get; set; }

        public Place EventLocation { get; set; }
    }
}
