using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetDemo
{
    public class StaticStuff
    {
        public string Name { get; set; } = "Marcus";
        public static string LastName { get; set; } = "Medina";

        static int counter = 0;

        public StaticStuff()
        {
            Console.WriteLine("Class used " + (counter++) + " times");
        }
        // Statiska metoder instansieras bara en gång
        // Kan inte nå icke-statiska variabler / metoder
        public static void SayHello()
        {
            Console.WriteLine("Hello " + LastName);
        }

        // Instansieras med klassen varje gång klassen instansieras
        // Kan nå statiska variabler / metoder
        public void SayHelloAgain()
        {
            Console.WriteLine("Hello again " + Name + " " + LastName);
        }
    }
}
