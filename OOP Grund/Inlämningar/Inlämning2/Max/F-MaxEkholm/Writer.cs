using System;

namespace F
{
    class Writer
    {
        public static void WriteAllContacts()
        {
            Console.WriteLine("-----------------------------------------------");
            foreach (var person in PersonClass.ContactList)
            {
                int index = PersonClass.ContactList.IndexOf(person) + 1;
                Console.Write($"[{index}]      {person.Nickname}");
                Checker.BirthdayChecker(index);
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------");
        }

        public static void WriteMoreInfo(int index)
        {
            var contact = PersonClass.ContactList[index];
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"         Nickname:  {contact.Nickname} " +
                            $"\n       First Name:  {contact.FirstName}" +
                            $"\n        Last Name:  {contact.LastName}" +
                            $"\n         Birthday:  {Checker.WriteBirthdayCheck(index)}" +
                            $"\n              Age:  {Checker.WriteAgeCheck(index)} \n" +

                            $"\n            Email:  {contact.Email}" +
                            $"\n         LinkedIn:  {contact.LinkedIn}" +
                            $"\n         Facebook:  {contact.Facebook}" +
                            $"\n        Instagram:  {contact.Instagram}" +
                            $"\n          Twitter:  {contact.Twitter} \n" +

                            $"\n  Most liked food:  {contact.LikeFood}" +
                            $"\n Least liked food:  {contact.HateFood}" +
                            $"\n  Favorite animal:  {contact.FavAnimal}" +
                            $"\n   Favorite genre:  {contact.FavMovGenre} \n");

            Console.WriteLine(Checker.IsGhostedChecker(index));
            Console.WriteLine(Checker.IsBlockedChecker(index));

            Console.WriteLine("-----------------------------------------------");
        }

        public static void WriteSymbolFilter(string symbol)
        {
            symbol = symbol.ToLower();
            Console.WriteLine($"These are the contacts that starts with {symbol}:\n");

            Console.WriteLine("-----------------------------------------------");
            foreach (var person in PersonClass.ContactList)
            {
                if (person.Nickname.ToLower().StartsWith(symbol) == true)
                {
                    int index = PersonClass.ContactList.IndexOf(person) + 1;
                    Console.Write($"[{index}]      {person.Nickname}");
                    Checker.BirthdayChecker(index);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("-----------------------------------------------");
        }

        public static void WriteFilterGhosted()
        {
            Console.WriteLine("These are your ghosted contacts: \n");

            Console.WriteLine("-----------------------------------------------");
            foreach (var person in PersonClass.ContactList)
            {
                if (person.IsGhosted == true)
                {
                    int index = PersonClass.ContactList.IndexOf(person) + 1;
                    Console.Write($"[{index}]      {person.Nickname}");
                    Checker.BirthdayChecker(index);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("-----------------------------------------------");
        }

        public static void WriteFilterBlocked()
        {
            Console.WriteLine("These are your blocked contacts: \n");

            Console.WriteLine("-----------------------------------------------");
            foreach (var person in PersonClass.ContactList)
            {
                if (person.IsBlocked == true)
                {
                    int index = PersonClass.ContactList.IndexOf(person) + 1;
                    Console.Write($"[{index}]      {person.Nickname}");
                    Checker.BirthdayChecker(index);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
