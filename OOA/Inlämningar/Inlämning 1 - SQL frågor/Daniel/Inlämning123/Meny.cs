using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning123
{
    class MainMenu
    {
        public static void start()
        {
            bool Menu = true;

            while (Menu)
            {
               Menu = Meny();
            }
             bool Meny()
            {
                // Här är menyn, la till en Console.Clear, kändes mer användarvänligt
                Console.Clear();
                Console.WriteLine("--------------------------------- ");
                Console.WriteLine("Välkommen till Inlämning 3");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Choose between these options:");
                Console.WriteLine("1) How many countries are represented?");
                Console.WriteLine("2) Are all the username and passwords unique?");
                Console.WriteLine("3) How many countries are from the north and Scandinavia?");
                Console.WriteLine("4) Which country is the most common?");
                Console.WriteLine("5) Show the first 10 names with the last name starts with L");
                Console.WriteLine("6) Show users with first and last name beginning with the same letter:");
                Console.WriteLine("q) Exit");
               
                
                Console.WriteLine("_____________________________________________________________________________");
                Console.Write("\r\nChoose an option : ");

                switch (Console.ReadLine())
                    // return true till användaren är färdig och vill avsluta
                {
                    case "1":
                        Get.Countriesrepresented();
                        return true;
                    case "2":
                        Get.Usernameandpassword();
                        return true;
                    case "3":
                        Get.Northandscandiviancountries();
                        return true;

                    case "4":
                        Get.Mostcommoncountry();
                        return true;

                    case "5":
                        Get.FirstlastnamewiththeletterL();
                        return true;

                    case "6":
                        Get.Userswithsamename();
                        return true;

                    case "q":
                        Console.Clear();
                        Console.WriteLine("Thanks for now");
                        return false;


                    default:
                        return true;

                }
            }
        }
    }
}
