using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetDemo
{
    public class PropertyMess
    {
        // Denna sätts först
        public string Name { get; set; } = "Kalle";
        // Set sätts sist

        private int age = 0;
        public int Age
        {
            get { return age; }
            set { if (value is > 0 and < 150) age = value; }
        }

        // Constructor sätts efteråt
        public PropertyMess(string name)
        {
            Name = name;
        }
    }
}
