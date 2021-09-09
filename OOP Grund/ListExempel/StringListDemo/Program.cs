namespace StringListDemo
{
    using System;
    using System.Collections;
    using System.Collections.Specialized;

    class Program
    {
        static void Main(string[] args)
        {
            // String collection istället för StringList
            StringCollection dailyPlanetEmployees = new()
            {
                "Clark Kent - Reporter",
                "Lois Lane - Reporter",
                "Jimmy Olsen - Photographer and Cub Reporter",
                "Perry White - Editor -in-Chief",
                "Lana Lang - Business Columnist and editor",
                "Cat Grant - Gossip Columnist and editor",
                "Ron Troupe - Political Columnist and editor",
                "Steve Lombard - Sports Columnist and editor"
            };


            Console.WriteLine(@" _____        _ _             _                  _   ");
            Console.WriteLine(@"|  __ \      (_) |           | |                | |  ");
            Console.WriteLine(@"| |  | | __ _ _| |_   _ _ __ | | __ _ _ __   ___| |_ ");
            Console.WriteLine(@"| |  | |/ _` | | | | | | '_ \| |/ _` | '_ \ / _ \ __|");
            Console.WriteLine(@"| |__| | (_| | | | |_| | |_) | | (_| | | | |  __/ |_ ");
            Console.WriteLine(@"|_____/ \__,_|_|_|\__, | .__/|_|\__,_|_| |_|\___|\__|");
            Console.WriteLine(@"                   __/ | |                           ");
            Console.WriteLine(@"                  |___/|_|                           ");

            Console.WriteLine("Staff:");
            foreach (var employee in dailyPlanetEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
