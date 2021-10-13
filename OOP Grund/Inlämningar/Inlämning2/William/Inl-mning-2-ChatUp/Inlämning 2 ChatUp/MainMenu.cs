using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning_2_ChatUp
{
    class MainMenu
    {
        public void ShowMainMenu()
        { 

            Write("Vad vill du göra?");
            Write("1: Lägg till namn");
            Write("2: Ta bort namn");
            Write("3: Ändra namn");
            Write("4: Söka upp namn");
            string input = ReadInput("5: Visa lista på alla namn");

            if (input == "1")
                PersonSettings.AddNewPerson();
            
            if (input == "2")
                PersonSettings.RemovePerson();
            
            if (input == "3")
                PersonSettings.EditPerson();

            if (input == "4")
                PersonSettings.SearchPerson();
            
            if (input == "5")
                PersonSettings.ListAll();
            
                
        }

        public static void Write(string text)
        {
            Console.WriteLine(text);
        }

        public static string ReadInput(string read)
        {
            Console.WriteLine(read);
            return Console.ReadLine();
        }
    }
}
