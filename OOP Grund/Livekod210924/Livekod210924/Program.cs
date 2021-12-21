// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using Livekod210924.Extensions;

namespace Livekod210924
{
    class Program
    {
        static void Main(string[] args)
        {
            //MetoderRepetition mr = new();
            //mr.Start();

            //new ExtensionsDemo().Start();

            //int number = AskFor.Integer("Say a number");
            //double number2 = AskFor.Double("Say a double");

            //List<IFigure> figures = new List<IFigure>
            //{
            //    new Rectangle
            //                {
            //                    Width = 50,
            //                    Height = 50
            //                },
            //    new Square
            //    {
            //        Side=20
            //    }
            //};

            //foreach (IFigure fig in figures)
            //{
            //    if (fig is Square) Console.WriteLine("Side: "+((Square)fig).Side);
            //    Console.WriteLine(fig.Area);
            //    Console.WriteLine(fig.Circumference);
            //}

            // Definiering
            List<string> MyList = new List<string>();

            // Create
            MyList.Add("Batman");
            MyList.Add("Joker");
            MyList.Add("Will Ferrell");
            MyList.Add("Adam Sandler");

            // Read
            Console.WriteLine(MyList[0]);
            Console.WriteLine();

            // Update
            MyList[1] = "Robin";

            // Delete
            int index = MyList.IndexOf("Will Ferrell");
            if (index > 0) MyList.RemoveAt(index);
            MyList.Remove("Adam Sandler");

            // List
            MyList.PrintArray();



        }
    }
}
