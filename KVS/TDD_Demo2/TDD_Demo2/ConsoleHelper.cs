// -----------------------------------------------------------------------------------------------
//  ConsoleHelper.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace TDD_Demo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ConsoleHelper
{
    // Original icke-testbar kod
    //public static void CenterText (string text)
    //{
    //    var pos = Console.WindowWidth / 2 - text.Length / 2;
    //    Console.CursorLeft = pos;
    //    Console.WriteLine(text); <--- Fungerar inte i testläge
    //}

    public static void CenterText (string text)
    {
        Console.WriteLine(CenterText(text, Console.WindowWidth)); 
    }
    public static string CenterText (string text, int screenWidth = 0)
    {
        if (screenWidth == 0)
            screenWidth = Console.WindowWidth;
        var pos = screenWidth / 2 - text.Length / 2;
        return new string(' ', pos) + text;
    }

    // Original icke-testbar kod
    //public static int GetInt (int min, int max)
    //{
    //    int result = min - 1;
    //    while (result < min || result > max)
    //    {
    //        var input = Console.ReadLine();
    //        int.TryParse(input, out result);
    //    }
    //    return result;
    //}

    public static int GetInt (string input)
    {
        int.TryParse(input, out int result);
        return result;
    }

    public static int GetInt (int min, int max)
    {
        int result = min - 1;
        while (result < min || result > max)
        {
            var input = Console.ReadLine();
            result=GetInt(input??"");
        }
        return result;
    }
}
