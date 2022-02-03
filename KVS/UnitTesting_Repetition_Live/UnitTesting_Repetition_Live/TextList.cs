// -----------------------------------------------------------------------------------------------
//  TextList.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace UnitTesting_Repetition_Live;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TextList
{
    // Sträng lista
    public List<string> Text { get; set; }
    public TextList (string filename="")
    {
        // Läser in en fil, men bara om den finns
        Text = File.Exists(filename) ? File.ReadAllLines(filename).ToList() : (new());
    }

    /// <summary>Finds the row containing.</summary>
    /// <param name="text">The text.</param>
    /// <returns>row number if found, -1 if not found</returns>
    public int FindRowContaining (string text)
    {
        // talar om vilken rad som innehåller vilken text
        return Text.FindIndex(row=>row.Contains(text, StringComparison.CurrentCultureIgnoreCase));
    }

    public string GetRow(int row)
    {
        // Hämtar en specifik rad
        return row < 0 || row > Text.Count - 1 ? "" : Text[ row ];
    }
}