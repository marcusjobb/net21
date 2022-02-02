using Deleteme;

//var cl = new QuickAndDirty();
//cl.FixPropertiesDefault(@"C:\Users\marcu\OneDrive - Software Skills International AB\Dokument\Net21\GitHub\KVS\Deleteme\");
//cl.FixPropertiesDefault(@"C:\Users\marcu\source\MMPro\DailyNotes\");
//cl.FixJsonPropertiesName(@"C:\Users\marcu\source\MMPro\DailyNotes\");
//cl.MongoPatch(@"C:\Users\marcu\source\MMPro\DailyNotes\");

var qd = new QuickAndDirtyNew(@"C:\Users\marcu\OneDrive - Software Skills International AB\Dokument\Net21\GitHub\KVS\Deleteme\Deleteme\Models\");
qd.AdaptPropertiesToMongo();

namespace Deleteme
{
    internal class QuickAndDirty
    {
        private const int access = 0;
        private const int name = 2;
        private const int vartype = 1;
        private static List<string>? TodoList = null;

        public void FixJsonPropertiesName(string path)
        {
            const string addUsing = "using MongoDB.Bson.Serialization.Attributes;";
            const string tag = "BsonElement(";
            foreach(var filename in Directory.EnumerateFiles(path, "*.cs", SearchOption.AllDirectories))
            {
                PatchCode(filename, addUsing, tag, 0);
            }

            TodoSave();
        }

        public void FixPropertiesDefault(string path)
        {
            foreach(var filename in Directory.EnumerateFiles(path, "*.cs", SearchOption.AllDirectories))
            {
                if(filename.Contains("\\bin\\") || filename.Contains("\\obj\\")) continue;
                var data = File.ReadAllLines(filename);

                for(var i = 0; i < data.Length; i++)
                {
                    data[i] = data[i].TrimEnd();
                    if(!data[i].Trim().StartsWith("//"))
                    {
                        if(data[i].Contains("{ get; }"))
                        {
                            var tmp = data[i].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            var def = GetDefaultValue(tmp[vartype]);
                            if(def.Length != 0) data[i] += $" = {def};";
                        }

                        if(data[i].Contains("{ get; set; }"))
                        {
                            var tmp = data[i].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            var def = GetDefaultValue(tmp[vartype]);
                            if(def.Length != 0) data[i] += $" = {def};";
                        }

                        if(data[i].Contains("{ get; private set; }") && !data[i].Contains("} = "))
                        {
                            var tmp = data[i].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                            var def = GetDefaultValue(tmp[vartype]);
                            if(def.Length != 0) data[i] += $" = {def};";
                        }
                    }
                }

                File.WriteAllLines(filename, data);
            }

            TodoSave();
        }

        public void MongoPatch(string path)
        {
            const string addUsing = "using MongoDB.Bson.Serialization.Attributes;";
            const string tag = "[BsonId]";
            foreach(var filename in Directory.EnumerateFiles(path, "*.cs", SearchOption.AllDirectories))
            {
                PatchCode(filename, addUsing, tag, 0);
            }

            TodoSave();
        }

        private static void AddIdTag(string tag, List<string> data, string lastRow, int i)
        {
            if((data[i].Contains("{ get; }") || data[i].Contains("{ get; set; }")) && !data[i].Trim().StartsWith("//"))
            {
                var tmp = data[i].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(string.Equals(tmp[name], "id", StringComparison.CurrentCultureIgnoreCase) && tmp[vartype] == "Guid" && lastRow != tag)
                    data[i] = $"    {tag}\r\n{data[i]}";
            }
        }

        private static string TodoFix(string varCheck, string retVal)
        {
            if(TodoList == null)
                TodoList = File.Exists("Todo.txt") ? File.ReadAllLines("Todo.txt").ToList() : new List<string>();

            if(TodoList.IndexOf(varCheck) < 0)
                TodoList.Add(varCheck);

            return retVal;
        }

        private static void TodoSave()
        {
            File.WriteAllLines("Todo.txt", TodoList);
        }

        private void FixLcaseProperties(string tag, List<string> data, string lastRow, int i)
        {
            if(data[i].Contains("{ get; }"))
            {
                var tmp = data[i].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(tmp[name][0] == tmp[name].ToLower()[0] && !lastRow.StartsWith(tag))
                    data[i] = $"    {tag}\"{tmp[name]}\")]\r\n" + data[i].Replace("_", "").Replace(tmp[name], ProperCase(tmp[name]));
            }

            if(data[i].Contains("{ get; set; }") && !data[i].Trim().StartsWith("//"))
            {
                var tmp = data[i].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(tmp[name][0] == tmp[name].ToLower()[0] && !lastRow.StartsWith(tag))
                    data[i] = $"    {tag}\"{tmp[name]}\")]\r\n" + data[i].Replace("_", "").Replace(tmp[name], ProperCase(tmp[name]));
            }
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

        private void PatchCode(string filename, string addUsing, string tag, int cmd)
        {
            if(filename.Contains("\\bin\\") || filename.Contains("\\obj\\")) return;
            var data = File.ReadAllLines(filename).ToList();
            var nsRow = -1;
            var useAnotationsRow = -1;
            var hasAnnotations = false;
            var lastRow = "";
            for(var i = 0; i < data.Count; i++)
            {
                data[i] = data[i].TrimEnd();
                if(data[i].Trim().StartsWith("namespace ")) nsRow = i;
                if(data[i].Trim().StartsWith(addUsing)) useAnotationsRow = i;
                if(cmd == 0)
                    AddIdTag(tag, data, lastRow, i);
                if(cmd == 1)
                    FixLcaseProperties(tag, data, lastRow, i);

                if(data[i].Trim().Contains(tag)) hasAnnotations = true;
                lastRow = data[i].Trim();
            }

            if(hasAnnotations && useAnotationsRow < 0)
            {
                if(nsRow < 0) nsRow = 0;
                nsRow++;
                data.Insert(nsRow, addUsing);
            }

            File.WriteAllLines(filename, data);
        }

        private string ProperCase(string name)
        {
            return name[..1].ToUpper() + name[1..];
        }
    }
}