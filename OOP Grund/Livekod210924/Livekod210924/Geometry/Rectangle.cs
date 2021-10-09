// -----------------------------------------------------------------------------------------------
//  Rectangle.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace Livekod210924.Geometry
{

    public class Rectangle : IFigure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area
        {
            get
            {
                return Width * Height;
            }

        }
        public double Circumference
        {
            get
            {
                return Width * 2 + Height * 2;
            }
        }
    }
}
