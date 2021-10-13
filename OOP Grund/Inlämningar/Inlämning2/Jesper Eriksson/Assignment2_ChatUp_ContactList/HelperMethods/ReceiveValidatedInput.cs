using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  ChatUp_ContactList.Extensions;


namespace ChatUp_ContactList.HelperMethods
{
    static class ReceiveValidatedInput
    {
        
        /// <summary>
        /// Repeatedly asks the user for an input which contains no numbers.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string PlainText(string message)
        {
            string userInput;
            do
            {
                Console.Write(message);
                userInput = Console.ReadLine();
                if (Validate.StringNoNumber(userInput))
                {
                    // Removes the last two characters of the message sent into the method. This way it prints "Name" instead of "Name: ", for example.
                    Console.WriteLine($"\"{message.Substring(0, message.Length -2)}\" cannot consist of numbers. Are you sure you entered the information correctly? Try again.");
                }
                else if (Validate.IsEmpty(userInput))
                {
                    Console.WriteLine($"\"{message.Substring(0, message.Length - 2)}\" cannot be empty. Try again.");
                }
                
            } while (Validate.StringNoNumber(userInput) || Validate.IsEmpty(userInput));
            return userInput.CapitalisedNTrimmed();
        }

        /// <summary>
        /// Repeatedly asks the user for an input which is not empty.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string StringNotEmpty(string message)
        {
            string userInput;
            do
            {
                Console.Write(message);
                userInput = Console.ReadLine();
                if (Validate.IsEmpty(userInput))
                {
                    Console.WriteLine($"\"{message.Substring(0, message.Length - 2)}\" cannot be empty. Try again.");
                }

            } while (Validate.IsEmpty(userInput));
            return userInput.CapitalisedNTrimmed();
        }

        /// <summary>
        /// Repeatedly asks the user for a somewhat valid e-mail adress. All email-adresses must contain a "@" and a "." somewhere.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string Email(string message)
        {
            string userInput;
            do
            {
                Console.Write(message);
                userInput = Console.ReadLine();
                if (Validate.IsEmpty(userInput))
                {
                    Console.WriteLine($"\"{message.Substring(0, message.Length - 2)}\" cannot be empty. Try again.");
                }
                else if (Validate.EMail(userInput))
                {
                    Console.WriteLine("It doesn't seem like you entered a correct email. Try again.");
                }
            } while (Validate.IsEmpty(userInput) || Validate.EMail(userInput));
            return userInput;

        }

        /// <summary>
        /// Repeatedly asks the user for a valid DateTime to be used as the date of birth.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static DateTime DateOfBirth(string message)
        {
            string userInput;
            bool validDate;
            bool validAge;
            DateTime dateOfBirth;
            do
            {
                Console.Write(message);
                userInput = Console.ReadLine();
                validDate = DateTime.TryParse(userInput, out dateOfBirth);
                validAge = Validate.AgeSpan(dateOfBirth);
                if (Validate.IsEmpty(userInput))
                {
                    Console.WriteLine($"\"{message}\"cannot be empty. Try again.");
                }
                else if (!validDate)
                {
                    Console.WriteLine("The date is entered incorrectly, please use the format YYYY/MM/DD. For example: 1990/06/16, for the sixth of june 1990.");
                }
                else if (!validAge)
                {
                    Console.WriteLine("The entered age is not valid. You are either joking or below the age of 18. Try again.");
                }
            } while (Validate.IsEmpty(userInput) || !validDate || !validAge);
            return dateOfBirth;


        }
    }
}
