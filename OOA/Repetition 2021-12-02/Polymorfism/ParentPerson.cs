using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    public class ParentPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ParentPerson()
        {
            Console.WriteLine("Parent was initialized");
        }
    }

}
