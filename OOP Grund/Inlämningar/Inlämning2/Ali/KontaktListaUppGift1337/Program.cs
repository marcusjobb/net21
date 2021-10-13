using System;

namespace KontaktListaUppGift1337
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int MenuChoice = 0;
            ContactList ccl = new ContactList();
            ccl.ExistingContacts();
            ccl.ExistingContacts2();
            do
            {
                ccl.Menu();
                try
                {
                    MenuChoice = int.Parse(Console.ReadLine());
                }
                catch (SystemException)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input");
                    MenuChoice = 0;
                }

                if (MenuChoice == 1)
                {
                    ccl.AddNewPerson();
                }
                else if (MenuChoice == 2)
                {
                    ccl.ShowInfoOfContact();
                }
                else if (MenuChoice == 3)
                {
                    ccl.UpdateExistingPerson();
                }
                else if (MenuChoice == 4)
                {
                    ccl.DeletePerson();
                }
                else if (MenuChoice == 5)
                {
                    ccl.PrintPerson();
                }
            } while (MenuChoice > 0 || MenuChoice <= 5);
        }
    }
}