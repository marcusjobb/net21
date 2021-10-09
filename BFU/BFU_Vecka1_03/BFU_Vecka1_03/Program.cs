// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace BFU_Vecka1_03
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            name = name.Trim(); // ta bort onödiga mellanslag
            name = name.Replace(" ", ""); // ersätter ett tecken eller ord med annat
            Console.WriteLine("Ditt namn är:" + name);
            Console.WriteLine("Ditt namn har " + name.Length + " bokstäver");
        }
    }
}
