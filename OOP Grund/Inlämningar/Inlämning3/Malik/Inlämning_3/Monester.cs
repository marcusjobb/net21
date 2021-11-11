using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_3
{
    class Monester
    {
        public string Name { get; set; } 
    }

    class SpecificMonster: Monester
    {
        public int Exp { get; set; }
        public int Hp { get; set; }
        public int Power { get; set; }
    }
}
