using System;
using System.Collections.Generic;
using System.Linq;
using ChattApplication_F.per;
using System.Threading.Tasks;

namespace ChattApplication_F.memb
{
    class Members
    {
        private static void show_Details(person per)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  .....                      {per.Alias}                      .....   \n");
            Console.ResetColor();
            Console.WriteLine($" Name is:  {per.firstName} {per.lastName}         Age is: {per.Age}       Gender: {per.Gen}... ");
            Console.WriteLine($" E-mail :  {per.Email}                  Github: {per.Github}");
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine();
        }
        public static List<person> contacts = new()
        {
            new person { firstName = "Anderss", lastName = "Johansson", Alias = "and7", Gen = gender.male, Age = 42, Email = "and@gmail.com", Github = "www.github.com/and", IsBlocked = false, IsGhosted = false },
            new person { firstName = "Joly", lastName = "Lars", Alias = "JoLr", Gen = gender.female, Age = 28, Email = "joly.lars@gmail.com", Github = "www.github.com/jol", IsBlocked = true, IsGhosted = false },
            new person { firstName = "Erik", lastName = "Karl", Alias = "Karl-2", Gen = gender.male, Age = 67, Email = "karl@gmail.com", Github = "www.github.com/karl", IsBlocked = false, IsGhosted = false },
            new person { firstName = "Peter", lastName = "Olof", Alias = "Pet-07", Gen = gender.male, Age = 18, Email = "peter@gmail.com", Github = "www.github.com/pet", IsBlocked = false, IsGhosted = true },
            new person { firstName = "Emma", lastName = "Bengt", Alias = "EmBn", Gen = gender.female, Age = 48, Email = "emma@gmail.com", Github = "www.github.com/eml", IsBlocked = false, IsGhosted = false },
            new person { firstName = "Ommar", lastName = "Sallah", Alias = "Ommar02", Gen = gender.male, Age = 36, Email = "ommar@gmail.com", Github = "www.github.com/ommar", IsBlocked = false, IsGhosted = false },
            new person { firstName = "Simon", lastName = "Olsson", Alias = "Sim-99", Gen = gender.unknown, Age = 334, Email = "simon@gmail.com", Github = "www.github.com/sim", IsBlocked = false, IsGhosted = true },
            new person { firstName = "Robert", lastName = "Lindström", Alias = "Rob-L", Gen = gender.male, Age = 29, Email = "robert@gmail.com", Github = "www.github.com/rob", IsBlocked = true, IsGhosted = false }
        };

        public static void invoke()
        {
            int numMainMenu = 0;
            bool flag = true;
            while (flag)
            {
                Console.Write("Your choises is << 1  -  9 >>: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out numMainMenu))
                {
                    if (numMainMenu > 0 && numMainMenu <= 9) break;
                }
                else Console.WriteLine("Invalid value, try again");
            }


            switch (numMainMenu)
            {
                case 1:
                    contact_List(); //kontakter List
                    break;
                case 2:
                    cont_List_By_Firs_Letter(); // kontakter som börjar med en bestämd bökstave
                    break;
                case 3:
                    Ginder_List();   //Liata med alla kontakter som är samma gender 
                    break;
                case 4:
                    Blocked_List();   //Liata med alla blockerat kontakter
                    break;
                case 5:
                    Gosted_List();  //Lista med alla Gosted kontakter
                    break;
                case 6:
                    add_Contact(); // skapa kontakt
                    break;
                case 7:
                    edit_Contact(); // updetera en kontakt
                    break;
                case 8:
                    delete_Contact(); // Ta bort en  kontakt
                    break;
                default:    //9) ---> exit
                    Environment.Exit(0);
                    break;

            }
            Console.Read();
        }
        public static void contact_List() //visar List contact alla contacter
        {

            Console.Clear();
            Console.WriteLine("\n\n -------               C O N T A C T   L I S T                ---------");
            Console.WriteLine("____________________________________________________________________________");
            foreach (person per in contacts)
            {
                show_Details(per);
            }
        }



        public static void cont_List_By_Firs_Letter() //visar List contact alla contacter
        {

            Console.Clear();
            char ch = '!';
            while (true)
            {
                Console.WriteLine("Sort contacts whose begins with a specific letter");
                Console.Write("Select a letter: ");
                string input = Console.ReadLine();
                if (char.TryParse(input, out ch)) break;
            }


            Console.WriteLine("\n\n ----            L I S T  B Y  F I R S T  L E T T E R              ----");
            Console.WriteLine("____________________________________________________________________________");
            foreach (person per in contacts)
            {
                if ((per.firstName[0] == ch))
                {
                    show_Details(per);
                }

            }
        }
        public static void Ginder_List()
        {
            Console.Clear();
            Console.WriteLine("Sort contacts whose have the same gender");
            Console.WriteLine();
            Console.WriteLine("_____________________________________");
            Console.WriteLine("....   G E N D E R   L I S T    .....");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("....     Male List Contcts      .....");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("....   Female List Contcts    .....");
            Console.WriteLine("_____________________________________");
            Console.WriteLine("....   Unknown List Contcts    .....");
            Console.WriteLine("_____________________________________");

            gender g = gender.unknown;
            while (true)
            {
                Console.Write("Select a gender: ");
                string input = Console.ReadLine();
                if (gender.TryParse(input, out g)) break;
            }



            Console.WriteLine("\n\n -------              G E N D E R   L I S T                 ---------");
            Console.WriteLine("____________________________________________________________________________");
            foreach (person per in contacts)
            {
                if (per.Gen == g) show_Details(per);
            }
        }
        public static void Blocked_List()
        {
            Console.Clear();
            Console.WriteLine("\n\n -------              B L O C K E D   L I S T                 ---------");
            Console.WriteLine("____________________________________________________________________________");
            foreach (person per in contacts)
            {
                if (per.IsBlocked == true) show_Details(per);
            }
        }
        public static void Gosted_List()
        {
            Console.Clear();
            Console.WriteLine("\n\n -------               G O S T E D   L I S T                  ---------");
            Console.WriteLine("____________________________________________________________________________");
            foreach (person per in contacts)
            {
                if (per.IsGhosted == true) show_Details(per);
            }
        }
        public static void add_Contact()
        {
            person newContact = new();
            contacts.Add(newContact);
            int age = 0;
            gender g = gender.unknown;
            bool isB = false;
            bool isG = false;
            Console.WriteLine("Write the imformation about new contact:");
            Console.WriteLine("_______________________________________");
            Console.Write("The firs name is: ");
            newContact.firstName = Console.ReadLine();
            Console.Write("The last name is: ");
            newContact.lastName = Console.ReadLine();
            Console.Write("The Alias is: ");
            newContact.Alias = Console.ReadLine();
            while (true)
            {
                Console.Write("The Gender is: ");
                string input = Console.ReadLine();
                if (gender.TryParse(input, out g)) break;
            }
            newContact.Gen = g;

            while (true)
            {
                Console.WriteLine("How old is he: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age))
                    if (age > 0) break;
            }
            newContact.Age = age;

            Console.WriteLine("His E-mail is: ");
            newContact.Email = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("is he Blocked: ");
                string input = Console.ReadLine();
                if (bool.TryParse(input, out isB)) break;
            }
            newContact.IsBlocked = isB;

            while (true)
            {
                Console.WriteLine("is he Gosted: ");
                string input = Console.ReadLine();
                if (bool.TryParse(input, out isG)) break;
            }
            newContact.IsGhosted = isG;
            Console.WriteLine("You succeeded to add new contact");
        }
        public static void edit_Contact()
        {
            int i = 0;
            int attribut_Num = 0;
            gender g = gender.unknown;
            int n = 0;
            Console.WriteLine("Wich contact you want to edit it");
            Console.Write("Write the Alias: ");
            string input = Console.ReadLine();
            if (contacts.Exists(member => member.Alias.Contains(input)))
            {
                person member = contacts.Find(member => member.Alias == input);
                i = contacts.IndexOf(member);
                while (true)
                {
                    Console.WriteLine("Select the contact's attribut you want to update: ");
                    //updetera contacter (members) och ändra vilken attribut som användaren 
                    Console.WriteLine(" 1) firstName");
                    Console.WriteLine(" 2) lastName");
                    Console.WriteLine(" 3) Alias");
                    Console.WriteLine(" 4) Gender");
                    Console.WriteLine(" 5) Age");
                    Console.WriteLine(" 6) Address");
                    Console.WriteLine(" 7) Email");
                    Console.WriteLine(" 8) Linkedin");
                    Console.WriteLine(" 9) FaceBook");
                    Console.WriteLine(" 10) Instgram");
                    Console.WriteLine(" 11) Twitter");
                    Console.WriteLine(" 12) Github");
                    Console.WriteLine(" 13) FavoriteFood");
                    Console.WriteLine(" 14) FoodDislike");
                    Console.WriteLine(" 15) FavoriteAnimal");
                    Console.WriteLine(" 16) FavoriteMovie");
                    Console.WriteLine(" 17) FavoriteHobby");
                    Console.WriteLine(" 18) IsBlocked");
                    Console.WriteLine(" 19) IsGhosted\n");
                    Console.Write("press the number: ");
                    string attribut = Console.ReadLine();
                    if (int.TryParse(attribut, out attribut_Num))
                        if (attribut_Num > 0 && attribut_Num < 20) break;
                }

                switch (attribut_Num)
                {
                    case 1: //"fistName"
                        Console.Write("Write the contact's first name: ");
                        contacts[i].firstName = Console.ReadLine();
                        break;

                    case 2: //"lastName"
                        Console.Write("Write the contact's last name: ");
                        contacts[i].lastName = Console.ReadLine();
                        break;

                    case 3:  // "Alias"
                        Console.Write("Write the contact's Alias: ");
                        contacts[i].Alias = Console.ReadLine();
                        break;
                    case 4:  // "Gender"
                        Console.Write("Do you want to change the gender of the contant (Yes / No): ");
                        string gen_string = Console.ReadLine();
                        if (gen_string == "yes" || gen_string == "y")
                        {
                            while (true)
                            {
                                Console.Write("Write update of the Gender: ");
                                string input2 = Console.ReadLine();
                                if (gender.TryParse(input2, out g)) break;
                            }
                        }
                        contacts[i].Gen = g;
                        break;

                    case 5:  // "Age"
                        while (true)
                        {
                            Console.Write("Write the contact's Age: ");
                            string input3 = Console.ReadLine();
                            if (int.TryParse(input3, out n)) break;
                        }

                        contacts[i].Age = n;
                        break;

                    case 6:  //"Address"
                        Console.Write("Write the contact's Addtess: ");
                        contacts[i].Address = Console.ReadLine();
                        break;

                    case 7:   //"Email"
                        Console.Write("Write the contact's Email: ");
                        contacts[i].Email = Console.ReadLine();
                        break;

                    case 8:   //"Linkedin"
                        Console.Write("Write the contact's Linkedin: ");
                        contacts[i].Linkedin = Console.ReadLine();
                        break;

                    case 9:    //"Facebook"
                        Console.Write("Write the contact's FaceBook: ");
                        contacts[i].Facebook = Console.ReadLine();
                        break;


                    case 10:   //"Instagram"
                        Console.Write("Write the contact's Istagram: ");
                        contacts[i].Instagram = Console.ReadLine();
                        break;

                    case 11:   //"Twitter"
                        Console.Write("Write the contact's Twitter: ");
                        contacts[i].Twitter = Console.ReadLine();
                        break;

                    case 12:   //"Github"
                        Console.Write("Write the contact's Github: ");
                        contacts[i].Github = Console.ReadLine();
                        break;

                    case 13:    //"FavoriteFood"
                        Console.Write("Write the contact's FavoriteFood: ");
                        contacts[i].FavoriteFood = Console.ReadLine();
                        break;

                    case 14:   //"FoodDislike"
                        Console.Write("Write the contact's FoodDislike: ");
                        contacts[i].FoodDislike = Console.ReadLine();
                        break;

                    case 15:    //"FavoriteAnimal"
                        Console.Write("Write the contact's FavoriteAnimal: ");
                        contacts[i].FavoriteAnimal = Console.ReadLine();
                        break;

                    case 16:   //"FavoriteMovie"
                        Console.Write("Write the contact's FavoriteMovie: ");
                        contacts[i].FavoriteMovie = Console.ReadLine();
                        break;

                    case 17:    //"FavoriteHobby"
                        Console.Write("Write the contact's FavoriteHobby: ");
                        contacts[i].FavoriteHobby = Console.ReadLine();
                        break;

                    case 18:    //IsBlocked"
                        Console.Write("Do you want to block the contant (Yes / No): ");
                        string IB_string = Console.ReadLine();
                        if (IB_string == "yes" || IB_string == "y")
                        {
                            contacts[i].IsBlocked = true;
                        }
                        else contacts[i].IsBlocked = false;
                        break;
                    case 19:    //"IsGosted"
                        Console.Write("Do you want to gost the contant (Yes / No): ");
                        string Ig_string = Console.ReadLine();
                        if (Ig_string == "yes" || Ig_string == "y")
                        {
                            contacts[i].IsGhosted = true;
                        }
                        else contacts[i].IsBlocked = false;
                        break;

                    default: break;

                }
                Console.WriteLine("You succeeded to update a contact");

            }
            else Console.WriteLine("The Alias you gave isnot exist");
        }
        public static void delete_Contact()
        {
            int i = 0;
            Console.WriteLine("Wich contact you want to delet: ");
            Console.Write("Write the Alias: ");
            string input = Console.ReadLine();
            if (contacts.Exists(member => member.Alias.Contains(input)))
            {
                person member = contacts.Find(member => member.Alias == input);
                i = contacts.IndexOf(member);
                contacts.Remove(contacts[i]);
                Console.WriteLine("You succeeded to remove a contact");
            }
            else Console.WriteLine("The Alias you gave isnot exist");

        }
    }
}
