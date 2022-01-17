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

internal class TextFileHandler:FileHandler
{
    public Text Load()
    {
        string text = base.Load();
        return new Text(text);
    }

    public void Save(Text text)
    {
        var txt = string.Join(Environment.NewLine, text.Contents);
        base.Save(txt);
    }
}
