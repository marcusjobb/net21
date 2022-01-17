// -----------------------------------------------------------------------------------------------
//  Text.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace SRPLive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Text handler class
/// </summary>
internal class Text
{
    /// <summary>
    /// Gets or sets the contents of the text.
    /// </summary>
    /// <value>
    /// The contents (a string list).
    /// </value>
    public List<string> Contents { get; set; } = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="Text"/> class.
    /// </summary>
    /// <param name="text">The text.</param>
    public Text (string text)
    {
        Contents = new(text.Split(Environment.NewLine));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Text"/> class.
    /// </summary>
    /// <param name="list">The list.</param>
    public Text (List<string> list)
    {
        Contents = list;
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="Text"/> class.
    /// </summary>
    /// <param name="text">The text.</param>
    public Text (Text text)
    {
        Contents = text.Contents;
    }

    /// <summary>
    /// Adds the row.
    /// </summary>
    /// <param name="text">The text.</param>
    public void AddRow(string text)
    {
        Contents.Add(text);
    }

    /// <summary>
    /// Inserts a row the specified position.
    /// </summary>
    /// <param name="pos">The position.</param>
    /// <param name="text">The text.</param>
    public void Insert(int pos, string text)
    {
        if (DoesRowExist(pos))
            Contents.Insert(pos, text);
    }

    /// <summary>
    /// Deletes the specified row of text.
    /// </summary>
    /// <param name="text">The text.</param>
    public void Delete(string text)
    {
        int pos = Contents.FindIndex(r=>r.Contains(text));
        Delete(pos);
    }

    /// <summary>
    /// Deletes the row in the specified position.
    /// </summary>
    /// <param name="pos">The position.</param>
    public void Delete(int pos)
    {
        if (DoesRowExist(pos))
            Contents.RemoveAt(pos);
    }

    /// <summary>
    /// Replaces the text in the specified position.
    /// </summary>
    /// <param name="pos">The position.</param>
    /// <param name="text">The text.</param>
    public void Replace(int pos, string text)
    {
        if (DoesRowExist(pos))
            Contents[ pos ] = text;
    }

    /// <summary>
    /// Checks if the row exist.
    /// </summary>
    /// <param name="pos">The position.</param>
    /// <returns></returns>
    public bool DoesRowExist (int pos) => pos >= 0 && pos < Contents.Count;
}
