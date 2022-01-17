// See https://aka.ms/new-console-template for more information
using SRPLive;

var fh = new TextFileHandler();
fh.Filename = "Test.txt";
var txt = fh.Load();

foreach (var row in txt.Contents)
{
    Console.WriteLine(row);
}

fh.Save(txt);
