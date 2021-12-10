// See https://aka.ms/new-console-template for more information
using SimpleFabric.Factories;
using SimpleFabric.Interfaces;

Console.WriteLine("Hello, World!");

var nThing = Factory.MakeAThing("Teddybear");
var uThing = Factory.MakeAnUglyThing("Teddy Bear");

Console.WriteLine(nThing.Name + " " + nThing.GetType());
Console.WriteLine(uThing.Name + " " + nThing.GetType());

PrintThing(Factory.MakeAThing("Doll"));
PrintThing(Factory.MakeAnUglyThing("Doll"));
PrintThing(Factory.MakeAThing("Panda"));

PrintThing(Factory.MakeAThing("Cat"));
PrintThing(Factory.MakeAnUglyThing("Dog"));

void PrintThing(IThing iThing)
{
    Console.WriteLine(iThing.Name + " is of type " + iThing.GetType());
}