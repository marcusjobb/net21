using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
