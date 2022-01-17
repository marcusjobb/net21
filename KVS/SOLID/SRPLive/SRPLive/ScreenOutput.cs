// -----------------------------------------------------------------------------------------------
//  ScreenOutput.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace SRPLive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Outputs to screen
/// </summary>
/// <seealso cref="SRPLive.IOutput" />
/// <seealso cref="SRPLive.IOutputList" />
internal class ScreenOutput : IOutput, IOutputList
{
    /// <summary>
    /// Prints the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    public void Print (string text)
    {
        Console.Clear();
        Console.WriteLine(text);
    }

    /// <summary>
    /// Prints the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    public void Print (List<string> text)
    {
        var output = string.Join (Environment.NewLine, text);
        Print(output);
    }
}
