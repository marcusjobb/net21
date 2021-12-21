// -----------------------------------------------------------------------------------------------
//  Menu.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace MainMenu
{
    using System;
    using System.Collections.Generic;

    public class Menu
    {
        // Menyalternativ
        protected List<string> MenuOptions = new();
        public string Title { get; set; }
        public string Cursor { get; set; } = ">";

        // Lägger till alternativ i menyn
        public virtual void AddOption(string optionTitle)
        {
            MenuOptions.Add(optionTitle);
        }

        // Visar menyn
        public virtual void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine(Title);
            for (int i = 0; i < MenuOptions.Count; i++)
            {
                // Lägger till 1 i menyvalen för att användaren inte ska behöva tänka på att
                // börja från 0
                Console.WriteLine("[" + (i + 1) + "] " + MenuOptions[i]);
            }
        }

        // Låser in användaren i en loop tills de valt något
        // Första loopen kör så länge valet är mindre än 1 eller större än max antal val
        // Andra loopen kör så länge man inte matar in en siffra
        public virtual int LetUserChoose()
        {
            string input;
            int choice = 0;
            while (choice < 1 || choice > MenuOptions.Count)
            {
                do
                {
                    Console.Write(Cursor);
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out choice));
            }
            return choice - 1; // Korrigerar valet till att börja från 0
        }

        public virtual string GetOption(int choice)
        {
            return MenuOptions[choice];
        }
    }
}
