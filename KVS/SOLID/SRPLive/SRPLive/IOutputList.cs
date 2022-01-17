// -----------------------------------------------------------------------------------------------
//  Interface1.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace SRPLive;
using System.Collections.Generic;

/// <summary>
/// Outputs a list
/// </summary>
internal interface IOutputList
{
    /// <summary>
    /// Prints the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    void Print (List<string> text);
}
