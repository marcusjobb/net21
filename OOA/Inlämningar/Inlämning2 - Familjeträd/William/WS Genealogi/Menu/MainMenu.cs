using WS_Genealogi.Utiles;
using static WS_Genealogi.Utiles.BasicHelper;
using static WS_Genealogi.Utiles.PersonHelper;

namespace WS_Genealogi.Menu
{
    internal class MainMenu
    {
        public void StartMenu()
        {
            while (true)
            {
                Write("1. Skapa Person");
                Write("2. Radera Person");
                Write("3. Lista Personer");
                Write("4. Uppdatera Person");
                Write("5. Skapa förälder");
                string input = Console.ReadLine();

                if (input == "1")
                    CreatePerson();
                if (input == "2")
                    DeletePerson();
                if (input == "3")
                    ListPerson();
                if (input == "4")
                    UpdatePerson();
                if (input == "5")
                    CreateParent();
            }




        }

        private static void ListPerson()
        {
            Console.Clear();
            Write("Vill du.....");
            Write("1. Söka på förnaman");
            Write("2. Söka på efternamn");
            Write("3. Lista alla");
            string input2 = Console.ReadLine();
            if (input2 == "1")
            {
                string name = WriteAndInput("Skriv in namn: ");
                SearchByName(name);
            }
            if (input2 == "2")
            {
                string lastName = WriteAndInput("Skriv in efternamn: ");
                SearchByLastName(lastName);
            }
                
            if (input2 == "3")
                ShowAll();
        }

        private static void DeletePerson()
        {
            Console.Clear();
            string name = WriteAndInput("Skriv in namn: ");
            string lastName = WriteAndInput("Skriv in efternamn: ");

            FindAndDeletePerson(name, lastName);
        }

        private static void CreatePerson()
        {
            Console.Clear();
            string name = WriteAndInput("Skriv in namn: ");
            string lastName = WriteAndInput("Skriv in efternamn: ");
            int.TryParse(WriteAndInput("Skriv in födelseår: "), out int birthYear);

            FindOrCreatePerson(name, lastName, birthYear);
        }
        private static void UpdatePerson()
        {
            Console.Clear();
            string name = WriteAndInput("Skriv in namn: ");
            string lastName = WriteAndInput("Skriv in efternamn: ");

            FindAndUpdatePerson(name, lastName);
        }
        private static void CreateParent()
        {
            Console.Clear();
            Write("1. Skapa en mamma?");
            Write("2. Skapa en pappa?");
            string input = Console.ReadLine();

            if(input == "1")
            {
                string name = WriteAndInput("Skriv in namn på personen du vill ge en förälder: ");
                string lastName = WriteAndInput("Skriv in efternamn på personen du vill ge en förälder: ");
                int.TryParse(WriteAndInput("Skriv in födelseår på personen du vill ge en förälder: "), out int birthYear);

                FindOrCreateMother(name, lastName, birthYear);
            }
            if (input == "2")
            {
                string name = WriteAndInput("Skriv in namn på personen du vill ge en förälder: ");
                string lastName = WriteAndInput("Skriv in efternamn på personen du vill ge en förälder: ");
                int.TryParse(WriteAndInput("Skriv in födelseår på personen du vill ge en förälder: "), out int birthYear);

                FindOrCreateFather(name, lastName, birthYear);
            }

        }
    }
}
