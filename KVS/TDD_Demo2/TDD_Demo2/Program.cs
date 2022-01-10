// See https://aka.ms/new-console-template for more information
using TDD_Demo2;

Console.WriteLine("Menu");
Console.WriteLine("1 - List people in database");
Console.WriteLine("2 - List people from specific city");
Console.WriteLine("3 - List people older than 55");
var x = ConsoleHelper.GetInt(min:0, max:3);
Console.WriteLine("You chose " + x);
