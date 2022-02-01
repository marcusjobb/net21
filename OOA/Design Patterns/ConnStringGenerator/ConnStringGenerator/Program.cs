// See https://aka.ms/new-console-template for more information
using ConnStringGenerator.Builders;

Console.WriteLine("Hello, World!");

var con = new ConnStringBuilder();
var conn = con.
              SetDatabase("People").
              SetServer("(LocalDB)").
              Build();
Console.WriteLine(conn);

con.SetUsername("Marcus").SetPassword("qwerty123");
Console.WriteLine(con.Build());
