﻿using System;

namespace BFU_V3_Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(numbers[10]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine("Done!");
        }
    }
}
