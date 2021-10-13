using System;
using System.Collections.Generic;
using System.Linq;

namespace F
{
    class Checker
    {
        public static void BirthdayChecker(int index)
        {
            index--;
            DateTime today = DateTime.Today;

            DateTime birthday = PersonClass.ContactList[index].Birthday;
            int age = AgeCheck(index);
           

            if (today.Day == birthday.Day && today.Month == birthday.Month)
            {
                Console.Write($"         -Today is their birthday! ({age} years old!)");
                Console.WriteLine();
            }
            else if (today.Month == birthday.Month)
            {
                Console.Write($"         -Has birthday this month! (Will be {age} years old!)");
                Console.WriteLine();
            }
           
        }
        
        public static string WriteBirthdayCheck (int index)
        {
            DateTime birthday = PersonClass.ContactList[index].Birthday;
            DateTime defaultDate = new();
            string birthdayAdded = "";
            if (birthday != defaultDate)
            {
               birthdayAdded = birthday.ToString("dd/MM/yyyy");
            }
            
            return birthdayAdded;
        }

        public static int AgeCheck(int index)
        {

            DateTime today = DateTime.Today;

            DateTime birthday = PersonClass.ContactList[index].Birthday;

            int age = today.Year - birthday.Year;

            if (today < birthday.AddYears(age))
            {
                age--;
            }
            return age;
        }

        public static string WriteAgeCheck(int index)
        {
            int age = PersonClass.ContactList[index].Age;
            string ageString = "";

            string birthdayAdded = WriteBirthdayCheck(index);
            if (birthdayAdded != "")
            {
                ageString = AgeCheck(index).ToString();
            }           
            return ageString;
        }

        public static int ValidIndexChecker()
        {
            bool acceptedIndex = false;
            int index = new();
            while (acceptedIndex == false)
            {                              
                if (int.TryParse(Console.ReadLine(), out index))
                {
                    if (index <= PersonClass.ContactList.Count)
                    {
                        index--;
                        acceptedIndex = true;
                    }
                    else Console.Write("Please enter a valid index: ");
                }
                else Console.Write("Please enter a valid index: ");
            }
            return index;
        }

        public static string IsGhostedChecker(int index)
        {
            var ghosted = PersonClass.ContactList[index].IsGhosted;          
            string ghostStatus = "";

            if (ghosted == true)
            {                
               ghostStatus = "Contact is ghosted";
            }
            else if (ghosted == false)
            {
                ghostStatus = "Contact is not ghosted";
            }
            return ghostStatus;
        }

        public static string IsBlockedChecker(int index)
        {
            var blocked = PersonClass.ContactList[index].IsBlocked;
            string blockedStatus = "";

            if (blocked == true)
            {
                blockedStatus = "Contact is blocked";
            }
            else if (blocked == false)
            {
                blockedStatus = "Contact is not blocked";
            }
            return blockedStatus;
        }
    }   
}
