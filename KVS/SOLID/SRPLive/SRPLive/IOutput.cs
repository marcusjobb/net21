// -----------------------------------------------------------------------------------------------
//  Interface1.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace SRPLive;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Interface for output handler
/// </summary>
internal interface IOutput
{
    /// <summary>
    /// Prints the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    void Print (string text);
}
