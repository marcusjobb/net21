using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlämning_2
{
    class PeopleHandler
    {
        private  CRUDL ph = new ();

        public void VirsualPersons()
        {
            ph.Create(new Person { Name = "Malik", Lastname = "Alhanouti", Alias = "mlk", IsBlocked=true });
            ph.Create(new Person { Name = "Sohaib", Lastname = "Alhanouti", Alias = "sob" ,IsBlocked=true});
            ph.Create(new Person { Name = "Andres", Lastname = "SandQvist", Alias = "ando", IsGhosted=true });
            ph.Create(new Person { Name = "Zaid", Lastname = "Alhanouti", Alias = "Zizo", IsGhosted=true });
            ph.Create(new Person { Name = "Hanna", Lastname = "Larson", Alias = "Han" ,IsGhosted=true});
        }


        public void Asks()
        {
            Console.WriteLine("Ange Förnamnet  : ");
            Console.WriteLine("Ange Efternamnet: ");
            Console.WriteLine("Ange Aliasnamnet: ");
            Console.WriteLine("Är kontakt ghostade?  Tryck [Y] eller [N]: ");
        }
       
        public string name()
        {
            Console.SetCursorPosition(20, 0);
            string input = Console.ReadLine();
            return input.Trim();
        }


        public string lastname()
        {
            Console.SetCursorPosition(20, 1);
            string input = Console.ReadLine();
            return input.Trim();
        }

        public string alias()
        {
            Console.SetCursorPosition(20, 2);
            string input = Console.ReadLine();
            return input.Trim();
        }

        public bool Isghosted()
        {
            Console.SetCursorPosition(43, 3);
            string input = Console.ReadLine();
            if (input.ToLower() == "y") return true;
            else return false;

        }

        public string Askname()
        {
            Console.Write("Ange Förnamnet  : ");
           
            string input = Console.ReadLine();
            return input.Trim();
        }

        public string Asklastname()
        {
            Console.Write("Ange Efternamnet: ");
           
            string input = Console.ReadLine();
            return input.Trim();
        }

        public string Askalias()
        {
            Console.Write("Ange Aliasnamnet: ");
            string input = Console.ReadLine();
            return input.Trim();
        }

        public void BackToMenu()
        {
            Console.WriteLine("Tryck Enter att tillbaka till huvud meny");
            Console.ReadLine();

            Console.Clear();

            Menu();
        }

        //-------------------------------------------------------------- [Is Ghosted List]
        public void IsGhostedList()
        {

            List<Person> theghosted = new List<Person>();

            foreach (var contact in ph.List())
            {
                theghosted.Add(contact);
            }


            foreach (var contact in theghosted)
            {
                if (contact.IsGhosted == true)
                {
                    Console.WriteLine(contact.Name + "    är ghostade");
                }
            }

            BackToMenu();
        }



        //------------------------------------------------------------ [Is Ghosted List]
        public void IsBlockedList()
        {

            List<Person> theblockd = new List<Person>();

            foreach (var contact in ph.List())
            {
                theblockd.Add(contact);
            }


            foreach (var contact in theblockd)
            {
                if (contact.IsBlocked == true)
                {
                    Console.WriteLine(contact.Name + "    är blockade");
                }
            }

            BackToMenu();
        }



        //------------------------------------------------------->[The Name List]
        public void TheNameList() 
        {

            List<string> thenew = new List<string>();

            foreach (var contact in ph.List())
            {
                thenew.Add(contact.Name);
            }

            thenew.Sort();

            foreach (var contact in thenew)
            {
                Console.WriteLine(contact);
            }

            BackToMenu();
        }


        //------------------------------------------------------------>[Create a new contact]
        public void CreateContact()    
        {
            Asks();

            ph.Create(new Person { Name = name(), Lastname = lastname(), Alias = alias(), IsGhosted = Isghosted() }) ;

            BackToMenu();    
        }
        

        //-------------------------------------------------------->[Show the contact infirmation]
        public void PersonInformation()
        {
            TryAgain:
                Console.Write("Ange komtakt namn: ");
                string index = Console.ReadLine();
                var PerInformation = ph.Read(index);
            if (PerInformation == null)
            {
                Console.Write("Detta namn finns inte.\n" +
                              "Om du vill ange kontakt namn igen, tryck [Y], annat gå tillbaka till huvud meny.");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")  goto TryAgain;  
                else BackToMenu();
            }
            
            Console.WriteLine("Förnamn  : " + PerInformation.Name + "\n" 
                             +"Efternamn: " + PerInformation.Lastname + " \n"
                             + "Efternamn: " + PerInformation.Alias + " \n"
                             + "ÄrBlockad: " + PerInformation.IsBlocked + " \n"
                             + "ÄrGhostad    : " + PerInformation.IsGhosted);
            BackToMenu();
        }

        //------------------------------------------------------>[Update contact]
        public void UpdateInformatin()        
        {
            
        TryAgain:
            Console.Write("Ange namnet som du vill söka efter och ändra uppgifter: ");
            string index = Console.ReadLine();
            var PerInformation = ph.Read(index);
            if (PerInformation == null)
            {
                Console.Write("Detta namn finns inte.\n" +
                              "Om du vill söka efter namnet igen, tryck [Y], annat gå tillbaka till huvud meny.");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") goto TryAgain;
               
                else BackToMenu();
            }

            var NewData = new Person { Name = Askname(), Lastname = Asklastname(), Alias = Askalias() };
            ph.Update(index, NewData);

            BackToMenu();
        }

        //------------------------------------------------------->[Delete contakt]
        public void DeleteInformation()
        {
        TryAgain:
            Console.Write("Ange namnet som du vill ta bort sina uppgifter: ");
            string index = Console.ReadLine();
            var PerInformation = ph.Read(index);
            if (PerInformation == null)
            {
                Console.Write("Detta namn finns inte.\n" +
                              "Om du vill ange namnet igen, tryck [Y], annat gå tillbaka till huvud meny.");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y") goto TryAgain;
                else BackToMenu();
            }

            Console.WriteLine($"Kontakt uppgfter för [{index}] ska tas bort. Är du säker\n"
                                + "Om du vill gå vidare tryck [Y]  annt avbryta och gå till baka till huvud meny.");

            string SureAnswer = Console.ReadLine().ToLower();
            if (SureAnswer == "y") 
            {
                Console.WriteLine($"Kontakt uppgfter för [{index}] tags bort");
                ph.Delete(index);
                BackToMenu();
            }

            else BackToMenu();
        }


        //------------------------------------------------------->[The Menu]
        public void Menu()
        {
            int Number;


            Console.WriteLine("Välj en tjänst av följande:[ ]");
            Console.WriteLine("[1] Alla kontakter nummn");
            Console.WriteLine("[2] Lägg till en ny kontakt");
            Console.WriteLine("[3] Vissa kontakts uppgifter");
            Console.WriteLine("[4] Ändra kontakts uppgifter");
            Console.WriteLine("[5] Ta bort kontakts uppgifter");
            Console.WriteLine("[6] Visa all kontakter som är ghostade");
            Console.WriteLine("[7] Visa all kontakter som är blockade");
            Console.WriteLine("[8] För avsluta programmet");

            Console.SetCursorPosition(28, 0);
            string inputA = Console.ReadLine();
            int.TryParse(inputA, out Number);

            while (Number < 1 || Number > 8)
            {
                Console.SetCursorPosition(0, 8);
                Console.Write("Du har valt fel. Välj tjänst nummer igen:[ ]");
                Console.SetCursorPosition(42, 8);
                string input = Console.ReadLine();
                int.TryParse(input, out Number);
            }

            Console.Clear();


            switch (Number)
            {
                case 1: TheNameList(); break;
                case 2: CreateContact(); break;
                case 3: PersonInformation(); break;
                case 4: UpdateInformatin(); break;
                case 5: DeleteInformation(); break;
                case 6: IsGhostedList(); break;
                case 7: IsBlockedList(); break;
                default: Console.WriteLine("Välkommen åter"); break;
            }
        }

             
    }
}
