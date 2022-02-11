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
        float Perimeter();

        /// <summary>
        /// Returns the area of the form
        /// </summary>
        float Area();
    }
}
