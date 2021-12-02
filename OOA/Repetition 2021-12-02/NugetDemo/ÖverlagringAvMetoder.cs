using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetDemo
{
    public class ÖverlagringAvMetoder
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public ÖverlagringAvMetoder()
        {

        }
        public ÖverlagringAvMetoder(int age)
        {
            Age = age;
        }

        public ÖverlagringAvMetoder(DateTime birth)
        {
            Age = (int)((DateTime.Now - birth).TotalDays / 365.25);
        }

        public ÖverlagringAvMetoder(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public void ChangePerson(int age)
        {
            Age = age;
        }

        public void ChangePerson(int age, string name = "")
        {
            Age = age;
            if (name != "") Name = name;
        }

        public void ChangePerson(string name)
        {
            Name = name;
        }
    }
}
