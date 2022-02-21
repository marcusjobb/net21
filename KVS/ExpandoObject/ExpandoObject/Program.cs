// See https://aka.ms/new-console-template for more information
using System.Dynamic;

Console.WriteLine("Hello, Expando!");

dynamic person = new ExpandoObject();
person.Name = "Clark";
person.Lastname = "Kent";

Console.WriteLine(person.Name+" "+person.LastName);
