namespace PlaneringsExempel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Helper
    {
        public static int Calculate(int tal1, string op, int tal2)
        {
            return op switch
            {
                "+" => tal1 + tal2,
                "-" => tal1 - tal2,
                "*" => tal1 * tal2,
                "/" => tal1 / tal2,
                _ => 0,
            };
        }

        public static string AskForOperator(string message)
        {
            string op = "";
            bool isOK = false;
            while (!isOK)
            {
                Console.Write(message + " : ");
                op = Console.ReadLine();
                if (string.IsNullOrEmpty(op)) Environment.Exit(0);
                isOK = op is "+" or "-" or "*" or "/";
            }
            return op;
        }

        public static int AskForNumber(string message)
        {
            var isOK = false;
            int tal = 0;

            while (!isOK)
            {
                Console.Write(message + " : ");
                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) Environment.Exit(0);
                isOK = int.TryParse(input, out tal);
            }
            return tal;
        }
    }
}
