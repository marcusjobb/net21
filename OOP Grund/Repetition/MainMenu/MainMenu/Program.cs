using System;

namespace MainMenu
{
    internal static class Program
    {
        private static void Main()
        {
            var menu = new Menu();
            menu.AddOption("List movies");
            menu.AddOption("Play songs");
            menu.AddOption("Read Email");
            menu.Title = "Main menu";
            menu.ShowMenu();
            int choice = menu.LetUserChoose();
            Console.WriteLine("You chose " + menu.GetOption(choice));

            // Den här menyn fungerar OK men den är inte snygg
            // Gör en klass som ärver från menyn och som skriver ut det på ett snyggare sätt
            // Ändra sedan i var menu raden till att new ska skapa en instans av din menyklass
            // istället för moderklassen Menu.
            // Se exempel TeacherMenu.cs
            //
            // Förslag
            // Olika färg på texten och siffrorna
            // Centrerad meny
            // En stor låda som innehåller menyn
            // När du har gjort en snygg meny, skicka den till mig så lägger jag till den i exemplet

        }
    }
}
