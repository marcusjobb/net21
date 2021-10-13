using System;

namespace ChatUp_Kontaktlista_Josefin_Persson
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactList contactList = new ContactList();   //instansierar kontaktlistan
            Menu menu = new Menu();    //instansierar menyn
            menu.RunMenu(contactList);  //kör meny-metoden
        }
    }
}

