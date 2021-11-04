using System;

namespace Chat_upV2
{
    class Menu // Meny med swtichfunktion som väljer funkion, crudl.
    {
        public void menu()
        {
            bool bootMenu = true;
            contacts boot = new contacts();
            while (bootMenu)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("----- Välkommen till Chat-UP -----");
                Console.WriteLine("Vänligen välj nedan genom att fylla i en siffra: ");
                Console.WriteLine("1. Skapa en kontakt");
                Console.WriteLine("2. Ta bort en kontakt");
                Console.WriteLine("3. Uppdatera en kontakt");
                Console.WriteLine("4. Visa samtliga kontakter");
                Console.WriteLine("5. Visa kontakter på vald bokstav");
                Console.WriteLine("6. Visa information på specifik kontakt");
                Console.WriteLine("7. Avsluta");
                Console.WriteLine("----------------------------------------------------");
                int.TryParse(Console.ReadLine(), out int userChoice);
                switch (userChoice)
                {
                    case 1:
                        boot.Create();
                        break;
                    case 2:
                        boot.Delete();
                        break;
                    case 3:
                        boot.Update();
                        break;
                    case 4:
                        boot.ListAll();
                        break;
                    case 5:
                        boot.ListByLetter();
                        break;
                    case 6:
                        boot.Read();
                        break;
                    default:
                        bootMenu = false;
                        break;
                }
            }

        }
    }
}

