// -----------------------------------------------------------------------------------------------
//  HeroesAndVillians.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace SnyggkodDemo.SlarvigKod
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HeroesAndVillians
    {
        private readonly List<Models.Names> names = new();

        public void Start()
        {
            SeedNames();
            ShowEverybody();
            FindFirstName("Bruce");
            FindLastName("Gordon");
            FindLastName("kent");
            FindCity("Gotham");
            FindCity("Star City");
            FindCity("Metropolis");
            FindCity("Smallville");
            ShowListOfVillians();
            SearchCity();
            SearchFirstName();
            SearchLastName();
        }

        private void SearchLastName()
        {
            Console.WriteLine("Search last name");
            Console.Write("Lastname: ");
            var input3 = Console.ReadLine();
            FindLastName(input3);
        }

        private void FindLastName(string input3)
        {
            var lname = names.Where(x => x.LastName.Contains(input3, StringComparison.InvariantCultureIgnoreCase)).ToList();
            DisplayList(lname, "Last name contains " + input3);
        }

        private void SearchFirstName()
        {
            Console.WriteLine("Search name");
            Console.Write("Name: ");
            var input2 = Console.ReadLine();
            FindFirstName(input2);
        }

        private void FindFirstName(string input2)
        {
            var fname = names.Where(x => x.FirstName.Contains(input2, StringComparison.InvariantCultureIgnoreCase)).ToList();
            DisplayList(fname, "First name contains " + input2);
        }

        private void SearchCity()
        {
            Console.WriteLine("Search city");
            Console.Write("City: ");
            var input = Console.ReadLine();
            FindCity(input);
        }

        private void FindCity(string input)
        {
            var city = names.Where(x => x.City.Contains(input, StringComparison.InvariantCultureIgnoreCase)).ToList();
            DisplayList(city, "People living in " + input);
        }

        private void ShowListOfVillians()
        {
            var villians = names.Where(x => x.IsEvil).ToList();
            DisplayList(villians, "Evil people");
        }

        private void ShowEverybody()
        {
            DisplayList(names, "Everybody");
        }

        private void SeedNames()
        {
            names.Add(new Models.Names("Harleen", "Quinzel", "Gotham", true));
            names.Add(new Models.Names("Oliver", "Queen", "Star City"));
            names.Add(new Models.Names("Felicity", "Smoak", "Star City"));
            names.Add(new Models.Names("Perry", "White", "Metropolis"));
            names.Add(new Models.Names("Phineas", "Potter", "Smallville"));
            names.Add(new Models.Names("Fish", "Moroney", "Gotham", true));
            names.Add(new Models.Names("Oswald", "Cobblepot", "Gotham", true));
            names.Add(new Models.Names("Barbara", "Gordon", "Gotham"));
            names.Add(new Models.Names("Lois", "Lane", "Metropolis"));
            names.Add(new Models.Names("Lex", "Luthor", "Metropolis", true));
            names.Add(new Models.Names("Renee", "Montoya", "Gotham"));
            names.Add(new Models.Names("Leslie", "Thompkins", "Gotham"));
            names.Add(new Models.Names("Cat", "Grant", "Metropolis"));
            names.Add(new Models.Names("Oliver", "Queen", "Star City"));
            names.Add(new Models.Names("Bruce", "Banner", "Jungle"));
            names.Add(new Models.Names("Carl", "Draper", "Smallville", true));
            names.Add(new Models.Names("Moira", "Queen", "Star City"));
            names.Add(new Models.Names("Jonathan", "Kent", "Smallville"));
            names.Add(new Models.Names("Quentin", "Lance", "Star City", true));
            names.Add(new Models.Names("Martha", "Kent", "Smallville"));
            names.Add(new Models.Names("Harvey", "Bullock", "Gotham"));
            names.Add(new Models.Names("James", "Gordon", "Gotham"));
            names.Add(new Models.Names("Bruce", "Wayne", "Gotham"));
            names.Add(new Models.Names("Jimmy", "Olsen", "Metropolis"));
            names.Add(new Models.Names("Selina", "Kyle", "Gotham", true));
            names.Add(new Models.Names("Martha", "Kent", "Smallville"));
            names.Add(new Models.Names("Carmine", "Falcone", "Gotham", true));
            names.Add(new Models.Names("Clark", "Kent", "Metropolis"));
            names.Add(new Models.Names("Laurel", "Lance", "Star City", true));
            names.Add(new Models.Names("Felicity", "Smoak", "Star City"));
            names.Add(new Models.Names("Douglas", "Parker", "Smallville"));
            names.Add(new Models.Names("Lana", "Lang", "Smallville"));
            names.Add(new Models.Names("Alfred", "Pennypot", "Gotham"));
            names.Add(new Models.Names("John", "Diggle", "Star City"));
            names.Add(new Models.Names("Edward", "Nigma", "Gotham", true));
            names.Add(new Models.Names("Lucius", "Fox", "Gotham"));
            names.Add(new Models.Names("Emil", "Hamilton", "Metropolis"));
            names.Add(new Models.Names("Oswald", "Cobblepot", "Gotham", true));
        }

        private static void DisplayList(List<Models.Names> names, string name)
        {
            Console.WriteLine(name);
            foreach (var person in names.OrderBy(n => n.LastName).ThenBy(n => n.FirstName))
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }
    }
}