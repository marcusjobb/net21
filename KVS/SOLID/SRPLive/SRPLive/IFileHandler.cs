// -----------------------------------------------------------------------------------------------
//  IFileHandler.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace SRPLive;

/// <summary>
/// Interface for Filehandler
/// </summary>
public interface IFileHandler
{
    /// <summary>
    /// Gets or sets the filename.
    /// </summary>
    /// <value>
    /// The filename.
    /// </value>
    string Filename { get; set; }

    /// <summary>
    /// Loads the text file.
    /// </summary>
    /// <returns>string with the file contents</returns>
    string Load ();
    /// <summary>
    /// Saves the specified text.
    /// </summary>
    /// <param name="text">The text.</param>
    void Save (string text);
}