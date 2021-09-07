namespace BFU_Vecka1_10
{
    using System;

    class Program
    {
        static void Main()
        {
            bool willItRain = true;
            bool isItRaining = false;
            bool doINeedUmbrella;
            bool hasRainPoncho = false;

            doINeedUmbrella = isItRaining || willItRain ;
            doINeedUmbrella &= !hasRainPoncho;
            
            Console.WriteLine("Will it rain      : " + willItRain);
            Console.WriteLine("Does it rain      : " + isItRaining);
            Console.WriteLine("Has rain poncho   : " + hasRainPoncho);
            Console.WriteLine("Do I need umbrella: " + doINeedUmbrella);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
