using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

using Family.Models;
using Family.Database;

namespace Family 
{
    public static class NotMain
    {
        static int choice = 0;
        public static void Populate(PersonContext db)
        {
            //Befolkar Databasen... 
  
            Modify.AddPerson
                (
                db: db,
                name: "Gustav",
                house: "av Holstein - Gottorp",
                male: true,
                regnalNumber: "III",
                title: "Sveriges, Götes och Vendes Konung",
                dateOfBirth: new DateTime(1746, 1, 13),
                dateOfDeath: new DateTime(1792, 3, 29)

                );
 
             Modify.AddPerson
                (
                db: db,
                name: "Sofia Albertina",
                house: "av Holstein - Gottorp",
                male: false,
 
                dateOfBirth: new DateTime(1753, 10, 8),
                dateOfDeath: new DateTime(1829, 3, 17)

                );

 
            Modify.AddPerson
               (
               db: db,
               name: "Lovisa Ulrika",
               house: "Hohenzollern",
               male: false,

               dateOfBirth: new DateTime(1720, 7, 24),
               dateOfDeath: new DateTime(1782, 7, 16)

               );

 
            Modify.AddPerson
               (
               db: db,
               name: "Christian August",
               house: "av Holstein - Gottorp",
               male: true,
               title : "furstbiskop av Lübeck",
               dateOfBirth: new DateTime(1673, 1, 11),
               dateOfDeath: new DateTime(1726, 4, 24)

               );
 
            Modify.AddPerson
               (
               db: db,
               name: "Albertine Friederike",
               house: "av Baden-Durlach",
               male: false,
 
               dateOfBirth: new DateTime(1682, 7, 3),
               dateOfDeath: new DateTime(1755, 12, 22)

               );
 

            Modify.AddPerson
               (
               db: db,
               name: "Friedrich Wilhelm",
               house: "Hohenzollern",
               male: true,
                title : "Kung i Preussen",
                 regnalNumber : "I",
               dateOfBirth: new DateTime(1688, 8, 14),
               dateOfDeath: new DateTime(1740, 5, 31)

               );

 

            Modify.AddPerson
               (
               db: db,
               name: "Sofia Dorotea",
               house: "av Hanover",
               male: false,
 
               dateOfBirth: new DateTime(1688, 8, 14),
               dateOfDeath: new DateTime(1740, 5, 31)

               );

 
            Modify.AddPerson
               (
               db: db,
               name: "Karl",
               house: "av Holstein - Gottorp",
               male: true,
                regnalNumber : "XIII",
                 title : "Sveriges, Götes och Vendes Konung",
               dateOfBirth: new DateTime(1748, 10, 7),
               dateOfDeath: new DateTime(1818, 2, 5)

               );

 

            Modify.AddPerson
               (
               db: db,
               name: "Fredrik Adolf",
               house: "av Holstein - Gottorp",
               male: true,
 
               dateOfBirth: new DateTime(1750, 7, 18),
               dateOfDeath: new DateTime(1803, 12, 12)

               );

 

            Modify.AddPerson
               (
               db: db,
               name: "Fredrik",
               house: "Hohenzollern",
               male: true,
               royalEpithet : "Den Store",
               regnalNumber : "II",
               title : "Kung av Preussen",
               dateOfBirth: new DateTime(1712, 1, 24),
               dateOfDeath: new DateTime(1786, 8, 17)

               );


 
            Modify.AddPerson
               (
               db: db,
               name: "Freidrich August",
               house: "av Holstein-Gottorp",
               male: true,
 
               regnalNumber: "I",
               title: "hertig av Oldenburg",
               dateOfBirth: new DateTime(1711, 9, 20),
               dateOfDeath: new DateTime(1785, 7, 6)

               );

 

            Modify.AddPerson
               (
               db: db,
               name: "Johanna Elisabet",
               house: "av Holstein-Gottorp",
               male: false,
 
               title: "furstinna av Anhalt-Zerbst",
               dateOfBirth: new DateTime(1712, 10, 24),
               dateOfDeath: new DateTime(1760, 5, 30)

               );

 

            Modify.AddPerson
               (
               db: db,
               name: "Georg",
               house: "av Holstein-Gottorp",
               male: true,

 
               dateOfBirth: new DateTime(1719, 3, 16),
               dateOfDeath: new DateTime(1763, 9, 7)

               );

            Modify.AddPerson
               (
               db: db,
               name: "Katarina",
               house: "Holstein-Gottorp-Romanov",
               male: false,
               title : "Kejsarinna av Ryssland",
               royalEpithet : "Den Stora",
               regnalNumber : "II",

               dateOfBirth: new DateTime(1729, 4, 21),
               dateOfDeath: new DateTime(1796, 11, 6)



               );

              
            Modify.AddPerson
               (
               db: db,
               name: "Adolf Fredrik",
               house: "av Holstein-Gottorp",
               male: true,
               title: "Sveriges, Götes och Vendes Konung",
 

               dateOfBirth: new DateTime(1710, 5, 14),
               dateOfDeath: new DateTime(1771, 2, 12)



               );



            Models.Person child = new();
            Models.Person parent = new();

            List<string> childNames = new List<string> { "Gustav"        , "Karl"         ,"Fredrik Adolf"  ,"Sofia Albertina", "Lovisa Ulrika"    , "Adolf Fredrik"       , "Fredrik"          , "Freidrich August"    , "Johanna Elisabet"    , "Georg"               , "Katarina" };
            List<string> motherNames = new List<string> { "Lovisa Ulrika", "Lovisa Ulrika", "Lovisa Ulrika" , "Lovisa Ulrika" , "Sofia Dorotea"    , "Albertine Friederike", "Sofia Dorotea"    , "Albertine Friederike", "Albertine Friederike", "Albertine Friederike", "Johanna Elisabet" };
            List<string> fatherNames = new List<string> { "Adolf Fredrik", "Adolf Fredrik", "Adolf Fredrik" , "Adolf Fredrik ", "Friedrich Wilhelm", "Christian August"    , "Friedrich Wilhelm", "Christian August"    , "Christian August"    , "Christian August"    , null}; //Johanna Elisabet gifte sig med
                                                                                                                                                                                                                                                                                  // en snubbe med exakt samma namn som sin far.
                                                                                                                                                                                                                                                                                  // Jag gitter inte ändra programmet för att 
                                                                                                                                                                                                                                                                                  // ackommodera den sortens freudianska dumheter. Därför null.
            for (int i = 0; i < childNames.Count; i++)
            {
                child = db.Persons.FirstOrDefault(f => f.Name == childNames[i]);
                parent = db.Persons.FirstOrDefault(f => f.Name == motherNames[i]);

                Modify.AddParent(db, child, parent);
                parent = db.Persons.FirstOrDefault(f => f.Name == fatherNames[i]);
                if (parent != null)
                {
                    Modify.AddParent(db, child, parent);
                }
            }

            //var dublett = db.Persons.FirstOrDefault(f => f.ID == 16);
            //Modify.Delete(db, dublett);

            //Miscellaneous.CallAddPerson(db);

            //var modifiera = db.Persons.FirstOrDefault(f => f.ID == 17);
            //Modify.Update(db, modifiera);

        }




        public static void MainLoop(PersonContext db)
        {
            int chosenPersonId = 0;
            int secondChosenPersonId = 0;
            //int choice = 0;
            string chosenPersonString;
            string secondChosenPersonString;

            bool go_on = true;
            while (go_on)
            {
                if (chosenPersonId != 0 && chosenPersonId != -99)
                {
                    var chosenPerson = db.Persons.FirstOrDefault(f => f.ID == chosenPersonId);
                    //Console.ForegroundColor = ConsoleColor.Yellow; Console.BackgroundColor = ConsoleColor.Red;
                    //Console.WriteLine();
                    chosenPersonString=(chosenPerson.Name + " " + chosenPerson.House + "(" + chosenPerson.DateOfBirth.Value.Year +"-"+ chosenPerson.DateOfDeath.Value.Year+")"); //ändra datetime  tillbaka till ickenullable om du hinner
                }
                else
                {
                    chosenPersonString = " Ingen person vald";
                }

                if (secondChosenPersonId != 0 && secondChosenPersonId != -99)
                {
                    var secondChosenPerson = db.Persons.FirstOrDefault(f => f.ID == secondChosenPersonId);
                    //Console.ForegroundColor = ConsoleColor.Yellow; Console.BackgroundColor = ConsoleColor.Red;
                    //Console.WriteLine();
                   secondChosenPersonString = (secondChosenPerson.Name + " " + secondChosenPerson.House + "(" + secondChosenPerson.DateOfBirth.Value.Year + "-" + secondChosenPerson.DateOfDeath.Value.Year + ")"); //ändra datetime  tillbaka till ickenullable om du hinner
                }
                else
                {
                    secondChosenPersonString = " Ingen person vald";
                }

                //Console.ForegroundColor = ConsoleColor.Yellow; Console.BackgroundColor = ConsoleColor.Red;
                //Console.WriteLine(chosenPersonString);
                //Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black;

                string mainTitle = ("första valda person: " + chosenPersonString + " andra valda person: " + secondChosenPersonString);

                Menu(Miscellaneous.MainMenuOptions, mainTitle);
                int mainChoice=LetUserChoose(Miscellaneous.MainMenuOptions);
                switch (mainChoice)
                {
                    case -1:


                        int returnMe = 0;
                        do
                        {
                            List<(string, int)> allPersons = Miscellaneous.BuildMenu("all", db);
                            Menu(allPersons, "pilar navigerar, enter väljer");
                            returnMe =  LetUserChoose(allPersons);
                            //allReturn =  LetUserChoose(allPersons, true);
                        } while (returnMe == 0);
                        chosenPersonId = returnMe;
                        break;

                    case -2:

                        //        Console.WriteLine("förnamnsbegynnelsebokstav...");
                        returnMe = 0;
                        
                            int w = Console.WindowWidth;
                            int h = Console.WindowHeight;
                            Console.SetCursorPosition((w / 2) - 10, (h / 2) - 2);
                            Console.Write("+------------------------+");
                            Console.SetCursorPosition((w / 2) - 10, (h / 2) - 1);

                            Console.Write("|   mata in bokstav...  |");
                            Console.SetCursorPosition((w / 2) - 10, (h / 2)  );

                            Console.Write("|                        |");
                            Console.SetCursorPosition((w / 2) - 10, (h / 2) + 1 );

                            Console.Write("|                        |");
                            Console.SetCursorPosition((w / 2) - 10, (h / 2) + 2);

                            Console.Write("+------------------------+");
                        Console.SetCursorPosition((w / 2) - 3, (h / 2));
                        string myLetter = Console.ReadLine();
                        do
                        {



                                List<(string, int)> letterPersons = Miscellaneous.BuildMenu("letter", db, myLetter);
                            Menu(letterPersons, "pilar navigerar, enter väljer");
                            returnMe = LetUserChoose(letterPersons);
                            
                        } while (returnMe == 0);

                        if (returnMe != -99 ) chosenPersonId = returnMe;
                        break;


                    case -3:

                        //        Console.WriteLine("födelseår...");
                        returnMe = 0;
                        int year = 0;
                        int w2 = Console.WindowWidth;
                        int h2 = Console.WindowHeight;
                        Console.SetCursorPosition((w2 / 2) - 10, (h2 / 2) - 2);
                        Console.Write("+------------------------+");
                        Console.SetCursorPosition((w2 / 2) - 10, (h2 / 2) - 1);

                        Console.Write("|   mata in årtal...    |");
                        Console.SetCursorPosition((w2 / 2) - 10, (h2 / 2));

                        Console.Write("|                        |");
                        Console.SetCursorPosition((w2 / 2) - 10, (h2 / 2) + 1);

                        Console.Write("|                        |");
                        Console.SetCursorPosition((w2 / 2) - 10, (h2 / 2) + 2);

                        Console.Write("+------------------------+");
                        do
                        {
                            Console.SetCursorPosition((w2 / 2) -3 , (h2 / 2));
                            //string myLetter = Console.ReadLine();
                        } while (!int.TryParse(Console.ReadLine(), out   year));
                        do
                        {



                            List<(string, int)> yearPersons = Miscellaneous.BuildMenu("year", db, numericParameter : year);
                            Menu(yearPersons, "pilar navigerar, enter väljer");
                            returnMe = LetUserChoose(yearPersons);

                        } while (returnMe == 0);
                        chosenPersonId = returnMe;


                        break;

                    case -4: //syskon
                         returnMe = 0;
                        var chosen = db.Persons.FirstOrDefault(f => f.ID == chosenPersonId);
                        do
                        {
                            List<(string, int)> siblings = Miscellaneous.BuildMenu("sibling", db,  chosen: chosen);
                            Menu(siblings, "pilar navigerar, enter väljer");
                            returnMe = LetUserChoose(siblings);
                            //allReturn =  LetUserChoose(allPersons, true);
                        } while (returnMe == 0);
                        chosenPersonId = returnMe;
                        break;

                    // 

                    //        Console.WriteLine("vald persons föräldrar");
                    case -5:
                        returnMe = 0;
                        chosen = db.Persons.FirstOrDefault(f => f.ID == chosenPersonId);
                        do
                        {
                            List<(string, int)> parents = Miscellaneous.BuildMenu("parent", db, chosen: chosen);
                            Menu(parents, "pilar navigerar, enter väljer");
                            returnMe = LetUserChoose(parents);
                            //allReturn =  LetUserChoose(allPersons, true);
                        } while (returnMe == 0);
                        chosenPersonId = returnMe;


                        break;

                    case -6:

                    //        Console.WriteLine("vald persons föräldrarföräldrar");
             
                        returnMe = 0;
                        chosen = db.Persons.FirstOrDefault(f => f.ID == chosenPersonId);
                        do
                        {
                            List<(string, int)> parents = Miscellaneous.BuildMenu("parentparent", db, chosen: chosen);
                            Menu(parents, "pilar navigerar, enter väljer");
                            returnMe = LetUserChoose(parents);
                            //allReturn =  LetUserChoose(allPersons, true);
                        } while (returnMe == 0);
                        chosenPersonId = returnMe;

                        break;

 
                    //("9. Välj andra  person från alla personer med förnamnsbegynnelsebokstav...  ",-9),
                    //("10. Välj andra  person från alla personer födda kring födelseår...   ",-10),
                    //("11. Gör andra  person till första persons förälder...   ",-11),

                   
                    case -7:
                        // barn
                        chosen = db.Persons.FirstOrDefault(f => f.ID == chosenPersonId);
                        do
                        {
                            List<(string, int)> children = Miscellaneous.BuildMenu("children", db, chosen: chosen);
                            Menu(children, "pilar navigerar, enter väljer");
                            returnMe = LetUserChoose(children);
                            //allReturn =  LetUserChoose(allPersons, true);
                        } while (returnMe == 0);
                        chosenPersonId = returnMe;

                        break;

                    case -8:

                        returnMe = 0;
                        do
                        {
                            List<(string, int)> allPersons = Miscellaneous.BuildMenu("all", db);
                            Menu(allPersons, "pilar navigerar, enter väljer");
                            returnMe = LetUserChoose(allPersons);
                            //allReturn =  LetUserChoose(allPersons, true);
                        } while (returnMe == 0);
                        secondChosenPersonId = returnMe;
                        break;

                        break;
                    //case -9:

                    //    break;
                    //case -10:

                    //    break;
                    case -11:

                        var child = db.Persons.FirstOrDefault(f => f.ID == chosenPersonId);
                        var parent = db.Persons.FirstOrDefault(f => f.ID == secondChosenPersonId);
                        if ( child != null && parent != null )
                        {
 

                            Modify.AddParent(db, child, parent);
                        }


                        break;
                    case -12:
                        if (chosenPersonId != 0 && chosenPersonId != -99)
                        {
                            var displayMe = db.Persons.FirstOrDefault(f => f.ID == chosenPersonId);
                            Miscellaneous.Display(db, displayMe);
                        }
                        break;
                    case -13:
                        if (chosenPersonId != 0 && chosenPersonId != -99)
                        {
                            var updateMe = db.Persons.FirstOrDefault(f => f.ID == chosenPersonId);
                            Modify.Update(db, updateMe);
                        }
                            break;
                    case -14:
                        if (chosenPersonId != 0 && chosenPersonId != -99)
                        {
                            var deleteMe = db.Persons.FirstOrDefault(f => f.ID == chosenPersonId);
                            Modify.Delete(db,deleteMe);
                            chosenPersonId = 0;
                        }
                        break;
                    case -15:
                        Miscellaneous.CallAddPerson(db);
                        break;

                    default:

                        // gör ingenting - åk en runda till.
                        break;
                }
            }




        }



        //Gör dessa sen...
        public static void Menu(List<(string, int)> options, string title)
        {
            Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow; Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White; Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.CursorVisible = false;


 
            for (int i = 0; i < options.Count; i++)
            {
 
                if (i == choice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(  options[i].Item1);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine( options[i].Item1);
                }
            }
        }

        public static int LetUserChoose(List<(string, int)> options)
        {
            if (options.Count == 0) return 0;
            if (choice > options.Count - 1) choice = 0;
            ConsoleKey readKey = Console.ReadKey().Key;
            if (readKey == ConsoleKey.DownArrow)
            {
                choice++;
                choice = choice % options.Count;
                return 0;
            }

            else if (readKey == ConsoleKey.UpArrow)
            {

                if (choice == 0)
                {
                    choice = options.Count - 1;
                    return 0;
                }

                else
                {
                    choice--;
                    return 0;
                }
            }

            // if (!isChoosePersonMenu && readKey == ConsoleKey.Enter)

            if (readKey == ConsoleKey.Enter)
            {
                Console.ForegroundColor = ConsoleColor.White;
                return options[choice].Item2;
            }

            // else if (!isChoosePersonMenu) // Alla tangentnedslag som inte är upp, ned eller enter gör ingenting i
            else
            {                             // meny där man ej väljer en person
                return 0;
            }

            // else if (readKey == ConsoleKey.Enter)
            // {
            // choice = choice % options.Count;
            // DisplayPerson(options[choice].Item2);
            // return ' ';
            // }

            // else if (readKey == ConsoleKey.Delete)
            // {
            // DeletePerson(options[choice].Item2);
            // return ' ';
            // }
            // else if (readKey == ConsoleKey.Insert)
            // {
            // EditPerson(options[choice].Item2);
            // return ' ';
            // }
            // else if (readKey == ConsoleKey.End)
            // {
            // BlockDeblockPerson(options[choice].Item2);
            // return ' ';
            // }
            // else if (readKey == ConsoleKey.PageDown)
            // {
            // GhostDeghostPerson(options[choice].Item2);
            // return ' ';
            // }
            // else if (readKey == ConsoleKey.Home)
            // {
            // return '!';
            // }
            // else if (readKey == ConsoleKey.OemPlus)
            // {
            // AddPerson();
            // return '!';
            // }
            // else  // Som ovan, alla övriga tangenter gör ingenting.
            // {
            // return ' ';
            // }




 
        }



    }
}
