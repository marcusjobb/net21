using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetDemo
{
    public class Person2
    {
        public string Name { get; set; } = "Bruce Banner";
        public DateTime Birth { get; set; }
        public Person2()
        {
            Name = "Bruce Banner";
        }
        public int Age
        {
            get
            {
                return (int)((DateTime.Now - Birth).TotalDays / 365.25);
            }
        }
        public int AgeInMonths
        {
            get
            {
                return (int)((DateTime.Now - Birth).TotalDays / 30.4);
            }
        }
        public int AgeInDays
        {
            get
            {
                return (int)((DateTime.Now - Birth).TotalDays);
            }
        }

    }
}
