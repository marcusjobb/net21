// See https://aka.ms/new-console-template for more information
using Figgle;

using PizzaMums.Enums;
using PizzaMums.Factories;
using PizzaMums.Interfaces;
using PizzaMums.Pizzas;

var mumsBanner = GenerateBanner("Pizza Mums");
ListAllPizzas();
var pizza = SelectPizza();

Console.Clear();
Console.WriteLine(mumsBanner);
PrintPizza(pizza);

string GenerateBanner(string message)
{
    // Använder figlet nuget: install-package Figgle
    // font samples: http://www.figlet.org/examples.html
    var font = FiggleFonts.Ogre;
    var text = font.Render(message);
    Console.WriteLine(text);
    return text;
}

void ListAllPizzas()
{
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
}

IPizza SelectPizza()
{
    Console.WriteLine();
    Console.Write("Välj Pizza: ");
    var input = Console.ReadLine();
    _ = int.TryParse(input, out var type);
    return GetPizza(type);
}

IPizza GetPizza(int type)
{
    // Dra av ett från pizzans nummer om det är större än 1, då vi ökade på det med 1 innan
    if (type > 0) type--;

    // Omvandla till pizzatyp och beställ pizzan från Factory
    var pizza = PizzaFactory.Bake((PizzaType)type);
    return pizza;
}

void PrintPizza(IPizza pizza)
{
    // Dubbelchecka att pizzan inte är null
    if (pizza != null)
    {
        Console.Clear();
        // Skriv ut pizzainformation
        GenerateBanner(pizza.Name);
        if (pizza.IsFolded) Console.WriteLine("Dubbelvikt");
        foreach (var ing in pizza.Ingredients)
        {
            Console.WriteLine(ing);
        }
    }
}