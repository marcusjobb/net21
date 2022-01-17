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

public class FileHandler
{
    public string Filename { get; set; }
    public string Load () => File.Exists(Filename)  // if
            ? File.ReadAllText(Filename) // true 
            : ""; // else

    public void Save(string text)
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
