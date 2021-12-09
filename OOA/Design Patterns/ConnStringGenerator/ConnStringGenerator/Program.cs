// See https://aka.ms/new-console-template for more information
using ConnStringGenerator.Builders;

Console.WriteLine("Hello, World!");

var con = new ConnStringBuilder();
var conn = con.
              SetDatabase("People").
              SetServer("(LocalDB)").
              Build();
Console.WriteLine(conn);

con.SetDatabase("People");
con.SetServer("(LocalDB)");
Console.WriteLine(con.Build());
