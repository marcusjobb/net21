// See https://aka.ms/new-console-template for more information
using PizzaMums.Enums;
using PizzaMums.Factories;

Console.WriteLine("Pizza mums!");
// Hämta lista på alla pizzor i enum listan
var values = Enum.GetNames(typeof(PizzaType));
if (values != null)
{
    // Skriv ut alla pizzor
    for (int i = 0; i < values.Length; i++)
    {
        // Lägg till 1 på id så att det ska se snyggt ut
        Console.WriteLine($"{i + 1} - {values[i]}");
    }
}

Console.Write("Välj Pizza: ");
var input = Console.ReadLine();
_ = int.TryParse(input, out var type);
Console.Clear();
// Dra av ett från pizzans nummer om det är större än 1, då vi ökade på det med 1 innan
if (type > 0) type--;

// Omvandla till pizzatyp och beställ pizzan från Factory
var pizza = PizzaFactory.Bake((PizzaType)type);

// Dubbelchecka att pizzan inte är null
if (pizza != null)
{
    // Skriv ut pizzainformation
    Console.WriteLine(pizza.Name);
    if (pizza.IsFolded) Console.WriteLine("Dubbelvikt");
    foreach (var ing in pizza.Ingredients)
    {
        Console.WriteLine(ing);
    }
}