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

internal class ScreenOutput : IOutput, IOutputList
{
    public void Print (string text)
    {
        Console.Clear();
        Console.WriteLine(text);
    }

    public void Print (List<string> text)
    {
        var output = string.Join (Environment.NewLine, text);
        Print(output);
    }
}
