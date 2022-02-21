Add("Hello", "World");
Add("Twenty=", 20);
Add(3.1415, "is Pi");
Add(3.32, 25);
Add(8.25, 0);
static void Add (dynamic dyn1, dynamic dyn2)
{
    var add = dyn1 + dyn2;

    Console.WriteLine($"{dyn1} {dyn2}");
    Console.WriteLine(add);
    if (!(dyn1 is string || dyn2 is string))
    {
        var div = dyn1 / dyn2;
        Console.WriteLine(div);
    }
    Console.WriteLine($"Variabeln dyn1 is {dyn1.GetType()}");
    Console.WriteLine($"Variabeln dyn2 is {dyn2.GetType()}");
    Console.WriteLine();
}
