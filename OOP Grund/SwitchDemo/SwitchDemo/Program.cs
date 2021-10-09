namespace SwitchDemo
{
    using System;

    enum Dagar
    {
        Måndag, Tisdag, Onsdag, Torsdag, Fredag, Lördag, Söndag
    }

    enum Directions
    {
        North, East, South, West
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            int.TryParse(Console.ReadLine(), out int value);

            Directions dir = Directions.West;
            GoDirection(dir);

            Dagar day = Dagar.Måndag;

            switch (day)
            {
                case Dagar.Måndag:
                    break;
                case Dagar.Tisdag:
                    break;
                case Dagar.Onsdag:
                    break;
                case Dagar.Torsdag:
                    break;
                case Dagar.Fredag:
                    break;
                case Dagar.Lördag:
                    break;
                case Dagar.Söndag:
                    break;
                default:
                    break;
            }

            string resultat = value switch
            {
                1337 => "Leet",
                < 100 => "Mindre än 100",
                > 100 => "Större än 100",
                _ => "Whatever",
            };

            Console.WriteLine(resultat);
        }

        private static void GoDirection(Directions dir)
        {
            switch (dir)
            {
                case Directions.North:
                    Console.WriteLine("Gå nord");
                    break;
                case Directions.East:
                    Console.WriteLine("Gå öst");
                    break;
                case Directions.South:
                    Console.WriteLine("Gå Söder");
                    break;
                case Directions.West:
                    Console.WriteLine("Gå väst");
                    // https://www.youtube.com/watch?v=LNBjMRvOB5M&t=1s
                    break;
                default:
                    break;
            }
        }
    }
}
