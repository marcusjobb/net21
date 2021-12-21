using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FamilyTree.Utils
{
    public class Menu
    {
        public static void StartMenu()
        {
            Visuals.HPLogo();

            while (true)
            {
                Visuals.mainMenu();
                var input = UserInput();
                switch (input)
                {
                    case 1:
                        AddSubMenu();
                        var inputA = UserInput();
                        switch (inputA)
                        {
                            //lägg till person
                            case 1:
                                Console.Clear();
                                AddPerson();
                                break;

                            //lägg till födelseplats
                            case 2:
                                Console.Clear();
                                AddBP();
                                break;

                            //lägg till dödsplats
                            case 3:
                                Console.Clear();
                                AddDP();
                                break;
                        }
                        break;
                    
                    case 2:
                        SearchMother();
                        break;
                    
                    case 3:
                        SearchFather();
                        break;
                    
                    case 4:
                        EditSubMenu();
                        var inputE = UserInput();
                        switch (inputE)
                        {
                            //edit namn
                            case 1:
                                Editfullname();
                                break;

                            //edit födelseår
                            case 2:
                                Editbirthyear();
                                break;

                            //edit dödsår
                            case 3:
                                Editdeathyear();
                                break;

                            //edit födelseplats
                            case 4:
                                Editbirthplace();
                                break;

                            //edit dödsplats
                            case 5:
                                Editdeathplace();
                                break;

                            //Gå tillbaka till huvudmenyn
                            case 6:
                                continue;

                            default: //felhantering
                                Console.Clear();
                                Console.WriteLine("Choose a number from the menu!");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    
                    case 5:
                        DeleteSubMenu();
                        var inputD = UserInput();
                        switch (inputD)
                        {
                            //Ta bort via id
                            case 1:
                                RemoveID();
                                break;

                            //Ta bort via namn
                            case 2:
                                RemoveName();
                                break;
                            //Gå tillbaka till huvudmenyn
                            case 3:
                                continue;

                            default: //felhantering
                                Console.Clear();
                                Console.WriteLine("Choose a number from the menu!");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    
                    case 6:
                        EveryoneSubMenu();
                        var inputES = UserInput();
                        switch (inputES)
                        {
                            //Visa alla
                            case 1:
                                Console.Clear();
                                FamilyCrud.ShowEverybody();
                                BackToMenu();
                                break;

                            //Visa alla efter efternamn
                            case 2:
                                Console.Clear();
                                FamilyCrud.ShowEverybodyOrder();
                                BackToMenu();
                                break;

                            //Visa alla och födelseplats
                            case 3:
                                Console.Clear();
                                FamilyCrud.ShowBP();
                                BackToMenu();
                                break;
                            //Gå tillbaka till huvudmenyn
                            case 4:
                                continue;

                            default: //felhantering
                                Console.Clear();
                                Console.WriteLine("Choose a number from the menu!");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    
                    case 7:
                        SearchSubMenu();
                        var inputS = UserInput();
                        switch (inputS)
                        {
                            //Sök på efternamn
                            case 1:
                                SearchLastName();
                                break;

                            //Sök personer född specifikt år
                            case 2:
                                SearchYear();
                                break;

                            //Gå tillbaka till huvudmenyn
                            case 3:
                                continue;

                            default: //felhantering
                                Console.Clear();
                                Console.WriteLine("Choose a number from the menu!");
                                Console.ReadKey();
                                break;
                        }
                        break;

                    case 8:
                        ShowSubMenu();
                        var inputSS = UserInput();
                        switch (inputSS)
                        {
                            //Visa alla mor-/farföräldrar
                            case 1:
                                ShowGrandParents();
                                break;

                            //Visa syskon
                            case 2:
                                ShowSibling();
                                break;

                            //Visa barn
                            case 3:
                                ShowChildren();
                                continue;

                            default: //felhantering
                                Console.Clear();
                                Console.WriteLine("Choose a number from the menu!");
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case 0:
                        Exit();
                        break;
                    
                    default: //felhantering
                        Console.Clear();
                        Console.WriteLine("Choose a number from the menu!");
                        Console.ReadKey();
                        break;
                }
                }
            }
        private static void AddSubMenu()
        {
            Console.Clear();
            Console.WriteLine("=======Create something new in the family tree:=======\n");
            Console.WriteLine("[1] Add a new person to the family tree\n" +
                                "[2] Add a new birth place to the family tree\n" +
                                "[3] Add a new death place to the family tree\n" +
                                "[4] Return to main menu\n");
            Console.WriteLine("\n===================================================");
        }
        private static void AddPerson()
        {
            Console.Clear();
            Console.WriteLine("======Add a person to the family tree======\n");
            string fname, lname;
            EnterFirstAandLastName(out fname, out lname);
            Console.WriteLine("Enter a birthdate:");
            var bdate = Console.ReadLine();
            var person = FamilyCrud.FindOrCreatePerson(fname, lname, bdate);
            BackToMenu();
        }
        private static void AddBP()
        {
            Console.Clear();
            Console.WriteLine("======Add a new birth place to the family tree======\n");
            Console.WriteLine("Enter a birth place:");
            var bp = Console.ReadLine();
            Console.WriteLine("Enter a country:");
            var c = Console.ReadLine();
            var newBP = FamilyCrud.CreateBP(bp, c);
            BackToMenu();
        }
        private static void AddDP()
        {
            Console.Clear();
            Console.WriteLine("======Add a new death place to the family tree======\n");
            Console.WriteLine("Enter a birth place:");
            var dp = Console.ReadLine();
            Console.WriteLine("Enter a country:");
            var c = Console.ReadLine();
            var newdP = FamilyCrud.CreateBP(dp, c);
            BackToMenu();
        }
        private static void SearchMother()
        {
            Console.Clear();
            Console.WriteLine("======Search for a person's mother======\n");
            Console.WriteLine("Enter a first name: ");
            var fname = Console.ReadLine();
            Console.WriteLine("Enter a last name: ");
            var lname = Console.ReadLine();
            var currentMother = FamilyCrud.FindMother(fname, lname);
            Console.WriteLine($"\nNow to change {fname} {lname}'s mother ...");
            Console.WriteLine("Enter mother's first name: ");
            var mfname = Console.ReadLine();
            Console.WriteLine("Enter mother's last name: ");
            var mlname = Console.ReadLine();
            var mother = FamilyCrud.SetMother(fname, lname, mfname, mlname);
            BackToMenu();
        }
        private static void SearchFather()
        {
            Console.Clear();
            Console.WriteLine("======Search for a person's father======\n");
            Console.WriteLine("Enter a first name: ");
            var fname = Console.ReadLine();
            Console.WriteLine("Enter a last name: ");
            var lname = Console.ReadLine();
            var currentFather = FamilyCrud.FindFather(fname, lname);
            Console.WriteLine($"\nNow to change {fname} {lname}'s father ...");
            Console.WriteLine("Enter father's first name: ");
            var ffname = Console.ReadLine();
            Console.WriteLine("Enter father's last name: ");
            var flname = Console.ReadLine();
            var father = FamilyCrud.SetFather(fname, lname, ffname, flname);
            BackToMenu();
        }
        private static void EditSubMenu()
        {
            Console.Clear();
            Console.WriteLine("=======Edit a person from the family tree:=======\n");
            Console.WriteLine("[1] Edit full name\n" +
                                "[2] Edit birth year\n" +
                                "[3] Edit death year\n" +
                                "[4] Edit birth place\n" +
                                "[5] Edit death place\n" +
                                "[6] Return to main menu\n");
            Console.WriteLine("\n===================================================");
        }
        private static void Editfullname()
        {
            Console.Clear();
            Console.WriteLine("=====Edit the full name of a person======\n");
            string pfname, plname;
            EnterFirstAandLastName(out pfname, out plname);
            Console.WriteLine("Change first name to: ");
            var fname = Console.ReadLine();
            Console.WriteLine("Change last name to: ");
            var lname = Console.ReadLine();
            var change = FamilyCrud.UpdatePerson(pfname, plname, fname, lname);
            Console.WriteLine($"\nYou changed {pfname} {plname} to {fname} {lname}!");
            BackToMenu();
        }

        private static void Editbirthyear()
        {
            Console.Clear();
            Console.WriteLine("=====Edit the birth year of a person======\n");
            string pfname, plname;
            EnterFirstAandLastName(out pfname, out plname);
            Console.WriteLine("Change birth year to: ");
            var bdate = Console.ReadLine();
            var change = FamilyCrud.UpdateYear(pfname, plname, bdate);
            Console.WriteLine($"\nYou changed {pfname} {plname}'s birth year to {bdate}!");
            BackToMenu();
        }

        private static void Editdeathyear()
        {
            Console.Clear();
            Console.WriteLine("=====Edit the death year of a person======\n");
            string pfname, plname;
            EnterFirstAandLastName(out pfname, out plname);
            Console.WriteLine("Change death year to: ");
            var ddate = Console.ReadLine();
            var change = FamilyCrud.UpdateDeath(pfname, plname, ddate);
            Console.WriteLine($"\nYou changed {pfname} {plname}'s death year to {ddate}!");
            BackToMenu();
        }

        private static void Editbirthplace()
        {
            Console.Clear();
            Console.WriteLine("=====Edit the birth place of a person======\n");
            string pfname, plname;
            EnterFirstAandLastName(out pfname, out plname);
            Console.WriteLine("Change birth place to: ");
            var _bp = Console.ReadLine();
            Console.WriteLine("Change country to: ");
            var _country = Console.ReadLine();
            var change = FamilyCrud.UpdateBP(pfname, plname, _bp, _country);
            Console.WriteLine($"\nYou changed {pfname} {plname}'s birth place to {_bp}, {_country}!");
            BackToMenu();
        }
        private static void Editdeathplace()
        {
            Console.Clear();
            Console.WriteLine("=====Edit the death place of a person======\n");
            string pfname, plname;
            EnterFirstAandLastName(out pfname, out plname);
            Console.WriteLine("Change death place to: ");
            var _dp = Console.ReadLine();
            Console.WriteLine("Change country to: ");
            var _country = Console.ReadLine();
            var change = FamilyCrud.UpdateDP(pfname, plname, _dp, _country);
            Console.WriteLine($"\nYou changed {pfname} {plname}'s birth place to {_dp}, {_country}!");
            BackToMenu();
        }
        private static void DeleteSubMenu()
        {
            Console.Clear();
            Console.WriteLine("=======Remove a person from the family tree:=======\n");
            Console.WriteLine("[1] Search by ID\n" +
                                "[2] Search by full name\n" +
                                "[3] Return to main menu\n");
            Console.WriteLine("\n===================================================");
        }

        private static void RemoveID()
        {
            Console.Clear();
            Console.WriteLine("======Choose which number you want to remove======\n");
            var personID = Convert.ToInt32(Console.ReadLine());
            var remove = FamilyCrud.RemovePerson(personID);
            Console.WriteLine($"You have removed {remove}");
            BackToMenu();
        }

        private static void RemoveName()
        {
            string fname, lname;
            EnterFirstAandLastName(out fname, out lname);
            var remove = FamilyCrud.RemovePerson(fname, lname);
            Console.WriteLine($"You have removed {remove}");
            BackToMenu();
        }
        
        private static void EveryoneSubMenu()
        {
            Console.Clear();
            Console.WriteLine("=======Show from the family tree:=======\n");
            Console.WriteLine("[1] Everyone in the family tree\n" +
                                "[2] Everyone in the order of last name\n" +
                                "[3] Everyone in the order of birth place\n" +
                                "[4] Return to main menu\n");
            Console.WriteLine("\n===================================================");
        }

        private static void SearchSubMenu()
        {
            Console.Clear();
            Console.WriteLine("=======Search in the family tree:=======\n");
            Console.WriteLine("[1] Search for people who's last name contain a specific letter\n" +
                                "[2] Search for people born a specific year\n" +
                                "[3] Return to main menu\n");
            Console.WriteLine("\n===================================================");
        }
        private static void SearchLastName()
        {
            Console.Clear();
            Console.WriteLine("Show the ones who last name contains the letter:\n ");
            var inputL = Console.ReadLine();
            FamilyCrud.FindLastName(inputL);
            BackToMenu();
        }
        private static void SearchYear()
        {
            Console.Clear();
            Console.WriteLine("======Choose which year you want to search for======\n");
            var Useryear = Console.ReadLine();
            FamilyCrud.FindYear(Useryear);
            BackToMenu();
        }
        private static void ShowSubMenu()
        {
            Console.Clear();
            Console.WriteLine("=======Find out more about a certain person=======\n");
            Console.WriteLine("[1] Show a person's grandparents\n" +
                              "[2] Show a person's siblings\n" +
                              "[3] Show a person's children\n" +
                              "[4] Return to main menu\n");
            Console.WriteLine("\n===================================================");
        }
        private static void ShowGrandParents()
        {
            Console.Clear();
            Console.WriteLine("=========Check grandparents=========\n");
            Console.WriteLine("Enter a first name: ");
            var fname = Console.ReadLine();
            Console.WriteLine("Enter a last name: ");
            var lname = Console.ReadLine();
            var check = new Utils.FamilyCrud();
            check.CheckGrandParents(fname, lname);
            BackToMenu();
        }

        private static void ShowSibling()
        {
            Console.Clear();
            Console.WriteLine("======Show siblings for a person======\n");
            string fname, lname;
            EnterFirstAandLastName(out fname, out lname);
            var findsibling = FamilyCrud.CheckSiblings(fname, lname);
            BackToMenu();
        }

        private static void ShowChildren()
        {
            Console.Clear();
            Console.WriteLine("======Show children for a person======\n");
            string fname, lname;
            EnterFirstAandLastName(out fname, out lname);
            var findsibling = FamilyCrud.CheckChildren(fname, lname);
            BackToMenu();
        }




        //----------------MenuHelper--------------------
        private static void EnterFirstAandLastName(out string fname, out string lname)
        {
            Console.Clear();
            Console.WriteLine("Enter a first name: ");
            fname = Console.ReadLine();
            Console.WriteLine("Enter a last name: ");
            lname = Console.ReadLine();
        }
        public static int UserInput()
        {
            int.TryParse(Console.ReadLine(), out int UserInput);
            return UserInput;
        }
        private static void BackToMenu()
        {
            Console.WriteLine("\nPress [ENTER] to continue...");
            Console.WriteLine("================================================");
            Console.ReadLine();
        }
        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("(∩  ^_^ )");
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("\nPress [ENTER] to exit the program ...");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
