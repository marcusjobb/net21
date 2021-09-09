namespace StackDemo
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            string[] tmp = new string[]
            {
                "Skutta runt",
                "Dansa salsa",
                "Kolla mailen",
                "Svara på mail",
                "Lyssna på musik"
            };

            Stack<string> stack = new(tmp);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Peek " + stack.Peek());
            Console.WriteLine("Pull " + stack.Pop());
            Console.WriteLine("Pull " + stack.Pop());
        }
    }
}
