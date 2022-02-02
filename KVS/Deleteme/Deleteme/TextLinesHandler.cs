namespace Deleteme;

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
        if(trimFirst)
            return rows.FindIndex(r=>r.Trim()==text);
        return rows.IndexOf(text);
    }

    public int IndexOfContaining(string text, bool trimFirst = false)
    {
        if(trimFirst)
            return rows.FindIndex(r => r.Trim().Contains(text));
        return rows.FindIndex(r => r.Contains(text));
    }

    public int IndexOfEndsWith(string text, bool trimFirst = false)
    {
        if(trimFirst)
            return rows.FindIndex(r => r.Trim().StartsWith(text));
        return rows.FindIndex(r => r.StartsWith(text));
    }

    public int IndexOfLast(string text, bool trimFirst = false)
    {
        if(trimFirst)
            return rows.FindLastIndex(r=>r.Trim()==text);
        return rows.LastIndexOf(text);
    }

    public int IndexOfLastContaining(string text, bool trimFirst = false)
    {
        if(trimFirst)
            return rows.FindLastIndex(r => r.Trim().Contains(text));
        return rows.FindLastIndex(r => r.Contains(text));
    }

    public int IndexOfLastEndsWith(string text, bool trimFirst = false)
    {
        if(trimFirst)
            return rows.FindLastIndex(r => r.Trim().StartsWith(text));
        return rows.FindLastIndex(r => r.StartsWith(text));
    }

    public int IndexOfLastStartsWith(string text, bool trimFirst = false)
    {
        if(trimFirst)
            return rows.FindLastIndex(r => r.Trim().StartsWith(text));
        else
            return rows.FindLastIndex(r => r.StartsWith(text));
    }

    public int IndexOfStartsWith(string text, bool trimFirst = false)
    {
        if(trimFirst)
            return rows.FindIndex(r => r.Trim().StartsWith(text));
        return rows.FindIndex(r => r.StartsWith(text));
    }

    public int LastIndexOf(string text, bool trimFirst = false)
    {
        if(trimFirst)
            return IndexOfLast(text, trimFirst);
        return IndexOfLast(text);
    }

    public int LastIndexOfContaining(string text, bool trimFirst = false)
    {
        if(trimFirst)
            return IndexOfLastContaining(text, trimFirst);
        return IndexOfLastContaining(text);
    }

    public int LastIndexOfEndsWith(string text, bool trimFirst = false)
    {
        if(trimFirst)
            return IndexOfLastEndsWith(text, trimFirst);
        return IndexOfLastEndsWith(text);
    }

    public int LastIndexOfStartsWith(string text, bool trimFirst = false)
    {
        if(trimFirst)
            return IndexOfLastStartsWith(text, trimFirst);
        return IndexOfLastStartsWith(text);
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
}