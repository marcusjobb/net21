using System;
using System.Collections.Generic;  // behövs till list<>

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class ContactList
    {
        List<People> contactList;  // skapar en lista av People kallad contactList

        public ContactList() // constructor, här skapar jag tre personer att använda till att testa programmet
        {
            contactList = new List<People>(); // gör en tom kontaktlista 

            People testPerson1 = new People("John", "Snow", "BastardBoi", "snow_01@gmail.com", "John S Harington", "John Snow Targaryen", "MrSnowyBastard01", "MrSnowyAtTheNightWatchTweets", "CoderOfTheWall", "Pannkakor", "Selleri", "En söt liten vargunge", "Romans", false, false);
            contactList.Add(testPerson1);

            People testPerson2 = new People("Henry", "Cavill", "ButcherOfBlaviken", "superman_ur_hero@live.se", "HenryCavill", "Henry Kent of Rivia", "PicsOfDoggiesAndMeLiftingStuff", "WitcherWithWitt", "SuperCoderManOfRivia", "Vad som helst med PROTEIN till mina muskler", "Leverpastej", "Hund", "Action", false, true);
            contactList.Add(testPerson2);

            People testPerson3 = new People("Jason", "Momoa", "MySunAndStars", "khal_momoa@fishmail.com", "Arthur J Momoa", "Jason Momoa f.d. Curry", "FishManPhotos", "DrogoFunnyTweets", "ProgoDrogo", "Pizza", "Fisk", "Hästar och fiskar", "Skräckis", true, false);
            contactList.Add(testPerson3);
        }

        //-----------------------------CRUDL-METODER(anropas i Menu-klassen)-------------------------------------

        public void Create()// lägg till kontakt
        {
            People newPerson = new People(); //skapa nytt People-objekt

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Du har valt att skapa en ny kontakt. Kul att du klickat med någon ny!");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Ange namn:");
            newPerson.Name = Console.ReadLine();

            Console.WriteLine("Ange efternamn:");
            newPerson.LastName = Console.ReadLine();

            Console.WriteLine("Ange alias:");
            newPerson.Alias = Console.ReadLine();

            Console.WriteLine("Ange Email:");
            newPerson.Email = Console.ReadLine();

            Console.WriteLine("Ange LinkedIn:");
            newPerson.LinkedIn = Console.ReadLine();

            Console.WriteLine("Ange Facebook:");
            newPerson.Facebook = Console.ReadLine();

            Console.WriteLine("Ange Instagram:");
            newPerson.Instagram = Console.ReadLine();

            Console.WriteLine("Ange Twitter:");
            newPerson.Twitter = Console.ReadLine();

            Console.WriteLine("Ange Github:");
            newPerson.Github = Console.ReadLine();

            Console.WriteLine("Ange favorit-maträtt:");
            newPerson.FavFood = Console.ReadLine();

            Console.WriteLine("Ange avskymat:");
            newPerson.LeastFavFood = Console.ReadLine();

            Console.WriteLine("Ange favoritdjur:");
            newPerson.FavAnimal = Console.ReadLine();

            Console.WriteLine("Ange favorit-filmgenre:");
            newPerson.FavMovieGenre = Console.ReadLine();

            Console.WriteLine("Ange om du vill blocka denna kontakt: (Y/N)");
            string inputIsBlockedString = Console.ReadLine();
            newPerson.IsBlocked = false;
            if (inputIsBlockedString == "Y")
            {
                newPerson.IsBlocked = true;
            }
            if (inputIsBlockedString == "N")
            {
                newPerson.IsBlocked = false;
            }

            Console.WriteLine("Ange om du vill ghosta denna kontakt: (Y/N)");
            string inputIsGhostedString = Console.ReadLine();
            newPerson.IsGhosted = false;
            if (inputIsGhostedString == "Y")
            {
                newPerson.IsGhosted = true;
            }
            if (inputIsGhostedString == "N")
            {
                newPerson.IsGhosted = false;
            }

            contactList.Add(newPerson);  // lägg till den nya personen i kontaktlistan    
        }

        // återvänder automatiskt till menyn

        //-----------------------------------------------------------------------------------------------------------
        public void Read() //visa vald kontakt
        {
            foreach (var person in this.contactList) //lista alla alias
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Alias: " + person.Alias);
                Console.WriteLine("------------------------------------------------");
            }

            Console.WriteLine("Ange alias på den du vill visa:");
            string userInputAlias = Console.ReadLine();

            foreach (var person in this.contactList)
            {
                if (userInputAlias == person.Alias)
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Namn: " + person.Name);
                    Console.WriteLine("Efternamn: " + person.LastName);
                    Console.WriteLine("Alias: " + person.Alias);
                    Console.WriteLine("Email: " + person.Email);
                    Console.WriteLine("LinkedIn: " + person.LinkedIn);
                    Console.WriteLine("Facebook: " + person.Facebook);
                    Console.WriteLine("Instagram: " + person.Instagram);
                    Console.WriteLine("Twitter: " + person.Twitter);
                    Console.WriteLine("Github: " + person.Github);
                    Console.WriteLine("Favoritmat: " + person.FavFood);
                    Console.WriteLine("Avskymat: " + person.LeastFavFood);
                    Console.WriteLine("Favoritdjur: " + person.FavAnimal);
                    Console.WriteLine("Favorit-filmgenre: " + person.FavMovieGenre);
                    Console.WriteLine("Blockad: " + person.IsBlocked);
                    Console.WriteLine("Ghostad: " + person.IsGhosted);
                    Console.WriteLine("------------------------------------------------");

                    Console.WriteLine("Tryck på valfri tagnent för att återgå till menyn...");
                    Console.ReadKey();
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------------
        public void Update() // uppdatera attribut av vald kontakt
        {
            foreach (var person in this.contactList)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Alias: " + person.Alias);
                Console.WriteLine("------------------------------------------------");
            }

            Console.WriteLine("Ange alias på den du vill uppdatera:");
            string userInputAlias = Console.ReadLine();
            Console.Clear(); // rensar konsollen, ser bättre ut så

            for (int i = 0; i < contactList.Count; i++) // for-loopar igenom hela kontaktlistan
            {

                if (userInputAlias == contactList[i].Alias) // om det finns någon i listan med angivet alias, visa dess uppgifter
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Namn: " + contactList[i].Name);
                    Console.WriteLine("Efternamn: " + contactList[i].LastName);
                    Console.WriteLine("Alias: " + contactList[i].Alias);
                    Console.WriteLine("Email: " + contactList[i].Email);
                    Console.WriteLine("LinkedIn: " + contactList[i].LinkedIn);
                    Console.WriteLine("Facebook: " + contactList[i].Facebook);
                    Console.WriteLine("Instagram: " + contactList[i].Instagram);
                    Console.WriteLine("Twitter: " + contactList[i].Twitter);
                    Console.WriteLine("Github: " + contactList[i].Github);
                    Console.WriteLine("Favoritmat: " + contactList[i].FavFood);
                    Console.WriteLine("Avskymat: " + contactList[i].LeastFavFood);
                    Console.WriteLine("Favoritdjur: " + contactList[i].FavAnimal);
                    Console.WriteLine("Favorit-filmgenre: " + contactList[i].FavMovieGenre);
                    Console.WriteLine("Blockad: " + contactList[i].IsBlocked);
                    Console.WriteLine("Ghostad: " + contactList[i].IsGhosted);
                    Console.WriteLine("------------------------------------------------");

                    Console.WriteLine("Ange nu det attribut du önskar uppdatera:");
                    string userInputAttr = Console.ReadLine();

                    switch (userInputAttr.ToLower()) //switchar igenom alla attribut
                    {
                        case "namn":
                            Console.WriteLine("Ange namn:");
                            contactList[i].Name = Console.ReadLine();
                            break;

                        case "efternamn":
                            Console.WriteLine("Ange efternamn:");
                            contactList[i].LastName = Console.ReadLine();
                            break;

                        case "alias":
                            Console.WriteLine("Ange alias:");
                            contactList[i].Alias = Console.ReadLine();
                            break;

                        case "email":
                            Console.WriteLine("Ange Email:");
                            contactList[i].Email = Console.ReadLine();
                            break;

                        case "linkedin":
                            Console.WriteLine("Ange LinkedIn:");
                            contactList[i].LinkedIn = Console.ReadLine();
                            break;

                        case "facebook":
                            Console.WriteLine("Ange Facebook:");
                            contactList[i].Facebook = Console.ReadLine();
                            break;

                        case "instagram":
                            Console.WriteLine("Ange Instagram:");
                            contactList[i].Instagram = Console.ReadLine();
                            break;

                        case "twitter":
                            Console.WriteLine("Ange Twitter:");
                            contactList[i].Twitter = Console.ReadLine();
                            break;

                        case "github":
                            Console.WriteLine("Ange Github:");
                            contactList[i].Github = Console.ReadLine();
                            break;

                        case "favoritmat":
                            Console.WriteLine("Ange favoritmat:");
                            contactList[i].FavFood = Console.ReadLine();
                            break;

                        case "avskymat":
                            Console.WriteLine("Ange avskymat:");
                            contactList[i].LeastFavFood = Console.ReadLine();
                            break;

                        case "favoritdjur":
                            Console.WriteLine("Ange favoritdjur:");
                            contactList[i].FavAnimal = Console.ReadLine();
                            break;

                        case "favorit-filmgenre":
                            Console.WriteLine("Ange favorit-filmgenre:");
                            contactList[i].FavMovieGenre = Console.ReadLine();
                            break;

                        case "blockad":
                            Console.WriteLine("Ange om du vill blocka personen (Y/N)");

                            string inputIsBlocked = Console.ReadLine();
                            contactList[i].IsBlocked = false;
                            if (inputIsBlocked == "Y")
                            {
                                contactList[i].IsBlocked = true;
                            }
                            break;

                        case "ghostad":
                            Console.WriteLine("Ange om du vill ghosta personen (Y/N)");

                            string inputIsGhosted = Console.ReadLine();
                            contactList[i].IsGhosted = false;
                            if (inputIsGhosted == "Y")
                            {
                                contactList[i].IsGhosted = true;
                            }
                            break;

                        default:
                            Console.WriteLine("Ange nu det attribut du önskar uppdatera:");
                            userInputAttr = Console.ReadLine();
                            break;
                    }
                }
            }
            Console.WriteLine("Tryck på valfri tagnent för att återgå till menyn...");
            Console.ReadKey();
        }
        //-----------------------------------------------------------------------------------------------------------
        public void Delete() // ta bort vald kontakt
        {

            foreach (var person in this.contactList)
            {
                Console.WriteLine("------------------------------------------------");
               Console.WriteLine("Alias: " + person.Alias);
                Console.WriteLine("------------------------------------------------");
            }

            Console.WriteLine("Ange alias på den du vill ta bort. Du kan även tömma din lista genom att skriva 'alla'.");
            string userInputAlias = Console.ReadLine();

            for (int i = 0; i < contactList.Count; i++)
            {
                if (userInputAlias == contactList[i].Alias)
                {
                    Console.WriteLine(contactList[i].Alias + " raderas, bye!");
                    contactList.Remove(contactList[i]);

                }
            }

            if (userInputAlias == "alla")
            {
                contactList.Clear(); //ta bort alla kontakter
            }

            Console.WriteLine("Tryck på valfri tagnent för att återgå till menyn...");
            Console.ReadKey();
        }
        //-----------------------------------------------------------------------------------------------------------
        public void List() // lista alla
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Här är en lista med alla " + contactList.Count + " personer i din kontaktlista, ger en god chans att hitta kärleken!");
            Console.WriteLine("------------------------------------------------");

            foreach (var person in contactList)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Namn: " + person.Name);
                Console.WriteLine("Efternamn: " + person.LastName);
                Console.WriteLine("Alias: " + person.Alias);
                Console.WriteLine("------------------------------------------------");
            }

            Console.WriteLine("Tryck på valfri tagnent för att återgå till menyn...");
            Console.ReadKey();

        }
        //-----------------------------------------------------------------------------------------------------------
        public void ListByLetter() // Lista på viss bokstav
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Ange en bokstav så visas alla vars namn börjar på den bokstaven...");
            Console.WriteLine("------------------------------------------------");

            string userInputName = Console.ReadLine();

            for (int i = 0; i < contactList.Count; i++)
            {
                if (contactList[i].Name.ToLower().StartsWith(userInputName.ToLower()))
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Namn: " + contactList[i].Name);
                    Console.WriteLine("Efternamn: " + contactList[i].LastName);
                    Console.WriteLine("Alias: " + contactList[i].Alias);
                    Console.WriteLine("------------------------------------------------");
                }
            }

            Console.WriteLine("Tryck på valfri tagnent för att återgå till menyn...");
            Console.ReadKey();
        }
    }
}
