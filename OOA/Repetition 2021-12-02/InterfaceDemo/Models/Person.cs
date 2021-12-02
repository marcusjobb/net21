using System;

using InterfaceDemo.Interfaces;

namespace InterfaceDemo.Models
{
    public class Person : IHasAge, IHasName
    {
        public DateTime Birth { get; set; }
        public DateTime Death { get; set; }
        public string Name { get; set; }
    }
}
