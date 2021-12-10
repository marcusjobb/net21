// See https://aka.ms/new-console-template for more information
using SimpleBuilder.Builders;
using SimpleBuilder.Interface;
using SimpleBuilder.Models;

Console.WriteLine("Build a bear!");
Console.WriteLine("-------------");
Console.WriteLine();
var classicBear = new Bear
(
    new Legs[]
    {
        new Legs{Name="Left leg"},
        new Legs{Name="Right leg"}
    },
    new Arms[] {
        new Arms { Name = "Left arm" },
        new Arms { Name = "Right arm" }
    },
    new Head { EyeColor = "Brown", MouthExpression = "Frown" },
    new Torso { Color = "Light brown" },
    "Teddybear",
    "Brown"
);

PrintABear(classicBear);

var build = new BuildABear();
build.
      SetColor("Blue").
      SetTorsoColor("Green").
      SetEyeColor("Red").
      SetMouthExpression("grin").
      SetName("Evil Teddy")
      ;

PrintABear(build.Build());

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

void PrintABear(IPlushAnimal bear)
{
    Console.WriteLine(bear.Name);
    Console.WriteLine("Eyes are " + bear.Head.EyeColor + " and the mouth is " + bear.Head.MouthExpression);
    Console.WriteLine("The body is "+bear.Color +" and the torso is "+bear.Torso.Color);
    Console.Write("Has");
    foreach (var arm in bear.Arms)
    {
        Console.Write(arm.Name+" ");
    }
    Console.WriteLine();
    foreach (var leg in bear.Legs)
    {
        Console.Write(leg.Name + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}