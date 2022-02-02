namespace Deleteme;

using System.IO;

public class QuickAndDirtyNew
{
    //private const int access = 0;
    private const int namePos = 2;
    private const string todoFile = @"..\..\..\Todo.txt";
    private const int varPos = 1;
    private static List<string>? TodoList = null;
    private List<string> files = new();
    public QuickAndDirtyNew(string path = "")
    {
        if(path.Length > 0) EnumerateFiles(path);
    }

    public void AdaptPropertiesToMongoDB(string path = "")
    {
        if(path.Length > 0) EnumerateFiles(path);
        foreach(var file in files)
        {
            var curFile = new TextLinesHandler().Read(file);
            FixMongoProperties(curFile);
            SetDefaultValues(curFile);
            _ = curFile.Save(file);
        }
        TodoSave();
    }
    public void NicerProperties(string path = "")
    {
        if(path.Length > 0) EnumerateFiles(path);
        foreach(var file in files)
        {
            var curFile = new TextLinesHandler().Read(file);
            SetProperNames(curFile);
            SetDefaultValues(curFile);
            _ = curFile.Save(file);
        }
        TodoSave();
    }
    public void TidyUpDocument(string path = "")
    {
        if(path.Length > 0) EnumerateFiles(path);
        foreach(var file in files)
        {
            var curFile = new TextLinesHandler().Read(file);
            SetProperNames(curFile);
            CleanUpDocument(curFile);
            SetDefaultValues(curFile);
            _ = curFile.Save(file);
        }
        TodoSave();
    }
    private void CleanUpDocument(TextLinesHandler curFile)
    {
        curFile.RemoveEmptyLines();
        curFile.AddNewlineBefore("whatever");
        curFile.AddNewlineBeforeStartsWith("using ");
        curFile.AddNewlineBeforeContains(" class ");
        for(int i = curFile.Length - 1; i >= 0; i--)
        {
            if(IsProperty(curFile[i])) curFile.AddNewlineAfter(i);
        }
        curFile.AddNewlineAfterStartsWith("}");
        curFile.RemoveEmptyLineBefore("}");
    }
    private void AddNewlineAfter(TextLinesHandler curFile, int pos)
    {
        if(pos > -1)
        {
            curFile.Insert(pos + 1, "");
        }
    }
    private static void AddNewlineBefore(TextLinesHandler curFile, int pos)
    {
        if(pos > -1)
        {
            curFile.Insert(pos, "");
        }
    }
    private static void AddUsing(TextLinesHandler curFile, string addUsing)
    {
        if(curFile.IndexOf(addUsing) < 0)
        {
            var pos = curFile.IndexOfLastStartsWith("using ", true);
            if(pos < 0)
                pos = 0;
            pos++;
            curFile.Insert(pos, addUsing);
        }
    }
    private static bool HasDefaultValue(string row) => row.Contains("} = ");
    private static bool HasUnderscore(string name) => name.Contains('_');
    private static bool IsComment(string row) => row.StartsWith("//");
    private static bool IsLowerCase(string name) => name == name.ToLower();
    private static bool IsProperty(string row) => !row.StartsWith("//") && (row.Contains("{ get; set; }") || row.Contains("{ get; private set; }"));

    private static string TodoFix(string varCheck, string retVal)
    {
        if(TodoList == null)
            TodoList = File.Exists(todoFile) ? File.ReadAllLines(todoFile).ToList() : new List<string>();
        if(TodoList.IndexOf(varCheck) < 0)
            TodoList.Add($"{varCheck}()");
        return retVal;
    }
    private static void TodoSave()
    {
        if(TodoList != null) File.WriteAllLines(todoFile, TodoList);
    }
    private void EnumerateFiles(string path) => files = Directory.GetFiles(path, "*.cs", SearchOption.AllDirectories).ToList();
    private void FixMongoProperties(TextLinesHandler curFile)
    {
        const string addUsing = "using MongoDB.Bson.Serialization.Attributes;";
        const string tagElement = "[BsonElement(";
        const string tagId = "[BsonId]";
        var needUsing = false;
        var lastrow = "";
        for(var i = 0; i < curFile.Length; i++)
        {
            var row = curFile[i].Trim();
            if(!IsComment(row) && IsProperty(row))
            {
                var corr = row.Contains(" static ") ? 1 : 0;
                System.Diagnostics.Debug.Assert(corr == 0);
                var prop = row.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var propName = prop[namePos + corr];
                var propType = prop[varPos + corr];
                var newName = propName;
                if(IsLowerCase(newName))
                    newName = SetProperCase(newName);
                if(HasUnderscore(newName))
                    newName = FixUnderscores(newName);
                if(newName == "Id" && propType == "Guid" && lastrow != tagId)
                {
                    curFile[i] = $"    {tagId}\r\n{curFile[i]}";
                    needUsing = true;
                }
                if(propName != newName)
                {
                    curFile[i] = curFile[i].Replace($" {propName} ", $" {newName} ");
                    curFile[i] = $"    {tagElement}\"{propName}\")]\r\n{curFile[i]}";
                    needUsing = true;
                }
                curFile[i] = curFile[i].TrimEnd();
            }
            lastrow = curFile[i].Trim();
        }
        if(needUsing)
            AddUsing(curFile, addUsing);
        curFile.Refresh();
    }
    private string FixUnderscores(string name)
    {
        var names = name.Split('_');
        var newName = "";
        foreach(var item in names)
        {
            newName += SetProperCase(item);
        }
        return newName;
    }
    private string GetDefaultValue(string vartype)
    {
        var varCheck = vartype.TrimEnd('?');
        var firstLetter = vartype[..2];
        return varCheck.EndsWith("[]")
            ? $"Array.Empty<{varCheck[0..^2]}>()"
            : firstLetter == firstLetter.ToUpperInvariant() && firstLetter.StartsWith('I')
                ? TodoFix(varCheck, $"new {varCheck[1..]}()")
                : vartype.EndsWith('?')
                            ? varCheck switch
                            {
                                "bool" => "false",
                                "decimal" => "0m",
                                "double" => "0b",
                                "float" => "0f",
                                "Guid" => "Guid.NewGuid();",
                                "int" or "byte" or "sbyte" or "uint" or "nint" or "nunint" or "long" or "ulong" or "short" or "ushort" => "0",
                                "ObjectId" => "= ObjectId.GenerateNewId()",
                                "string" => "string.Empty",
                                "DateTime" => "default",
                                _ => TodoFix(varCheck, "new()")
                            }
                            : varCheck switch
                            {
                                "bool" => "",
                                "Guid" => "Guid.NewGuid()",
                                "ObjectId" => "= ObjectId.GenerateNewId()",
                                "string" => "string.Empty",
                                "DateTime" => "",
                                "int" or "byte" or "sbyte" or "uint" or "nint" or "nunint" or "long" or "ulong" or "short" or "ushort" => "",
                                "decimal" => "",
                                "double" => "",
                                "float" => "",
                                _ => TodoFix(varCheck, "new()")
                            };
    }
    private void SetDefaultValues(TextLinesHandler curFile)
    {
        for(var i = 0; i < curFile.Length; i++)
        {
            curFile[i] = curFile[i].TrimEnd();
            var row = curFile[i].Trim();
            if(!IsComment(row) && IsProperty(row) && !HasDefaultValue(row) && row.Trim().EndsWith('}'))
            {
                var prop = row.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                //var propName = prop[name];
                var propType = prop[varPos];
                var propDefault = GetDefaultValue(propType);
                if(propDefault.Length > 0) curFile[i] += $" = {propDefault};";
            }
        }
        curFile.Refresh();
    }
    private string SetProperCase(string name) => name.Length switch
    {
        0 => "",
        1 => name.ToUpper(),
        _ => name[..1].ToUpper() + name[1..]
    };
    private void SetProperNames(TextLinesHandler curFile)
    {
        for(var i = 0; i < curFile.Length; i++)
        {
            curFile[i] = curFile[i].TrimEnd();
            var row = curFile[i].Trim();
            if(!IsComment(row) && IsProperty(row))
            {
                var corr = row.Contains(" static ") ? 1 : 0;
                //System.Diagnostics.Debug.Assert(corr == 0);
                var prop = row.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var propName = prop[namePos + corr];
                var newName = propName;
                if(IsLowerCase(newName))
                    newName = SetProperCase(newName);
                if(HasUnderscore(newName))
                    newName = FixUnderscores(newName);
                if (propName!=newName)
                    curFile[i] = curFile[i].Replace($" {propName} ", $" {newName} ");
            }
        }
    }
}
