// -----------------------------------------------------------------------------------------------
//  FileHandler.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace SRPLive;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// The file handler.
/// </summary>

public class FileHandler : IFileHandler
{
    /// <summary>
    /// Gets or sets the filename.
    /// </summary>
    public string Filename { get; set; } = "";
    /// <summary>
    /// Loads the file with the given filename.
    /// </summary>
    /// <returns>A string.</returns>
    public string Load () => File.Exists(Filename)  // if
            ? File.ReadAllText(Filename) // true 
            : ""; // else

    /// <summary>
    /// Saves the text to a file.
    /// </summary>
    /// <param name="text">The text.</param>
    public void Save (string text)
    {
        try
        {
            File.WriteAllText(Filename, text);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }
}
