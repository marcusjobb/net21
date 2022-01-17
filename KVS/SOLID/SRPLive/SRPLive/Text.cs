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

internal class Text
{
    public List<string> Contents { get; set; } = new();
    /// <summary>
    /// Omvandlar text sträng till en lista
    /// </summary>
    /// <param name="text">En massa text i en sträng</param>
    public Text (string text)
    {
        Contents = new(text.Split(Environment.NewLine));
    }
    /// <summary>
    /// Kopierar en lista med strängar till vår Content lista
    /// </summary>
    /// <param name="list">Lista med strängar</param>
    public Text (List<string> list)
    {
        Contents = list;
    }
    /// <summary>
    /// Tar emot ett Text objekt och kopierar dess innehåll
    /// </summary>
    /// <param name="text">Text objekt</param>
    public Text (Text text)
    {
        Contents = text.Contents;
    }

    /// <summary>
    /// Lägger till en rad i listan
    /// </summary>
    /// <param name="text">En sträng med text</param>
    public void AddRow(string text)
    {
        Contents.Add(text);
    }

    public void Insert(int pos, string text)
    {
        if (DoesRowExist(pos))
            Contents.Insert(pos, text);
    }

    public void Delete(string text)
    {
        int pos = Contents.FindIndex(r=>r.Contains(text));
        Delete(pos);
    }

    public void Delete(int pos)
    {
        if (DoesRowExist(pos))
            Contents.RemoveAt(pos);
    }

    public void Replace(int pos, string text)
    {
        if (DoesRowExist(pos))
            Contents[ pos ] = text;
    }

    public bool DoesRowExist (int pos) => pos >= 0 && pos < Contents.Count;
}
