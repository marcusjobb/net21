// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace BFU_V3_Demo4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAdd();
            TestAdd2();
            TestDivision();

            Console.WriteLine(Add(10, 10)); // 20
            Console.WriteLine(Multiply(10, 10)); // 100

        }
        private static void TestDivision()
        {
            double expected = 10;
            double actual = Divide(100, 10);
            Assert(expected, actual);
        }

        private static double Divide(int number1, int number2)
        {
            return number1 / number2;
        }

        private static void TestAdd()
        {
            int expected = 25;
            int actual = Add(10, 15);

            Assert(expected, actual);
        }

        private static void TestAdd2()
        {
            int expected = 17;
            int actual = Add(7, 10);

            Assert(expected, actual);
        }

        private static void Assert(int expected, int actual)
        {
            if (expected != actual)
            {
                Console.WriteLine("Fel i koden");
                Console.WriteLine($"Förväntade {expected} men fick {actual}");
                Environment.Exit(0);
            }
        }
        private static void Assert(double expected, double actual)
        {
            if (expected != actual)
            {
                Console.WriteLine("Fel i koden");
                Console.WriteLine($"Förväntade {expected} men fick {actual}");
                Environment.Exit(0);
            }
        }

        private static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        private static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
