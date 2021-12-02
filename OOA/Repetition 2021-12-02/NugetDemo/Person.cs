using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetDemo
{
    public class Person
    {
        public static string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
    }
}
