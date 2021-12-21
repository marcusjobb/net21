// -----------------------------------------------------------------------------------------------
//  AskFor.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;

namespace Livekod210924.Helpers
{
    static class AskFor
    {
        /// <summary>
        /// Fråga om ett tal
        /// </summary>
        /// <param name="message">Meddelande</param>
        /// <returns>Returnerar det nummer som användaren gav</returns>
        public static int Integer(string message)
        {
            bool isNummeric;
            int value;
            string input;
            do
            {
                Console.Write(message + ": ");
                input = Console.ReadLine();
                isNummeric = int.TryParse(input, out value);
            } while (!isNummeric);
            return value;
        }

        /// <summary>
        /// Fråga om ett tal
        /// </summary>
        /// <param name="message">Meddelande</param>
        /// <returns>Returnerar det nummer som användaren gav</returns>
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
