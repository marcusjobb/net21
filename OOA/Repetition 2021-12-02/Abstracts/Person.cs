using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracts
{
    public class Person : AbstractPerson
    {
        // Läs från Json, Databas, Nätet whatever
        public override void Read() => Console.WriteLine("Json read");
        
        // Spara till Json, Databas, Nätet whatever
        public override void Save() => Console.WriteLine("Json save");
    }

    public class Worker : AbstractPerson
    {
        // Läs från Json, Databas, Nätet whatever
        public override void Read() => Console.WriteLine("DB read");

        // Spara till Json, Databas, Nätet whatever
        public override void Save() => Console.WriteLine("DB save");
    }
}
