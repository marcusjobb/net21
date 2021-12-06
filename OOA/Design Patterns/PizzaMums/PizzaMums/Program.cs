// See https://aka.ms/new-console-template for more information
using PizzaMums.Enums;
using PizzaMums.Factories;

using System.Linq;

Console.WriteLine("Pizza mums!");

var values = Enum.GetNames(typeof(PizzaType));
if (values != null)
{
    for (int i = 0; i < values.Length; i++)
    {
        Console.WriteLine(i + " - " + values[i]);
    }
}

Console.Write("Välj Pizza: ");
var input = Console.ReadLine();
int.TryParse(input, out var type);
Console.Clear();

var factory = new PizzaFactory();
var pizza = factory.Bake((PizzaType)type);

Console.WriteLine(pizza.Name);
if (pizza.IsFolded) Console.WriteLine("Dubbelvikt");
foreach (var ing in pizza.Ingredients)
{
    Console.WriteLine(ing);
}