using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FamilyTreeApp._Model;
using FamilyTreeApp._Menu;
using FamilyTreeApp._TestDbContext;


namespace FamilyTreeApp._CRUD
{
    class CRUD
    {
        public void start()
        {
            int numStartMenu = 0;
            bool flag = true;
            Menu.startMenu();
            while (flag)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out numStartMenu))
                {
                    if (numStartMenu > 0 && numStartMenu < 3) break;
                    else Console.WriteLine("Invalid value, try again");
                }
                else Console.WriteLine("Invalid value, try again");
            }

            switch (numStartMenu)
            {
                case 1:
                    Console.Write("Enter your name: ");
                    string input1 = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("=================================================");
                    Console.WriteLine(" ..  You Succeeded To Create Family Tree For  .. ");
                    Console.WriteLine(" ..    --<<(((    Harry Potter    )))>>--     .. ");
                    Console.WriteLine(" ..            Go To The Next Step            .. ");
                    Console.WriteLine(" ....              Press Enter              .... ");
                    Console.WriteLine("=================================================");

                    Console.Read();
                    Menu.mainMenuSelection();
                    sitting();
                    break;

                default:    //2) ---> exit
                    Environment.Exit(0);
                    break;
            }

        }

        public void sitting()
        {
            int numMainMenu = 0;
            bool flag = true;

            while (flag)
            {
                Console.Write("Your choises is << 1  -  6 >>: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out numMainMenu))
                {
                    if (numMainMenu > 0 && numMainMenu < 7) break;
                }
                else Console.WriteLine("Invalid value, try again");
            }

            switch (numMainMenu)
            {
                case 1:
                    Console.WriteLine("Enter To Continu");
                    showDetails();
                    break;
                case 2:
                    Console.WriteLine("Enter To Continu");
                    FamilyRelationShip();
                    break;

                case 3:
                    Console.WriteLine("Enter To Continu");
                    EditPerson();
                    break;

                case 4:
                    Console.WriteLine("Enter To Continu");
                    AddPerson();
                    break;

                case 5:
                    Console.WriteLine("Enter To Continu");
                    DeletePerson();
                    break;

                default:    //6) ---> exit
                    Environment.Exit(0);
                    break;
            }
        }


        public void showDetails()
        {
            using (var db = new TestDbContext())
            {
                int numShowDetails = 0;
                Menu.showDetailsMenu();
                while (true)
                {
                    Console.Write("Your choice is << 1  -  10 >>: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out numShowDetails))
                    {
                        if (numShowDetails > 0 && numShowDetails < 11) break;
                    }
                    else Console.WriteLine("Invalid value, try again");
                }

                switch (numShowDetails)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n");
                        var people = db.Persons.ToList();
                        {
                            foreach (var p in people)
                            {
                                Console.WriteLine($"{p.personID}  {p.firstName}  {p.lastName}  {p.Gender} {p.Status} ");
                            }
                        }

                        Console.Write($"There are ");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write($"{people.Count}");
                        Console.ResetColor();
                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n");
                        List<person> people2 = db.Persons.OrderByDescending(x => x.lastName).Take(10).ToList();
                        {
                            foreach (var p2 in people2)
                            {
                                Console.WriteLine($"{p2.personID}  {p2.firstName} {p2.lastName} {p2.Gender}");
                            }
                            Console.Write($"There are ");
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{people2.Count}");
                            Console.ResetColor();
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.Write("Write The Last Name: ");
                        string input3 = Console.ReadLine();
                        List<person> people3 = db.Persons.Where(x => x.lastName == input3).ToList();
                        {
                            foreach (var p3 in people3)
                            {
                                Console.WriteLine($"{p3.personID}  {p3.firstName} {p3.lastName} ");
                            }
                            Console.Write($"There are ");
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{people3.Count}");
                            Console.ResetColor();
                            Console.Write(" Persons Whose Last Name is :  ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{input3}");
                            Console.ResetColor();
                        }

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;


                    case 4:
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.Write("Write The Last Name: ");
                        string input4 = Console.ReadLine();
                        List<person> people4 = db.Persons.Where(x => x.firstName == input4).ToList();
                        {
                            foreach (var p4 in people4)
                            {
                                Console.WriteLine($"{p4.personID}  {p4.firstName} {p4.lastName} ");
                            }
                            Console.Write($"There are ");
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{people4.Count}");
                            Console.ResetColor();
                            Console.Write(" Persons Whose Last Name is :  ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{input4}");
                            Console.ResetColor();
                        }

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("\n");
                        char ch2 = ' ';
                        while (true)
                        {
                            Console.Write("Select a letter: ");
                            string input5 = Console.ReadLine();
                            if (char.TryParse(input5, out ch2))
                            {
                                if (ch2 == 'a' || ch2 == 'A' || ch2 == 'b' || ch2 == 'B' || ch2 == 'c' || ch2 == 'C' || ch2 == 'd' || ch2 == 'D'
                                    || ch2 == 'e' || ch2 == 'E' || ch2 == 'f' || ch2 == 'F' || ch2 == 'g' || ch2 == 'G' || ch2 == 'h' || ch2 == 'H'
                                    || ch2 == 'i' || ch2 == 'I' || ch2 == 'j' || ch2 == 'J' || ch2 == 'k' || ch2 == 'K' || ch2 == 'l' || ch2 == 'L'
                                    || ch2 == 'm' || ch2 == 'M' || ch2 == 'n' || ch2 == 'N' || ch2 == 'o' || ch2 == 'O' || ch2 == 'p' || ch2 == 'P'
                                    || ch2 == 'q' || ch2 == 'Q' || ch2 == 'r' || ch2 == 'R' || ch2 == 's' || ch2 == 'S' || ch2 == 't' || ch2 == 'T'
                                    || ch2 == 'u' || ch2 == 'U' || ch2 == 'w' || ch2 == 'W' || ch2 == 'x' || ch2 == 'X' || ch2 == 'y' || ch2 == 'Y'
                                    || ch2 == 'z' || ch2 == 'Z') break;
                            }
                            else Console.WriteLine("Invalid value, try again");
                        }

                        List<person> people5 = db.Persons.Where(x => x.firstName.StartsWith($"{ch2}")).ToList();
                        {
                            foreach (var p5 in people5)
                            {
                                Console.WriteLine($"{p5.personID}  {p5.firstName} {p5.lastName} ");
                            }
                            Console.Write($"There are ");
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{people5.Count}");
                            Console.ResetColor();
                            Console.Write(" Persons Whose First Name Begins With a Specific Letter ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{ch2}");
                            Console.ResetColor();
                        }

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("\n");
                        char ch = ' ';
                        while (true)
                        {
                            Console.Write("Select a letter: ");
                            string input6 = Console.ReadLine();
                            if (char.TryParse(input6, out ch))
                            {
                                if (ch == 'a' || ch == 'A' || ch == 'b' || ch == 'B' || ch == 'c' || ch == 'C' || ch == 'd' || ch == 'D'
                                    || ch == 'e' || ch == 'E' || ch == 'f' || ch == 'F' || ch == 'g' || ch == 'G' || ch == 'h' || ch == 'H'
                                    || ch == 'i' || ch == 'I' || ch == 'j' || ch == 'J' || ch == 'k' || ch == 'K' || ch == 'l' || ch == 'L'
                                    || ch == 'm' || ch == 'M' || ch == 'n' || ch == 'N' || ch == 'o' || ch == 'O' || ch == 'p' || ch == 'P'
                                    || ch == 'q' || ch == 'Q' || ch == 'r' || ch == 'R' || ch == 's' || ch == 'S' || ch == 't' || ch == 'T'
                                    || ch == 'u' || ch == 'U' || ch == 'w' || ch == 'W' || ch == 'x' || ch == 'X' || ch == 'y' || ch == 'Y'
                                    || ch == 'z' || ch == 'Z') break;
                            }
                            else Console.WriteLine("Invalid value, try again");
                        }

                        List<person> people6 = db.Persons.Where(x => x.lastName.StartsWith($"{ch}")).ToList();
                        {
                            foreach (var p6 in people6)
                            {
                                Console.WriteLine($"{p6.personID}  {p6.firstName} {p6.lastName} ");
                            }
                            Console.Write($"There are ");
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{people6.Count}");
                            Console.ResetColor();
                            Console.Write(" Persons Whose Last Name Begins With a Specific Letter ");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Write($"{ch}");
                            Console.ResetColor();
                        }

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;


                    case 7:
                        Console.Clear();
                        gender g = gender.unknown;
                        Console.WriteLine("\n");
                        while (true)
                        {
                            Console.Write("Write The Gender : .....");
                            string input7 = Console.ReadLine();
                            if (gender.TryParse(input7, out g)) break;
                        }
                        List<person> people7 = db.Persons.Where(x => x.Gender == g).ToList();
                        foreach (var p7 in people7)
                        {
                            Console.WriteLine($"{p7.personID}  {p7.firstName} {p7.lastName} ");
                        }
                        Console.Write($"There are ");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write($"{people7.Count}");
                        Console.ResetColor();
                        Console.Write(" Persons Whose Have same Ginder");
                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 8:
                        Console.Clear();
                        int count = 0;
                        List<person> people8 = db.Persons.ToList();
                        List<address> adr = db.Addresses.ToList();
                        foreach (var a in adr)
                        {
                            if (a.DethDate != 0)
                            {
                                foreach (var p8 in people8)
                                {
                                    if (a.personIDFK == p8.personID)
                                    {
                                        Console.WriteLine($"{p8.personID}  {p8.firstName} {p8.lastName} ");
                                        count ++;
                                    }
                                }
                            }
                            
                        }
                        Console.Write($"There are ");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write($"{count}");
                        Console.ResetColor();
                        Console.Write(" Persons Whose Are died.");
                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 9:
                        Console.Clear();
                        int count1 = 0;
                        List<person> people9 = db.Persons.ToList();
                        List<address> adr1 = db.Addresses.ToList();
                        foreach (var a in adr1)
                        {
                            if (a.DethDate == 0 && a.BirthDate <= 1971 && a.BirthDate != 0)
                            {
                                foreach (var p9 in people9 )
                                {
                                    if (a.personIDFK == p9.personID)
                                    {
                                        Console.WriteLine($"{p9.personID}  {p9.firstName} {p9.lastName} ");
                                        count1++;
                                    }
                                }
                            }

                        }
                        Console.Write($"There are ");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write($"{count1}");
                        Console.ResetColor();
                        Console.Write(" Persons Whose Are Still Alive And Thier Old More Than 50 Years.");
                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 10:
                        Menu.mainMenuSelection();
                        sitting();
                        break;




                }
            }

        }

        public void FamilyRelationShip()
        {
            int num = 0;
            using (var db = new TestDbContext())
            {
                int numShowDetails = 0;
                Menu.FamilyRelationMenu();
                while (true)
                {
                    Console.Write("Your choice is << 1  -  11 >>: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out numShowDetails))
                    {
                        if (numShowDetails > 0 && numShowDetails < 12) break;
                    }
                    else Console.WriteLine("Invalid value, try again");
                }

                switch (numShowDetails)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.WriteLine("To Find The Person's Father");
                        Console.Write("Write His First Name: ");
                        string input1 = Console.ReadLine();

                        List<person> people1 = db.Persons.Where(x => x.firstName == input1).ToList();
                        Console.Clear();
                        if (people1.Count > 0)
                        {
                            foreach (person p in people1)
                            {
                                num = p.personID;
                                father fath = db.Fathers.Where(x => x.personIDFK == num).SingleOrDefault();

                                if (fath != null)
                                {
                                    Console.WriteLine($"ID({p.personID}) {p.firstName} {p.lastName}'s Father is :\n");
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Write($"{fath.fatherFirstName} {fath.fatherLastName}");
                                    Console.ResetColor();
                                }
                                else Console.WriteLine($"{p.firstName} has no Father or There is no Data about that.");
                            }
                        }
                        else Console.WriteLine("Is Not Existing.");
                        
                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 2: // find Mother
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.WriteLine("To Find The Person's Mother");
                        Console.Write("Write His First Name: ");
                        string input2 = Console.ReadLine();

                        List<person> people2 = db.Persons.Where(x => x.firstName == input2).ToList();
                        Console.Clear();
                        if (people2.Count > 0)
                        {
                            foreach (person p in people2)
                            {
                                num = p.personID;
                                mother mom = db.Mothers.Where(x => x.personIDFK == num).SingleOrDefault();
                                if (mom != null)
                                {
                                    Console.WriteLine($"ID({p.personID}) {p.firstName} {p.lastName}'s Mother is :\n");
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Write($"{mom.motherFirstName} {mom.motherLastName}");
                                    Console.ResetColor();
                                }
                                else Console.WriteLine($"{p.firstName} has no Mother or There is no Data about that.");
                            }
                        }
                        else Console.WriteLine("Is Not Existing.");

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 3: // find Spouse
                        Console.Clear();
                        Console.WriteLine("\n");
                        //int num3 = 0;
                        Console.WriteLine("To Find The Person's Spouse");
                        Console.Write("Write His First Name: ");
                        string input3 = Console.ReadLine();

                        List<person> people3 = db.Persons.Where(x => x.firstName == input3).ToList();
                        Console.Clear();
                        if (people3.Count > 0)
                        {
                            foreach (person p in people3)
                            {
                                num = p.personID;
                                spouse spo = db.Spouses.Where(x => x.personIDFK == num).SingleOrDefault();

                                if (spo != null)
                                {
                                    Console.WriteLine($"ID/({p.personID}) {p.firstName} {p.lastName}'s Spouse is :\n");
                                    Console.BackgroundColor = ConsoleColor.DarkRed;
                                    Console.Write($"{spo.spouseFirstName} {spo.spouseLastName}");
                                    Console.ResetColor();
                                }
                                else Console.WriteLine($"{p.firstName} has no Spouse or There is no Data about that.");
                            }
                        }
                        else Console.WriteLine("Is Not Existing.");

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 4: // find Children
                        Console.Clear();
                        Console.WriteLine("\n");
                        int num4 = 0;
                        Console.WriteLine("To Find The Person's Cheldren");
                        Console.Write("Write His First Name: ");
                        string input4 = Console.ReadLine();

                        List<person> people4 = db.Persons.Where(x => x.firstName == input4).ToList();
                        Console.Clear();
                        if (people4.Count > 0)
                        {
                            foreach (person p in people4)
                            {
                                num = p.personID;
                                List<children> childs = db.Children.Where(x => x.personIDFK == num).ToList();

                                if (childs.Count > 0)
                                {
                                    Console.WriteLine($"{p.personID}) {p.firstName} {p.lastName}'s Children are :\n");

                                    foreach (children child in childs)
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Console.Write($"{child.childFirstName} {child.childLastName}");
                                        Console.ResetColor();
                                        Console.WriteLine("\n");
                                    }
                                }
                                else Console.WriteLine($"{p.firstName} has no Children or There is no Data about that.");
                            }
                        }
                        else Console.WriteLine("Is Not Existing.");
                      
                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 5: // find Sipling
                        Console.Clear();
                        Console.WriteLine("\n");
                        Console.WriteLine("To Find The Person's Brothers and Sisters");
                        Console.Write("Write His First Name: ");
                        string input5 = Console.ReadLine();

                        List<person> people5 = db.Persons.Where(x => x.firstName == input5).ToList();
                        Console.Clear();
                        if (people5.Count > 0)
                        {
                            foreach (person p in people5)
                            {
                                num = p.personID;
                                List<sibling> Sibling = db.Siblings.Where(x => x.personIDFK == num).ToList();

                                if (Sibling.Count > 0)
                                {
                                    Console.WriteLine($"ID({p.personID}) {p.firstName} {p.lastName}'s Brothers and Systers are :\n");
                                    foreach (sibling bro in Sibling)
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Console.Write($"{bro.siblingFirstName} {bro.siblingLastName}");
                                        Console.ResetColor();
                                        Console.WriteLine("\n");
                                    }
                                }
                                else Console.WriteLine($"{p.firstName} has no Brothers or Systers or There is no Data about that.");
                            }
                        }
                        else Console.WriteLine("Is Not Existing.");

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 6: // find GrandFather
                        Console.Clear();
                        Console.WriteLine("\n");
                        int num6 = 0;
                        Console.WriteLine("To Find The Person's grandFathers");
                        Console.Write("Write His First Name: ");
                        string input6 = Console.ReadLine();

                        List<person> people6 = db.Persons.Where(x => x.firstName == input6).ToList();
                        Console.Clear();
                        if (people6.Count > 0)
                        {
                            foreach (person p in people6)
                            {
                                num = p.personID;
                                List<grandFather> GrandF = db.GrandFathers.Where(x => x.personIDFK == num).ToList();

                                if (GrandF.Count > 0)
                                {
                                    Console.WriteLine($"ID({p.personID}) {p.firstName} {p.lastName}'s GrandFathers are :\n");
                                    foreach (grandFather GF in GrandF)
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Console.Write($"{GF.grandFatherFirstName} {GF.grandFatherLastName}");
                                        Console.ResetColor();
                                        Console.WriteLine("\n");
                                    }
                                }
                                else Console.WriteLine($"{p.firstName} has no GrandFathers or There is no Data about that.");
                            }
                        }
                        else Console.WriteLine("Is Not Existing.");

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 7: // find GrandMother
                        Console.Clear();
                        Console.WriteLine("\n");
                        int num7 = 0;
                        Console.WriteLine("To Find The Person's GrandMothers");
                        Console.Write("Write His First Name: ");
                        string input7 = Console.ReadLine();

                        List<person> people7 = db.Persons.Where(x => x.firstName == input7).ToList();
                        Console.Clear();
                        if (people7.Count > 0)
                        {
                            foreach (person p in people7)
                            {
                                num = p.personID;
                                List<grandMother> GrandM = db.GrandMothers.Where(x => x.personIDFK == num).ToList();

                                if (GrandM.Count > 0)
                                {
                                    Console.WriteLine($"ID({p.personID}) {p.firstName} {p.lastName}'s GrandMothers are :\n");
                                    foreach (grandMother GM in GrandM)
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Console.Write($"{GM.grandMotherFirstName} {GM.grandMotherLastName}");
                                        Console.ResetColor();
                                        Console.WriteLine("\n");
                                    }
                                }
                                else Console.WriteLine($"{p.firstName} has no GrandMothers or There is no Data about that.");
                            }
                        }
                        else Console.WriteLine("Is Not Existing.");

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 8: // find Aunt
                        Console.Clear();
                        Console.WriteLine("\n");
                        int num8 = 0;
                        Console.WriteLine("To Find The Person's Aunts");
                        Console.Write("Write His First Name: ");
                        string input8 = Console.ReadLine();

                        List<person> people8 = db.Persons.Where(x => x.firstName == input8).ToList();
                        Console.Clear();
                        if (people8.Count > 0)
                        {
                            foreach (person p in people8)
                            {
                                num = p.personID;
                                List<aunt> aunts = db.Aunts.Where(x => x.personIDFK == num).ToList();
                                if (aunts.Count > 0)
                                {
                                    Console.WriteLine($"{p.personID}) {p.firstName} {p.lastName}'s Aunts are :\n");
                                    foreach (aunt Aunt in aunts)
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Console.Write($"{Aunt.auntFirstName} {Aunt.auntLastName}");
                                        Console.ResetColor();
                                        Console.WriteLine("\n");
                                    }
                                }
                                else Console.WriteLine($"{p.firstName} has no Aunts or There is no Data about that.");
                            }
                        }
                        else Console.WriteLine("Is Not Existing.");

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 9: // find Uncle
                        Console.Clear();
                        Console.WriteLine("\n");
                        int num9 = 0;
                        Console.WriteLine("To Find The Person's Uncles");
                        Console.Write("Write His First Name: ");
                        string input9 = Console.ReadLine();

                        List<person> people9 = db.Persons.Where(x => x.firstName == input9).ToList();
                        Console.Clear();
                        if (people9.Count > 0)
                        {
                            foreach (person p in people9)
                            {
                                num = p.personID;
                                List<uncle> uncles = db.Uncles.Where(x => x.personIDFK == num).ToList();

                                if (uncles.Count > 0)
                                {
                                    Console.WriteLine($"ID({p.personID}) {p.firstName} {p.lastName}'s Uncles are :\n");
                                    foreach (uncle Uncle in uncles)
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Console.Write($"{Uncle.uncleFirstName} {Uncle.uncleLastName}");
                                        Console.ResetColor();
                                        Console.WriteLine("\n");
                                    }
                                }
                                else Console.WriteLine($"{p.firstName} has no Uncles or There is no Data about that.");
                            }
                        }
                        else Console.WriteLine("Is Not Existing.");

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 10: // find Cousin
                        Console.Clear();
                        Console.WriteLine("\n");
                        int num10 = 0;
                        Console.WriteLine("To Find The Person's Cousins");
                        Console.Write("Write His First Name: ");
                        string input10 = Console.ReadLine();

                        List<person> people10 = db.Persons.Where(x => x.firstName == input10).ToList();
                        Console.Clear();
                        if (people10.Count > 0)
                        {
                            foreach (person p in people10)
                            {
                                num = p.personID;
                                List<cousin> cousins = db.Cousins.Where(x => x.personIDFK == num).ToList();

                                if (cousins.Count > 0)
                                {
                                    Console.WriteLine($"ID({p.personID}) {p.firstName} {p.lastName}'s Cousins are :\n");
                                    foreach (cousin Cousin in cousins)
                                    {
                                        Console.BackgroundColor = ConsoleColor.DarkRed;
                                        Console.Write($"{Cousin.cousinFirstName} {Cousin.cousinLastName}");
                                        Console.ResetColor();
                                        Console.WriteLine("\n");
                                    }
                                }
                                else Console.WriteLine($"{p.firstName} has no Cousins or There is no Data about that.");
                            }
                        }
                        else Console.WriteLine("Is Not Existing.");

                        Console.WriteLine("\n");
                        Console.WriteLine("Perss Enter to Exit");
                        Console.Read();
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                    case 11:
                        Menu.mainMenuSelection();
                        sitting();
                        break;

                }
            }
        }

        public void EditPerson()
        {
            using (var db = new TestDbContext())
            {
                Console.Clear();
                int BD = 0;
                int DD = 0;
                gender g = gender.unknown;
                status stat = status.unknown;
                Console.WriteLine("\n");
                Console.WriteLine(" ....    EDITTING AN EXISTED PERSON   .... ");
                Console.WriteLine(" ...    Please Write His First Name :  ... ");
                Console.WriteLine("___________________________________________");
                string input1 = Console.ReadLine();


                person p = db.Persons.SingleOrDefault(x => x.firstName == input1);
                if (p != null)
                {
                    var adr = db.Addresses.SingleOrDefault(x => x.personIDFK == p.personID);
                    //update First Name
                    Console.Write($"Old First Name is: {p.firstName}, New First Name: ----------");
                    String input2 = Console.ReadLine();
                    p.firstName = input2;

                    //update Last Name
                    Console.Write($"Old Last Name is: {p.lastName}, New Last Name: -----------");
                    String input3 = Console.ReadLine();
                    p.lastName = input3;

                    //update Gender
                    Console.Write($"Old Gender is: {p.Gender} ");
                    while (true)
                    {
                        Console.Write("The Gender is (male, female, unknown), New Gender: --------- ");
                        string input4 = Console.ReadLine();
                        if (gender.TryParse(input4, out g)) break;
                    }
                    p.Gender = g;

                    //update Status
                    Console.Write($"Old Status is: {p.Status}");
                    while (true)
                    {
                        Console.Write("The Status is: (single, married, divorced, widow, unknown), New Status: ---------");
                        string input5 = Console.ReadLine();
                        if (status.TryParse(input5, out stat)) break;
                    }
                    p.Status = stat;

                    
                    //update BirthDate
                    Console.Write($"Old BirthDate is: {adr.BirthDate}");
                    while (true)
                    {
                        Console.Write("The New BirthDate is: --------");
                        string input5 = Console.ReadLine();
                        if (int.TryParse(input5, out BD)) break;
                    }
                    adr.BirthDate = BD;

                    //update DeathDate
                    Console.Write($"Old DeathDate is: {adr.DethDate} ");
                    while (true)
                    {
                        Console.Write("The New DeathDate is: ----------");
                        string input5 = Console.ReadLine();
                        if (int.TryParse(input5, out DD)) break;
                    }
                    adr.BirthDate = DD;
                    db.Persons.Update(p);
                    db.Addresses.Update(adr);
                    db.SaveChanges();
                    Console.WriteLine("\n");
                    Console.WriteLine("You Succeeded To Update The Member");
                }

                else Console.WriteLine("Not Existe");
                Console.WriteLine("\n");
                Console.WriteLine("Perss Enter to Exit");
                Console.Read();
                Menu.mainMenuSelection();
                sitting();

            }
        }

        public void AddPerson()
        {
            using (var db = new TestDbContext())
            {
                Console.Clear();
                int BD = 0;
                int DD = 0;
                gender g = gender.unknown;
                status stat = status.unknown;
                Console.WriteLine("\n");
                Console.WriteLine(" ....      CREATING A NEW PERSON      .... ");
                Console.WriteLine("___________________________________________");

                Console.Write("Write The First Name : ..... ");
                string input1 = Console.ReadLine();
                Console.Write("Write The Last Name : ..... ");
                string input2 = Console.ReadLine();
                while (true)
                {
                    Console.Write("Write The Gender (male, female, unknown) : ..... ");
                    string input4 = Console.ReadLine();
                    if (gender.TryParse(input4, out g)) break;
                }
                while (true)
                {
                    Console.Write("Write The Status (single, married, divorced, widow, unknown) : ..... ");
                    string input4 = Console.ReadLine();
                    if (status.TryParse(input4, out stat)) break;
                }
                while (true)
                {
                    Console.Write("Write The BirthDate : ..... ");
                    string input4 = Console.ReadLine();
                    if (int.TryParse(input4, out BD)) break;
                }
                while (true)
                {
                    Console.Write("Write The DeathDate : ..... ");
                    string input4 = Console.ReadLine();
                    if (int.TryParse(input4, out DD)) break;
                }
                Console.Write("Write The City Name : ..... ");
                string input5 = Console.ReadLine();
                Console.Write("Write The Country Name : ..... ");
                string input6 = Console.ReadLine();
                Console.Write("Write The Father's First Name : ..... ");
                string input7 = Console.ReadLine();
                Console.Write("Write The Father's Last Name : ..... ");
                string input8 = Console.ReadLine();
                Console.Write("Write The Mother's First Name : ..... ");
                string input9 = Console.ReadLine();
                Console.Write("Write The Mother's Last Name : ..... ");
                string input10 = Console.ReadLine();
                Console.Write("Write The Spouse's First Name : ..... ");
                string input11 = Console.ReadLine();
                Console.Write("Write The Spouse's Last Name : ..... ");
                string input12 = Console.ReadLine();

                var per = db.Persons.Add(new person
                {
                    firstName = input1,
                    lastName = input2,
                    Gender = g,
                    Status = stat,
                    Address = (new address { city = input5, country = input6, BirthDate = BD, DethDate = DD }),
                    Father = (new father { fatherFirstName = input7, fatherLastName = input8 }),
                    Mother = (new mother { motherFirstName = input9, motherLastName = input10 }),
                    Spouse = (new spouse { spouseFirstName = input11,spouseLastName = input12}),                    
                }); 
                db.SaveChanges();

                Console.WriteLine("\n");
                Console.WriteLine("You Succeeded To Greate a New Member");
                Console.WriteLine("Perss Enter to Exit");
                Console.Read();
                Menu.mainMenuSelection();
                sitting();

            }
        }

        public void DeletePerson()
        {
            using (var db = new TestDbContext())
            {
                Console.Clear();
                int BD = 0;
                int DD = 0;
                gender g = gender.unknown;
                status stat = status.unknown;
                Console.WriteLine("\n");
                Console.WriteLine(" ....    DELETING AN EXISTED PERSON   .... ");
                Console.WriteLine(" ...    Please Write His First Name :  ... ");
                Console.WriteLine("___________________________________________");
                string input = Console.ReadLine();


                person p = db.Persons.SingleOrDefault(x => x.firstName == input);
                if (p != null)
                {
                    db.Persons.Remove(p);
                    db.SaveChanges();
                    Console.WriteLine("\n");
                    Console.WriteLine($"You Succeeded To Delete The Member wich First Name is {input}");
                }

                else Console.WriteLine("Not Existe");
                Console.WriteLine("\n");
                Console.WriteLine("Perss Enter to Exit");
                Console.Read();
                Menu.mainMenuSelection();
                sitting();
            }
        }
    }
}
