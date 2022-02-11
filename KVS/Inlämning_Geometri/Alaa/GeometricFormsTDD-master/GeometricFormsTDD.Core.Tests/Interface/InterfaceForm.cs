using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFormsTDD.Core.Interface
{
    interface InterfaceForm
    {
        /// <summary>
        /// Returns the perimeter of the form
        /// </summary>
        float GetPerimeter();

        /// <summary>
        /// Returns the area of the form
        /// </summary>
        float GetArea();
    }
}
/*
Area of Isosceles Triangle Using Sides
Area = 12×b×a2–b24−−−−−√ 
Here,
a− length of legs (equal sides of the isosceles triangle)
b− length of unequal side or base of the isosceles triangle.

Area = ½[√(a2 − b2 ⁄4) × b]
*/

/*
 area of equilateral triangle
Area = √3/4 × (side)2
*/

/*
 Area of a right triangle = 1/2 × base × height.
*/
