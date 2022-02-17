// See https://aka.ms/new-console-template for more information
using moqDB_demo.Data;
using moqDB_demo.Models;
Console.WriteLine("Hello, EF!");

var db = new CatsContext();
db.MyCats.Add(new Cat { Id = 1, Name = "Mr Meow", Colour = "Black" });

