// -----------------------------------------------------------------------------------------------
//  Person.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace MVCDemo.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
