using System;

namespace OOPDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLifetime cl = new ClassLifetime();

            cl.Value = 200;
            Console.WriteLine("value is " + cl.Value);

            Console.ReadLine();
        }
    }
}
