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
            
            Console.WriteLine("Daily Planet staff");
            foreach (var employee in dailyPlanetEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
