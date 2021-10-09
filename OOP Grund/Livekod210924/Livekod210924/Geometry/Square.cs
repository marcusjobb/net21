// -----------------------------------------------------------------------------------------------
//  Square.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

using System;

namespace Livekod210924.Geometry
{
    public class Square : IFigure
    {
        public double Side { get; set; }

        public Rectangle ToRectangle()
        {
            return new Rectangle { Height = Side, Width = Side };
        }

        public double Area
        {
            get
            {
                return Math.Pow(Side, 2);
            }

        }
        public double Circumference
        {
            get
            {
                return Side * 4;
            }
        }
    }
}
