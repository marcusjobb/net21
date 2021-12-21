// -----------------------------------------------------------------------------------------------
//  MazeRoom.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under Apache License 2.0 (Apache-2.0) 
// -----------------------------------------------------------------------------------------------

namespace Uppgift3_TheGame.POCO
{
    using System.Collections.Generic;
    using Uppgift3_TheGame.Enums;
    using static Enums.Direction;


    internal class MazeRoom
    {
        public string Shape => GetShape(this);
        public Direction Exits { get; set; } = Direction.None;
        private static string GetShape(MazeRoom room)
        {
            Dictionary<Direction, string> directionToString = new()
            {
                { North, "^" },
                { East, ">" },
                { West, "<" },
                { South, "v" },
                { North | East, "╚" },
                { South | East, "╔" },
                { South | West, "╗" },
                { North | West, "╝" },
                { North | South, "║" },
                { West | East, "═" },
                { North | East | South, "╠" },
                { North | South | West, "╣" },
                { North | East | West, "╩" },
                { South | East | West, "╦" },
                { North | East | South | West, "╬" }
            };
            return directionToString[room.Exits];
        }
    }
}
