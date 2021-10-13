using System;
using System.Threading;
using System.Collections.Generic;

namespace Fdate002
{
    public static class Miscellaneous
    {
        public static string mainMenuHeader = "HUVUDMENY <UPP> <NED> navigera <ENTER> välj";
        public static string menuHeader = " <UPP > <NED> navigera <ENTER> välj <HOME> tillbaka";        
        public static string personHeader = "<UPP> <NED> navigera <ENTER> visa, <DELETE> ta bort, <INSERT> redigera\n<END> blocka/avblocka, <PgDn> ghosta/avghosta < + > lägg till ny kontakt\n <HOME> tillbaka";
 
        public static List<(string,string)> MainMenuOptions = new List<(string,string)> // andra strängen i tuplen fyller ingen funktion i icke-personmenyer, men krävs.
            {
            ("1. Lista alla kontakter  "," "),
            ("2. Lista alla kontakter med förnamnsbegynnelsebokstav...  ", " "),
            ("3. Lista alla blockade kontakter   "," "),
            ("4. Lista alla ghostade kontakter "," "),
            ("5. Lista alla kontakter som har/hade födelsedag denna månad   "," "),
            ("6. Lista alla kontakter med efternamnsbegynnelsebokstav...  ", " "),
            };
 
        public static List<(string,string)> ABC = new List<(string, string)>            // d:o
          { ("A"," "),("B"," "),("C"," "),("D"," "),("E"," "),("F"," "),("G"," "),("H"," "),("I"," "),("J"," "),("K"," "),("L"," "),("M"," "),("N"," "),("O"," "),("P"," "),("Q"," "),("R"," "),("S"," "),("T"," "),("U"," "),("V"," "),("X"," "),("Y"," "),("Z"," "),("Å"," "),("Ä"," "),("Ö"," ")};

        public static Dictionary<string, string> editableProps = new Dictionary<string, string> //behövs för att variablerna är på engelska + att loopen över properties bara hanterar strängar.
        {                                                               
            {"FirstName","Förnamn" },
            {"LastName","Efternamn" },
            {"Alias","Alias" },
            {"Mail","E-mail"},
            {"LinkedIn", "LinkedIn-profil"},
            {"FaceBook","Facebook-sida" },
            {"InstaGram","Instagram"},
            {"Twitter","Twitter-konto" },
            {"GitHub","Github-sida" },
            {"FavouriteFood",  "Favoritmat" },
            {"LeastFavouriteFood", "Avskymat"  },
            {"FavouriteMovieGenre","Favoritfilmgenre"   },
            {"IsBlocked", "ignore" },
            {"IsGhosted","ignore" },
            {"DateOfBirth", "ignore" },
            {"ID", "ignore" },
            {"FavouriteAnimal", "Favoritdjur" }
        };

        public static List<(string,string)> BuildMenu(string option, Contacts myContacts)

        {

            List<(string,string)> displayPersons = new List<(string, string)>();

            string blockStatus = " ";
            string ghostStatus = " ";

            foreach (var person in myContacts.contacts)                     // kanske skulle ha for:at istf foreachat?
                                                                            // och använt index i listan istf ID?
            {                                                               // ID förblir dock konstant..?
                if (person.IsBlocked) blockStatus = " blockad ";            //försent nu.
                if (person.IsGhosted) ghostStatus = "ghostad";
                if (!person.IsBlocked) blockStatus = " ";
                if (!person.IsGhosted) ghostStatus = " ";
                if (option == "blocked")
                {
                    if (person.IsBlocked)
                    {
                        displayPersons.Add((person.FirstName + " " + person.LastName + new string(' ', (50 - (person.FirstName.Length + person.LastName.Length))) + "  ålder: " + myContacts.GetAge(person)  + blockStatus  + ghostStatus, person.ID)) ;
                    }
                }
                else if (option == "ghosted")
                {
                    if (person.IsGhosted)
                    {
                        displayPersons.Add((person.FirstName + " " + person.LastName + new string(' ', (50 - (person.FirstName.Length + person.LastName.Length))) + "  ålder: " + myContacts.GetAge(person)  + blockStatus  + ghostStatus, person.ID));
                    }
                }
                else if (option == "birthday")
                {
                    if (person.DateOfBirth.Month == DateTime.Now.Month)
                    {
                        displayPersons.Add((person.FirstName + " " + person.LastName + new string(' ', (50 - (person.FirstName.Length + person.LastName.Length))) + "  ålder: " + myContacts.GetAge(person) + blockStatus  + ghostStatus, person.ID));

                    }
                }
                else if (option == "all")
                {
                    displayPersons.Add((person.FirstName + " " + person.LastName + new string(' ', (50 - (person.FirstName.Length + person.LastName.Length))) + "  ålder: " + myContacts.GetAge(person)  + blockStatus  + ghostStatus, person.ID));

                }
                else 
                {
                    if (person.FirstName[0] == option[0])// myReturn)
                    {
                        displayPersons.Add((person.FirstName + " " + person.LastName + new string(' ', (50 - (person.FirstName.Length + person.LastName.Length))) + "  ålder: " + myContacts.GetAge(person)  + blockStatus  + ghostStatus, person.ID));
                    }
                    else if (person.LastName[0] == char.ToUpper(option[0]))
                    {
                        displayPersons.Add((person.FirstName + " " + person.LastName + new string(' ', (50 - (person.FirstName.Length + person.LastName.Length))) + "  ålder: " + myContacts.GetAge(person) + blockStatus + ghostStatus, person.ID));
                    }
                }
            }
            return displayPersons;
        }

        public static string StyleUp(string input)
        {
            string[] badBoys = new string[] { " ", "*", ".", "\t", ".", ",", ":", ";", "!", "?", "%" };
            for (int i = 0; i < badBoys.Length; i++)
            {
                input = input.Replace(badBoys[i], "");
            }
            var firstLetter = input.Substring(0, 1).ToUpper();
            var theRest = input.Substring(1).ToLower();
            return firstLetter + theRest;
        }
        public static void Working (string message)
        {
            Console.Write(message);
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
        }
    }
}

