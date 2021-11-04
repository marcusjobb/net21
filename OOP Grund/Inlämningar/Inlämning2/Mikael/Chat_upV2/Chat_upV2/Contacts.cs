using System;
using System.Collections.Generic;

namespace Chat_upV2
{
    class contacts
    {
        List<People> userList = new List<People>();
        public contacts()
        {
            userList = new List<People>();

            People user1 = new People("Thomas", "Shelby", "Tommy", "tommy.shelby@shelbycompanylmtd.com", "Thomas Shelby", "Tommyboy", "PeakyFokinBlinder", "BlinderLad", "Blinderboy23", "Haggis", "Pizza", "Horses", "Action", false, false);
            People user2 = new People("Arthur", "Shelby", "Blackout", "arthur.shelby@shelbycompanylmtd.com", "Arthur Shelby", "Art", "ByORDER", "BlinderLad25", "Blinderboy24", "Liverstew", "Pasta", "Horses", "Action", false, false);


            userList.Add(user1); //Lägger till users ovan i listan.
            userList.Add(user2);
        }

        public void Create() // mall för tillägg av properties på användare
        {
            People newUser = new People();

            Console.WriteLine("Ange ditt namn: ");
            newUser.Name = Console.ReadLine();

            Console.WriteLine("Ange ditt efternamn: ");
            newUser.SurName = Console.ReadLine();

            Console.WriteLine("Ange ditt smeknamn: ");
            newUser.Nickname = Console.ReadLine();

            Console.WriteLine("Ange din e-postadress: ");
            newUser.Email = Console.ReadLine();

            Console.WriteLine("Ange din LinkedIn: ");
            newUser.LinkedIn = Console.ReadLine();

            Console.WriteLine("Ange din Facebook: ");
            newUser.Facebook = Console.ReadLine();

            Console.WriteLine("Ange din Instagram: ");
            newUser.Instagram = Console.ReadLine();

            Console.WriteLine("Ange din Twitter: ");
            newUser.Twitter = Console.ReadLine();

            Console.WriteLine("Ange ditt Github: ");
            newUser.Github = Console.ReadLine();

            Console.WriteLine("Ange din favoritmaträtt: ");
            newUser.FavFood = Console.ReadLine();

            Console.WriteLine("Ange din hat-mat: ");
            newUser.HateFood = Console.ReadLine();

            Console.WriteLine("Ange ditt favoritdjur: ");
            newUser.FavAnimal = Console.ReadLine();

            Console.WriteLine("Ange ditt favorit filmgenre: ");
            newUser.FavMovieGenre = Console.ReadLine();

            Console.WriteLine("Ange om denna kontakt ska bli blockad? (Y/N)");  // ska man blocka sig själv? denna funktionen är snurrig :D
            newUser.IsBlocked = false;
            string isBlockedYN = Console.ReadLine();
            if (isBlockedYN == "Y")
            {
                newUser.IsBlocked = true;
            }

            Console.WriteLine("Ange om denna kontakten ska bli ghostad? (Y/N) "); // samma som ovan :D
            newUser.IsGhosted = false;
            string isGhostedYN = Console.ReadLine();
            if (isGhostedYN == "Y")
            {
                newUser.IsGhosted = true;
            }

            userList.Add(newUser);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Klicka på valfri knapp för att komma tillbaka till menyn.");
            Console.ReadKey();
            Console.Clear();

        }


        public void Delete()
        {
            //Fråga om vem som ska bort
            Console.WriteLine("Vem ska man ta bort", userList.Count);
            Console.WriteLine( userList.Count);
            for (int i = 0; i < userList.Count; i++)  //Listar namn som finns
            {
                Console.WriteLine("Vem vill du ta bort");
                Console.WriteLine("Namn: " + userList[i].Name);
                
            };

            //ta in namn
            string input = Console.ReadLine();


            for (int i = 0; i < userList.Count; i++) 
            {
                if (input == userList[i].Name) //Tar bort användaren som input anger.
                {
                    userList.RemoveAt(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Klicka på valfri knapp för att komma tillbaka till menyn.");
            Console.ReadKey();
            Console.Clear();

        }

        public void Update()
        {
            Console.WriteLine("Vem vill du uppdatera?"); //Listar namn
            for(int i = 0; i < userList.Count; i++)  
            {
                Console.WriteLine("Namn: " + userList[i].Name);
                string inputC = Console.ReadLine();

                if (inputC == userList[i].Name) // Om input matchar namn, frågar om vad man vill uppdatera
                {
                    
                    
                    Console.WriteLine("- Vad vill du uppdatera?");
                    Console.WriteLine("- Namn: " + userList[i].Name);
                    Console.WriteLine("- Efternamn: " + userList[i].SurName);
                    Console.WriteLine("- Smeknamn: " + userList[i].Nickname);
                    Console.WriteLine("- Email: " + userList[i].Email);
                    Console.WriteLine("- LinkedIn: " + userList[i].LinkedIn);
                    Console.WriteLine("- Facebook: " + userList[i].Facebook);
                    Console.WriteLine("- Instagram: " + userList[i].Instagram);
                    Console.WriteLine("- Twitter: " + userList[i].Twitter);
                    Console.WriteLine("- Github: " + userList[i].Github);
                    Console.WriteLine("- Favoritmat: " + userList[i].FavFood);
                    Console.WriteLine("- Hatmat: " + userList[i].HateFood);
                    Console.WriteLine("- Favoritdjur: " + userList[i].FavAnimal);
                    Console.WriteLine("- Favoritfilm-genre: " + userList[i].FavMovieGenre);
                    Console.WriteLine("- Blockad: " + userList[i].IsBlocked);
                    Console.WriteLine("- Ghostad: " + userList[i].IsGhosted);


                    string userChoice2 = Console.ReadLine(); // switchfunktion för edit av specifikt object
                    switch (userChoice2.ToLower())
                    {
                        case "namn":
                            Console.WriteLine("Ange namn: ");
                            userList[i].Name = Console.ReadLine();
                            break;
                        case "efternamn":
                            Console.WriteLine("Ange efternamn: ");
                            userList[i].SurName = Console.ReadLine();
                            break;
                        case "smeknamn":
                            Console.WriteLine("Ange smeknamn: ");
                            userList[i].Nickname = Console.ReadLine();
                            break;
                        case "email":
                            Console.WriteLine("Ange Email: ");
                            userList[i].Email = Console.ReadLine();
                            break;
                        case "linkedin":
                            Console.WriteLine("Ange LinkedIn: ");
                            userList[i].LinkedIn = Console.ReadLine();
                            break;
                        case "facebook":
                            Console.WriteLine("Ange Facebook: ");
                            userList[i].Facebook = Console.ReadLine();
                            break;
                        case "instagram":
                            Console.WriteLine("Ange Instagram: ");
                            userList[i].Instagram = Console.ReadLine();
                            break;
                        case "twitter":
                            Console.WriteLine("Ange Twitter: ");
                            userList[i].Twitter = Console.ReadLine();
                            break;
                        case "github":
                            Console.WriteLine("Ange Github-konto: ");
                            userList[i].Github = Console.ReadLine();
                            break;
                        case "favoritmat":
                            Console.WriteLine("Ange favoritmat: ");
                            userList[i].FavFood = Console.ReadLine();
                            break;
                        case "hatmat":
                            Console.WriteLine("Ange hatmat: ");
                            userList[i].HateFood = Console.ReadLine();
                            break;
                        case "favoritdjur":
                            Console.WriteLine("Ange favoritdjur: ");
                            userList[i].FavAnimal = Console.ReadLine();
                            break;
                        case "favorit filmgenre":
                            Console.WriteLine("Ange favorit filmgenre: ");
                            userList[i].FavMovieGenre = Console.ReadLine();
                            break;
                        case "blockad":
                            userList[i].IsBlocked = false;
                            Console.WriteLine("Vill du blockera användare?(Y/N)");
                            
                            bool dumbLoop = true;
                            while (dumbLoop == true)   // två bool funktioner för att ändra ghosted och block.
                            {
                                string blockedInput = Console.ReadLine();
                                if (blockedInput == "Y")
                                {
                                    userList[i].IsBlocked = true;
                                    dumbLoop = false;
                                }
                                if (blockedInput == "N")
                                {
                                    userList[i].IsBlocked = false;
                                    dumbLoop = false;
                                }
                                else
                                {
                                    Console.WriteLine("Ange Y eller N");
                                    dumbLoop = true;
                                }
                            }
                            break;
                            case "ghostad":
                            userList[i].IsGhosted = false;
                            Console.WriteLine("Vill du ghosta användare?");
                            string ghostInput = Console.ReadLine();
                          
                                if (ghostInput.ToLower() == "y")
                                {
                                    userList[i].IsGhosted = true;
                                    
                                }
                                if (ghostInput.ToLower() == "n")
                                {
                                    userList[i].IsGhosted = false;
                                    
                                }
                             
                            
                            break;

                            default:

                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Klicka på valfri knapp för att komma tillbaka till menyn.");
                    Console.ReadKey();
                    Console.Clear();
                }
            };

          

            
        }
  

        public void ListAll()
        {
            for (int i = 0; i < userList.Count; i++)  //Listar namn som finns
            {               
                Console.WriteLine("Namn: " + userList[i].Name);
            };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Klicka på valfri knapp för att komma tillbaka till menyn.");
            Console.ReadKey();
            Console.Clear();


        }

        public void ListByLetter() // Listar namn efter bokstav man anger.
        {
            Console.WriteLine("Ange bokstav du vill lista: ");
            string inputLetter = Console.ReadLine();

            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Name.ToLower().StartsWith(inputLetter.ToLower()))
                {
                    Console.WriteLine("Namn: " + userList[i].Name);
                    Console.WriteLine("Efternamn: " + userList[i].SurName);

                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Klicka på valfri knapp för att komma tillbaka till menyn.");
            Console.ReadKey();
            Console.Clear();

        }
        public void Read()
        {
            Console.WriteLine("Vem vill du visa?");
            for (int i = 0; i < userList.Count; i++)  //Listar namn som finns
            {
                
                Console.WriteLine("Namn: " + userList[i].Name);

            };

            string inputA = Console.ReadLine();

            for (int i = 0; i < userList.Count; i++) // Visar användare efter vald input.
            {
                if (inputA == userList[i].Name) 
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Namn: " + userList[i].Name);
                    Console.WriteLine("Efternamn: " +userList[i].SurName);
                    Console.WriteLine("Smeknamn: " +userList[i].Nickname);
                    Console.WriteLine("Email: " +userList[i].Email);
                    Console.WriteLine("LinkedIn: " +userList[i].LinkedIn);
                    Console.WriteLine("Facebook: " +userList[i].Facebook);
                    Console.WriteLine("Instagram: " +userList[i].Instagram);
                    Console.WriteLine("Twitter: " +userList[i].Twitter);
                    Console.WriteLine("Github: " + userList[i].Github);
                    Console.WriteLine("Favoritmat: " + userList[i].FavFood);
                    Console.WriteLine("Hatmat: " + userList[i].HateFood);
                    Console.WriteLine("Favoritdjur: " + userList[i].FavAnimal);
                    Console.WriteLine("Favorit film-genre: " + userList[i].FavMovieGenre);
                    Console.WriteLine("Är blockad?" + userList[i].IsBlocked);
                    Console.WriteLine("Är ghostad?" + userList[i].IsGhosted);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Klicka på valfri knapp för att komma tillbaka till menyn.");
                    Console.ReadKey();
                    Console.Clear();




                }
            }


        }
    }
}
