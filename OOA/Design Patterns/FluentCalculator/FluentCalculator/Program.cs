// See https://aka.ms/new-console-template for more information
using FluentCalculator;

Console.WriteLine("Hello, World!");

// Mål: Att kunna utföra beräkningarna i en kedja av metoder
// Digit(3).Operator('+').Digit(2).Digit(2).Result(); // 7

var calc = new Calculator(true);
var res = calc
    .Digit(3)
    .Operator('+')
    .Digit(2)
    .Operator('*')
    .Digit(2)
    .Digit(10)
    .Result();
Console.WriteLine(res);