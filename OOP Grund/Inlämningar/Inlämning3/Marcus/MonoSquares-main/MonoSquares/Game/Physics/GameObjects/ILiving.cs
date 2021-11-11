using System;
using System.Collections.Generic;
using System.Text;

namespace MonoSquares.Physics.GameObjects
{
    interface ILiving
    {
        int Health { get; set; }
        int Damage { get; set; }
    }
}
