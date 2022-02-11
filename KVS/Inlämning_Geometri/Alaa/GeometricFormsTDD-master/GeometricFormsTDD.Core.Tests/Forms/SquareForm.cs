using GeometricFormsTDD.Core.Interface;
using System;

namespace GeometricFormsTDD.Core
{
    internal class SquareForm : InterfaceForm
    {
        public SquareForm()
        {
        }

        public float Side { get; set; }

        public float GetPerimeter()
        {
            return Side * 4;
        }

        public float GetArea()
        {
            return Side * Side;
        }
    }
}