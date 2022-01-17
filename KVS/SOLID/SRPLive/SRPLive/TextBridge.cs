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

internal class TextBridge
{
    private IFileHandler filehandler;
    private IOutputList output;

    public TextBridge (IFileHandler filehandler, IOutputList output)
    {
        this.filehandler = filehandler;
        this.output = output;
    }
    public void Print(string filename)
    {
        filehandler.Filename = filename ;
        var text = new Text(filehandler.Load());
        output.Print(text.Contents);
    }
}
