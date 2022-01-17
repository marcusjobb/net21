// -----------------------------------------------------------------------------------------------
//  TextFileHandler.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace SRPLive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Text file handler
/// </summary>
/// <seealso cref="SRPLive.FileHandler" />
internal class TextFileHandler:FileHandler
{
    /// <summary>
    /// Loads the text..
    /// </summary>
    /// <returns>A <see cref="Text"/> with the file contents</returns>
    public new Text Load()
    {
        string text = base.Load();
        return new Text(text);
    }

    /// <summary>
    /// Saves the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    public void Save(Text text)
    {
        var txt = string.Join(Environment.NewLine, text.Contents);
        base.Save(txt);
    }
}
