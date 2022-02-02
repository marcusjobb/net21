namespace Deleteme
{
    public class QuickAndDirtyNew
    {
        private const int access = 0;
        private const int name = 2;
        private const int vartype = 1;
        private static List<string>? TodoList = null;
        private List<string> files = new();
        private const string todoFile = @"..\..\..\Todo.txt";
        public QuickAndDirtyNew(string path)
        {
            files = Directory.GetFiles(path, "*.cs", SearchOption.AllDirectories).ToList();
        }

        public void AdaptPropertiesToMongo()
        {
            foreach(var file in files)
            {
                var curFile = new TextLinesHandler().Read(file);
                FixMongoProperties(curFile);
                //SetProperNames(curFile);
                SetDefaultValues(curFile);
                curFile.Save(file);
            }

            TodoSave();
        }

        private static bool HasDefaultValue(string row) => row.Contains("} = ");

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
                                    "DateTime" => "default",
                                    "int" or "byte" or "sbyte" or "uint" or "nint" or "nunint" or "long" or "ulong" or "short" or "ushort" => "",
                                    "decimal" => "",
                                    "double" => "",
                                    "float" => "",
                                    _ => TodoFix(varCheck, "new()")
                                };
        }

        private bool IsProperty(string row) => !row.StartsWith("//") && (row.Contains("{ get; set; }") || row.Contains("{ get; private set; }"));
        private bool IsComment(string row) => row.StartsWith("//");

        private void SetDefaultValues(TextLinesHandler curFile)
        {
            for(int i = 0; i < curFile.Length; i++)
            {
                curFile[i] = curFile[i].TrimEnd();
                var row = curFile[i].Trim();
                if(!IsComment(row) && IsProperty(row) && !HasDefaultValue(row))
                {
                    var prop = row.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var propName = prop[name];
                    var propType = prop[vartype];
                    var propDefault = GetDefaultValue(propType);
                    if(propDefault.Length > 0) curFile[i] += $" = {propDefault};";
                }
            }
        }

        private void FixMongoProperties(TextLinesHandler curFile)
        {
            const string addUsing = "using MongoDB.Bson.Serialization.Attributes;";
            const string tagElement = "[BsonElement(";
            const string tagId = "[BsonId]";
            var needUsing = false;
            for(int i = 0; i < curFile.Length; i++)
            {
                curFile[i] = curFile[i].TrimEnd();
                var row = curFile[i].Trim();
                if(!IsComment(row) && IsProperty(row))
                {
                    var prop = row.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var propName = prop[name];
                    var propType = prop[vartype];

                    var newName = propName;

                    if(IsLowerCase(newName))
                        newName = SetProperCase(newName);
                    if(HasUnderscore(newName))
                        newName = FixUnderscores(newName);
                    if (newName=="Id" && propType=="Guid")
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
                }
            }
            if(needUsing)
                AddUsing(curFile, addUsing);
        }

        private void AddUsing(TextLinesHandler curFile, string addUsing)
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

        private void SetProperNames(TextLinesHandler curFile)
        {
            for(int i = 0; i < curFile.Length; i++)
            {
                curFile[i] = curFile[i].TrimEnd();
                var row = curFile[i].Trim();
                if(!IsComment(row) && IsProperty(row))
                {
                    var prop = row.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var propName = prop[name];
                    var newName = propName;

                    if(IsLowerCase(newName))
                        newName = SetProperCase(newName);
                    if(HasUnderscore(newName))
                        newName = FixUnderscores(newName);

                    curFile[i] = curFile[i].Replace($" {propName} ", $" {newName} ");
                }
            }
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

        private bool HasUnderscore(string name)
        {
            return name.Contains('_');
        }

        private bool IsLowerCase(string name) => name == name.ToLower();
        private string SetProperCase(string name)
        {
            if(name.Length == 0) return "";
            if(name.Length == 1) return name.ToUpper();
            return name[..1].ToUpper() + name[1..];
        }
    }
}