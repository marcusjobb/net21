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
    public string After(int index) => rows[index + 1];
    public string Before(int index) => rows[index - 1];
    public IEnumerator<string> GetEnumerator() => rows.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => rows.GetEnumerator();
    public int IndexOf(string text, bool trimFirst = false) => trimFirst ? rows.FindIndex(r => r.Trim() == text) : rows.IndexOf(text);
    public int IndexOfContaining(string text, bool trimFirst = false) => trimFirst ? rows.FindIndex(r => r.Trim().Contains(text)) : rows.FindIndex(r => r.Contains(text));
    public int IndexOfEndsWith(string text, bool trimFirst = false) => trimFirst ? rows.FindIndex(r => r.Trim().StartsWith(text)) : rows.FindIndex(r => r.StartsWith(text));
    public int IndexOfLast(string text, bool trimFirst = false) => trimFirst ? rows.FindLastIndex(r => r.Trim() == text) : rows.LastIndexOf(text);
    public void RemoveEmptyLines()
    {
        rows = rows.Where(r => r.Length > 0).ToList();
        IsDirty = true;
    }
    public int IndexOfLastContaining(string text, bool trimFirst = false) => trimFirst ? rows.FindLastIndex(r => r.Trim().Contains(text)) : rows.FindLastIndex(r => r.Contains(text));
    public void AddNewlineBefore(int index)
    {
        if(index > 0)
        {
            rows.Insert(index, "");
            IsDirty = true;
        }
    }
    public void AddNewlineAfter(int index)
    {
        if(index > 0 && index<rows.Count-1)
        {
            rows.Insert(index+1, "");
            IsDirty = true;
        }
    }
    public void AddNewlineBefore(string text)
    {
        AddNewlineBefore(rows.IndexOf(text));
    }
    public void AddNewlineBeforeEvery(string text)
    {
        var index=rows.Count;
        while (index >0)
        {
            if (rows[index]==text)
                AddNewlineBefore(index);
            index--;
        }
    }
    public void AddNewlineAfter(string text)
    {
        int index = rows.IndexOf(text);
        if (index < rows.Count - 1)
        {
            AddNewlineAfter(index);
        }
    }
    public void AddNewlineAfterEvery(string text)
    {
        var index = 0;
        while (index< rows.Count)
        {
            if (rows[index] == text)
                AddNewlineAfter(index);
            index++;
        }
    }
    public void AddNewlineBeforeStartsWith(string text)
    {
        int index = rows.FindIndex(r=>r.StartsWith(text));
        if (index > 0)
        {
            AddNewlineBefore(index);
        }
    }
    public void AddNewlineBeforeEveryStartsWith(string text)
    {
        var index = rows.Count-1;
        while (index >0 )
        {
            if (rows[index].StartsWith(text))
                AddNewlineBefore(index);
            index--;
        }
    }
    public void AddNewlineAfterStartsWith(string text)
    {
        int index = rows.FindIndex(r => r.Trim().StartsWith(text));
        if (index < rows.Count - 1)
        {
            AddNewlineAfter(index);
        }
    }
    public void AddNewlineAfterEveryStartsWith(string text)
    {
        var index = 0;
        while (index < rows.Count - 1)
        {
            if (rows[index].StartsWith(text))
            {
                AddNewlineAfter(index);
            }
            index++;
        }
    }
    public void AddNewlineBeforeEndsWith(string text)
    {
        int index = rows.FindIndex(r => r.EndsWith(text));
        if (index > 0)
        {
            AddNewlineBefore(index);
        }
    }
    public void AddNewlineBeforeEveryEndsWith(string text)
    {
        var index = rows.Count;
        while (index > 0)
        {
            if (rows[index].EndsWith(text))
                AddNewlineBefore(index);
            index--;
        }
    }
    public void AddNewlineAfterEndsWith(string text)
    {
        int index = rows.FindIndex(r => r.EndsWith(text));
        if (index < rows.Count - 1)
        {
            AddNewlineAfter(index);
        }
    }
    public void AddNewlineAfterEveryEndsWith(string text)
    {
        var index = rows.Count - 1;
        while (index > 0)
        {
            if (rows[index].EndsWith(text))
            {
                AddNewlineAfter(index);
            }
            index--;
        }
    }
    public void AddNewlineBeforeContains(string text)
    {
        int index = rows.FindIndex(r => r.Contains(text));
        if (index > 0)
        {
            AddNewlineBefore(index);
        }
    }
    public void AddNewlineBeforeEveryContains(string text)
    {
        var index = rows.Count;
        while (index > 0)
        {
            if (rows[index].Contains(text))
                AddNewlineBefore(index);
            index--;
        }
    }
    public void RemoveEmptyLineBefore(string text)
    {
        int index = rows.IndexOf(text);
        if (index > 0)
        {
            if (rows[index - 1].Length == 0)
            {
                rows.RemoveAt(index - 1);
                IsDirty = true;
            }
        }
    }
    public void RemoveEmptyLineBeforeEvery(string text)
    {
        int index = rows.Count;
        while (index > 0)
        {
            if (rows[index] == text && rows[index - 1].Length == 0)
                RemoveEmptyLineBefore(text);
            index--;
        }
    }
    public void RemoveEmptyLineAfter(string text)
    {
        int index = rows.IndexOf(text);
        if (index < rows.Count - 1)
        {
            if (rows[index + 1].Length == 0)
            {
                rows.RemoveAt(index + 1);
                IsDirty = true;
            }
        }
    }
    public void RemoveEmptyLineAfterBefore(string text)
    {
        int index = rows.IndexOf(text);
        if (index < rows.Count - 1)
        {
            if (rows[index - 1].Length == 0)
            {
                rows.RemoveAt(index - 1);
                IsDirty = true;
            }
        }
    }
    public int IndexOfLastEndsWith(string text, bool trimFirst = false) => trimFirst ? rows.FindLastIndex(r => r.Trim().StartsWith(text)) : rows.FindLastIndex(r => r.StartsWith(text));
    public int IndexOfLastStartsWith(string text, bool trimFirst = false) => trimFirst ? rows.FindLastIndex(r => r.Trim().StartsWith(text)) : rows.FindLastIndex(r => r.StartsWith(text));
    public int IndexOfStartsWith(string text, bool trimFirst = false) => trimFirst ? rows.FindIndex(r => r.Trim().StartsWith(text)) : rows.FindIndex(r => r.StartsWith(text));
    public void Insert(int index, string text)
    {
        if(text == null) text = "";
        rows.Insert(index, text);
    }
    public int LastIndexOf(string text, bool trimFirst = false) => trimFirst ? IndexOfLast(text, trimFirst) : IndexOfLast(text);
    public int LastIndexOfContaining(string text, bool trimFirst = false) => trimFirst ? IndexOfLastContaining(text, trimFirst) : IndexOfLastContaining(text);
    public int LastIndexOfEndsWith(string text, bool trimFirst = false) => trimFirst ? IndexOfLastEndsWith(text, trimFirst) : IndexOfLastEndsWith(text);
    public int LastIndexOfStartsWith(string text, bool trimFirst = false) => trimFirst ? IndexOfLastStartsWith(text, trimFirst) : IndexOfLastStartsWith(text);
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
