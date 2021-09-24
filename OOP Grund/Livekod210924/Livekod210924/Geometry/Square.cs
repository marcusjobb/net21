using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return Math.Pow(Side,2);
            }

        }
        public double Circumference
        {
            get
            {
                return Side*4;
            }
        }
    }
}
