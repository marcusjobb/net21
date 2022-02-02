namespace Deleteme;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class TextLinesHandler : IEnumerable
{
    private List<string> rows = new();
    public int Count => rows.Count;
    public bool IsDirty { get; private set; } = false;
    public int Length => rows.Count;

    public string this[int index]
    {
        get => rows[index];
        set
        {
            if(index >= 0 && index < rows.Count && rows[index] != value)
            {
                rows[index] = value;
                IsDirty = true;
            }
        }
    }

    public string After(int index)
    {
        return rows[index + 1];
    }
    public string Before(int index)
    {
        return rows[index - 1];
    }

    // implement ienumerable
    public IEnumerator<string> GetEnumerator()
    {
        return rows.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return rows.GetEnumerator();
    }

    public void Insert(int index, string text)
    {
        if(text == null) text = "";
        rows.Insert(index, text);
    }

    public int IndexOf(string text, bool trimFirst = false)
    {
        return trimFirst ? rows.FindIndex(r => r.Trim() == text) : rows.IndexOf(text);
    }

    public int IndexOfContaining(string text, bool trimFirst = false)
    {
        return trimFirst ? rows.FindIndex(r => r.Trim().Contains(text)) : rows.FindIndex(r => r.Contains(text));
    }

    public int IndexOfEndsWith(string text, bool trimFirst = false)
    {
        return trimFirst ? rows.FindIndex(r => r.Trim().StartsWith(text)) : rows.FindIndex(r => r.StartsWith(text));
    }

    public int IndexOfLast(string text, bool trimFirst = false)
    {
        return trimFirst ? rows.FindLastIndex(r => r.Trim() == text) : rows.LastIndexOf(text);
    }

    public int IndexOfLastContaining(string text, bool trimFirst = false)
    {
        return trimFirst ? rows.FindLastIndex(r => r.Trim().Contains(text)) : rows.FindLastIndex(r => r.Contains(text));
    }

    public int IndexOfLastEndsWith(string text, bool trimFirst = false)
    {
        return trimFirst ? rows.FindLastIndex(r => r.Trim().StartsWith(text)) : rows.FindLastIndex(r => r.StartsWith(text));
    }

    public int IndexOfLastStartsWith(string text, bool trimFirst = false)
    {
        return trimFirst ? rows.FindLastIndex(r => r.Trim().StartsWith(text)) : rows.FindLastIndex(r => r.StartsWith(text));
    }

    public int IndexOfStartsWith(string text, bool trimFirst = false)
    {
        return trimFirst ? rows.FindIndex(r => r.Trim().StartsWith(text)) : rows.FindIndex(r => r.StartsWith(text));
    }

    public int LastIndexOf(string text, bool trimFirst = false)
    {
        return trimFirst ? IndexOfLast(text, trimFirst) : IndexOfLast(text);
    }

    public int LastIndexOfContaining(string text, bool trimFirst = false)
    {
        return trimFirst ? IndexOfLastContaining(text, trimFirst) : IndexOfLastContaining(text);
    }

    public int LastIndexOfEndsWith(string text, bool trimFirst = false)
    {
        return trimFirst ? IndexOfLastEndsWith(text, trimFirst) : IndexOfLastEndsWith(text);
    }

    public int LastIndexOfStartsWith(string text, bool trimFirst = false)
    {
        return trimFirst ? IndexOfLastStartsWith(text, trimFirst) : IndexOfLastStartsWith(text);
    }

    public TextLinesHandler Read(string filename)
    {
        rows = File.ReadAllLines(filename).ToList();
        IsDirty = false;
        return this;
    }

    public TextLinesHandler Save(string filename)
    {
        if(IsDirty) File.WriteAllLines(filename, rows);
        IsDirty = false;
        return this;
    }

    internal void Refresh()
    {
        var str = string.Join(Environment.NewLine, rows);
        rows = new List<string>(str.Split(Environment.NewLine));
    }
}