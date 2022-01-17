// -----------------------------------------------------------------------------------------------
//  IFileHandler.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace SRPLive;

public interface IFileHandler
{
    string Filename { get; set; }

    string Load ();
    void Save (string text);
}