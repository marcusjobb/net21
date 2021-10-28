﻿// -----------------------------------------------------------------------------------------------
//  Human.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace InterfaceFiltrering
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Human : INameAble, IAgeAble, INameAge
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Age  :" + Age);
        }
    }

    internal class Pet : INameAble
    {
        public string Name { get; set; }
        public string Race { get; set; }
    }
}
