#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable CS8321 // Local function is declared but never used
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var lst = new List<string> { "Dracula", "Frankenstein", "The Mummy" };
lst.ForEach(m => Console.WriteLine(m));

var value = 1 < 2;

//if (value)
//    result = true;
//else
//    result = false;

// result = value ? true : false;

var result = 1 < 2;

var valueX = 5;
var valueY = 3;

//if (IsHigher(valueX,valueY))
if (valueX > valueY)
    Console.WriteLine("X is higher");
else
    Console.WriteLine("X is not higher");

static bool IsHigher (int a, int b) => a > b;

#pragma warning restore CS0219 // Variable is assigned but its value is never used
#pragma warning restore CS8321 // Local function is declared but never used