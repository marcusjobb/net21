using System;
using System.Collections.Generic;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class Menu
    {
        public void RunMenu(ContactList contactList) // menymetod som tar info från en ContactList kallad contactList
        {
            bool runMenu = true;
            while (runMenu)
            {
                Console.Clear();
                Console.WriteLine("|-------------------|");
                Console.WriteLine("|------M-E-N-Y------|");
                Console.WriteLine("|-------------------|");
                Console.WriteLine("Ange tillhörande siffra för att välja ett alternativ:");
                Console.WriteLine("1- Skapa ny kontakt");
                Console.WriteLine("2- Visa kontakt");
                Console.WriteLine("3- Uppdatera kontakt");
                Console.WriteLine("4- Ta bort kontakt");
                Console.WriteLine("5- Lista alla kontakter");
                Console.WriteLine("6- Lista alla som börjar på en angiven bokstav");
                Console.WriteLine("7- Avsluta");

                string userInput = Console.ReadLine();  // ta input och parsa
                int userInputInt = 0;
                int.TryParse(userInput, out userInputInt);

                if (userInputInt > 7 || userInputInt < 0)
                {
                    Console.WriteLine("Välj ett alternativ mellan 1-7 från menyn!");
                    Console.ReadKey();
                }

                switch (userInputInt)
                {
                    case 1:
                        contactList.Create(); // skapa kontakt
                        break;
                    case 2:
                        contactList.Read(); //öppna kontakt
                        break;
                    case 3:
                        contactList.Update(); // redigera kontakt
                        break;
                    case 4:
                        contactList.Delete(); // ta bort kontakt
                        break;
                    case 5:
                        contactList.List(); // lista alla kontakter
                        break;
                    case 6:
                        contactList.ListByLetter(); //lista alla kontakter som börjar på en spec. bokstav
                        break;
                    case 7:
                        runMenu = false; //avslutar programmet
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
