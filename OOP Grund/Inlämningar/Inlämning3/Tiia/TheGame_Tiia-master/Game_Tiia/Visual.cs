using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game_Tiia
{
    class Visual //Metoder för att ändra färgen på text och andra visuella grejer
    {
        public static void WanderingAround() //ser lite ut som små fotsteg (?)
        {
            Visual.ChangeToCyan();

            for (int i = 0; i < 6; i++)
            {
                Console.Write(" °");
                Thread.Sleep(250);
                Console.Write(" o");
                Thread.Sleep(250);
            }
            Console.WriteLine();
            Console.ResetColor();
            Console.Clear();
        }

        public static void ChangeToCyan()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public static void ChangeToMagenta()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        public static void BlueLine()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--------------------------");
            Console.ResetColor();
        }
        public static void SeparateLine()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------\n");
        }

        public static void MagentaText(string text)
        {
            Visual.ChangeToMagenta();
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static void CyanText(string text)
        {
            Visual.ChangeToCyan();
            Console.WriteLine(text);
            Console.ResetColor();
        }

        internal static void PointPoint()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }
        }
    }
}
