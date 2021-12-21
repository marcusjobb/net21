// -----------------------------------------------------------------------------------------------
//  Class1.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame.Enums
{
    using System;

    [Flags]
    internal enum Direction
    {
        None = 0,
        North = 1,
        East = 2,
        South = 4,
        West = 8
    }
}
