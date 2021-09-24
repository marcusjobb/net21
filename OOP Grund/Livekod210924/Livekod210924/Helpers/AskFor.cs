using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livekod210924.Helpers
{
    static class AskFor
    {
        /// <summary>
        /// Asks for an integer
        /// </summary>
        /// <param name="message">Message to be written to the user</param>
        /// <returns></returns>
        public static int Integer(string message)
        {
            bool isNummeric;
            int value;
            string input;
            do
            {
                Console.Write(message+": ");
                input = Console.ReadLine();
                isNummeric = int.TryParse(input, out value);
            } while (!isNummeric);
            return value;
        }

        internal static double Double(string message)
        {
            bool isNummeric;
            double value;
            string input;
            do
            {
                Console.Write(message + ": ");
                input = Console.ReadLine();
                isNummeric = double.TryParse(input, out value);
            } while (!isNummeric);
            return value;
        }
    }
}
