// -----------------------------------------------------------------------------------------------
//  TextBridge.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace SRPLive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A bridge for using the text and output
/// </summary>
internal class TextBridge
{
    private IFileHandler filehandler;
    private IOutputList output;

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBridge"/> class.
    /// </summary>
    /// <param name="filehandler">The filehandler.</param>
    /// <param name="output">The output.</param>
    public TextBridge (IFileHandler filehandler, IOutputList output)
    {
        this.filehandler = filehandler;
        this.output = output;
    }
    /// <summary>
    /// Prints the specified filename.
    /// </summary>
    /// <param name="filename">The filename.</param>
    public void Print(string filename)
    {
        filehandler.Filename = filename ;
        var text = new Text(filehandler.Load());
        output.Print(text.Contents);
    }
}
