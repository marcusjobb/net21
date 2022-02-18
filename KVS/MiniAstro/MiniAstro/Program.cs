// See https://aka.ms/new-console-template for more information
using MiniAstro;

Console.WriteLine("Hello, World!");

var mini = new MiniAstrology();
Console.WriteLine("Marcus         : " + mini.GetAstroSign(6, 20));
Console.WriteLine("Michael Jordan : " + mini.GetAstroSign(2, 17));
Console.WriteLine("Johnny Depp    : " + mini.GetAstroSign(6, 9));
Console.WriteLine("Amber Heard    : " + mini.GetAstroSign(4, 22));
Console.WriteLine("Rachel McAdams : " + mini.GetAstroSign(11, 17));
Console.WriteLine("Adam Sandler   : " + mini.GetAstroSign(9, 9));

