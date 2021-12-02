using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Interfaces
{
    // Talar om vad klassen ska ha för metod
    // Angivna metoder måste finnas
    // Den filtrerar objekt så att bara typen IhasAge syns (med linq)
    // Den filterar vilka egenskaper vi ser av objektet
    public interface IHasAge
    {
        DateTime Birth { get; set; }
        DateTime Death { get; set; }
        int Age
        {
            get
            {
                int age = 
                    Death != default 
                    ? (int)((Death - Birth).Days / 365.25) 
                    : (age = (int)((DateTime.Now - Birth).Days / 365.25));
                
                return age;
            }
        }
    }

    public interface IHasName
    {
        string Name { get; set; }
    }
}
