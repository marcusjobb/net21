using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetDemo
{
    public class ParentClass
    {
        protected int multiplyer = 2; // Private för alla utom arv
        public int Value { get; set; }
        public int MultiplyWithX()
        {
            return multiplyer * Value;
        }
        public void SetMultiplyer(int value)
        {
            multiplyer = value;
        }
        public int GetMultiplyer()
        {
            return multiplyer;
        }

    }

    public class ChildClass:ParentClass
    {
        public ChildClass()
        {
            multiplyer = 4;
        }
        public int AddWithX() => multiplyer * Value;
    }
}
