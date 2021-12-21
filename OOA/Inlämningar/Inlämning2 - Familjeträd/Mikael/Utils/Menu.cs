using Inlämning_2_EntityFramwork.Models;
using Inlämning_2_EntityFramwork.Utils;
using System.Linq;

namespace Inlämning_2_EntityFramwork
{
    public class Menu
    {
        public void startMenu() // Meny, switch som startar olika metoder.
        {
            ContentCreator addContent = new();
            addContent.ContentCreation();

            Console.WriteLine("Välkommen! ");

            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Lägga till en karaktär");
            Console.WriteLine("2. Uppdatera en karaktär");
            Console.WriteLine("3. Ta bort en karaktär");
            Console.WriteLine("4. Lista alla karaktärer");
            Console.WriteLine("5. Visar vald karaktärs föräldrar");
            Console.WriteLine("6. Lista samtliga karaktärer som har en mor i databasen");
            Console.WriteLine("7. Visa karaktärer som är födda ett specifikt år");
            Console.WriteLine("Vad vill du göra?");

            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int caseDecide);

            switch (caseDecide)
            {
                case 1:
                    AddCharacter();
                    break;

                case 2:
                    UpdateCharacter();
                    break;

                case 3:
                    RemoveCharacter();
                    break;

                case 4:
                    ShowCharacters();
                    break;

                case 5:
                    WhoIsParents();
                    break;

                case 6:
                    ListAllChildren();
                    break;
                case 7:
                    ShowCharactersByBirthYear();
                    break;

                default:
                    break;
            }
        }

        public void AddCharacter() //Addera karaktär tilll lista
        {
            using (var addCharacter = new DBClass())
            {
                Console.WriteLine("Vem vill du lägga till, ange namn: ");
                var addCharacterName = Console.ReadLine();

                Console.WriteLine("Ange efternamn: ");
                var addCharacterLastname = Console.ReadLine();

                Console.WriteLine("Ange födelseår: ");
                string userInput2 = Console.ReadLine();
                int.TryParse(userInput2, out int addCharacterBirthy);

                Console.WriteLine("Ange dödsår: ");
                string userInput3 = Console.ReadLine();
                int.TryParse(userInput3, out int addCharacterDeathy);

                Console.WriteLine("Ange Pappa: ");
                var addCharacterFatherString = Console.ReadLine();
                int.TryParse(addCharacterFatherString, out var addCharacterFather);

                Console.WriteLine("Ange Mamma: ");
                var addCharacterMotherString = Console.ReadLine();
                int.TryParse(addCharacterMotherString, out var addCharacterMother);
             

                Person b = new Person()
                {
                    Name = addCharacterName,
                    LastName = addCharacterLastname,
                    BirthYear = addCharacterBirthy,
                    DeathYear = addCharacterDeathy,
                    Father = addCharacterFather,
                    Mother = addCharacterMother,
                };

                addCharacter.People.Add(b);
                addCharacter.SaveChanges();
            }
        }

        public void UpdateCharacter() //Uppdatera existerande karaktär.
        {
            using (var updateCharacter = new DBClass())
            {
                Console.WriteLine("Ange namn på den du vill uppdatera: ");
                var userUpdateInput = Console.ReadLine();

                var updateCharacterString = updateCharacter.People.Where(u => u.Name == userUpdateInput).First();

                if(updateCharacterString != null)
                {
                    Console.WriteLine("Steg efter steg får du ange vad du vill ändra kategorierna till: ");
                    Console.WriteLine("Namn: ");
                    var updateName = Console.ReadLine();
                    updateCharacterString.Name = updateName;

                    Console.WriteLine("Efternamn: ");
                    var updateLastName = Console.ReadLine();
                    updateCharacterString.LastName = updateLastName;

                    Console.WriteLine("Födelseår: ");
                    var updateBirthYear = Console.ReadLine();
                    int.TryParse(updateBirthYear, out var updateBirthYearInt);
                    updateCharacterString.BirthYear = updateBirthYearInt;

                    Console.WriteLine("Dödsår: ");
                    var updateDeathYear = Console.ReadLine();
                    int.TryParse(updateBirthYear, out var updateDeathYearInt);
                    updateCharacterString.DeathYear = updateDeathYearInt;

                    Console.WriteLine("Pappa-ID: ");
                    var fatherIDString = Console.ReadLine();
                    int.TryParse(fatherIDString, out var fatherID);
                    updateCharacterString.Father = fatherID;

                    Console.WriteLine("Mamma-id: ");
                    var motherIDString = Console.ReadLine();
                    int.TryParse(updateBirthYear, out var motherID);
                    updateCharacterString.Mother = motherID;

                    updateCharacter.People.Update(updateCharacterString);
                    updateCharacter.SaveChanges();
                    Console.WriteLine("Karaktär uppdaterad.");

                }
            }
        }

        public void RemoveCharacter() //Ta bort karaktär i lista - ibland gnäller denna om string to INT. osäker?
        {
            using (var deleteCharacter = new DBClass())
            {
                Console.WriteLine("Vem vill du radera?");
                string deleteChoice = Console.ReadLine();

                var deleteChoiceChecker = deleteCharacter.People.Where(x => x.Name == deleteChoice).ToList();

                if (deleteChoiceChecker != null)
                {
                    Console.WriteLine(deleteChoice + " finns inte.");
                }
                else
                {
                    foreach (var i in deleteCharacter.People.ToList())
                    {
                        deleteCharacter.People.Remove(i);
                    }
                }
                deleteCharacter.SaveChanges();
            }
        }

        public void ShowCharacters() // Visa samtliga karaktärer i databas
        {
            using (var listCharacter = new DBClass())
            {
                listCharacter.People.ToList().ForEach(person => Console.WriteLine(person.Name + " " + person.LastName));
            }
        }


        public void ShowCharactersByBirthYear() // Visa karaktärer efter önskat födelseår.
        { 
            using (var peakyBlinder = new DBClass())
            {
                Console.WriteLine("Skriv in önskat födelseår: ");
                string birthYearString = Console.ReadLine();
                int.TryParse(birthYearString, out int birthYear);
                Console.WriteLine(birthYear);

                var peopleBornThisYear = peakyBlinder.People.Where(n => n.BirthYear.Equals(birthYear)).ToList();

                peopleBornThisYear.ForEach(person => Console.WriteLine("Född år " +birthYear+":" + person.Name));
            }
        }

        public void WhoIsParents() // visa vem som är förälder för ett barn. Fick problem här då jag gjorde om mothter+father från string till int. Missförstått detta tidigare.
        {
            Console.Clear();
            Console.WriteLine("Du valde att söka efter vem som är förälder för ett barn. ");
            using (var findParent = new DBClass())
            {
                Console.WriteLine("Vem vill du undersöka?");
                var childName = Console.ReadLine();
                var children = findParent.People.Where(n => n.Name.Contains(childName)).ToList();
           
                children.ForEach(person => Console.WriteLine(person.Name + "s föräldrar är " + person.Mother + " och " + person.Father));                
            }
        }

        public void ListAllChildren() // Lista samtliga barn.
        {
            Console.Clear();
            Console.WriteLine("Du valde att visa samtliga karaktärer som har en mamma i databasen: ");
            using (var listAllChildren = new DBClass())
            {
                var hasMother = listAllChildren.People.Where(t => t.Mother.HasValue).ToList();

                hasMother.ForEach(person => Console.WriteLine(person.Mother +" är " + person.Name + "s mamma."));
                
            }
        }
    }
}