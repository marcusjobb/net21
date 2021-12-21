// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace RepetitionV37B
{
    using System;

    class Program
    {
        enum Limits
        {
            MaxX = 110,
            MaxY = 20,
            MinX = 1,
            MinY = 1,
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                // Definierar
                int x = AskForValue("Ange X coordinat: ");
                int y = AskForValue("Ange Y coordinat: ");

                DrawAsterisk(x, y);

            }
        }

        private static void DrawAsterisk(int x, int y)
        {
            // Kontrollerar
            if (y >= (int)Limits.MinY && y < (int)Limits.MaxY)
            {
                if (x >= (int)Limits.MinX && x < (int)Limits.MaxX)
                {
                    // Presenterar
                    Console.SetCursorPosition(x, y);
                    Console.Write('*');
                }
            }
        }

        private static int AskForValue(string message)
        {
            Console.WriteLine(message);
            int.TryParse(Console.ReadLine(), out int value);
            return value;
        }
    }
}
