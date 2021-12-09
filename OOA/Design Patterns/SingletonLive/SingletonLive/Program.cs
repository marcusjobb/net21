// See https://aka.ms/new-console-template for more information
using SingletonLive;

var test1 = Singleton.GetInstance();
var test2 = Singleton.GetInstance();

test1.Text = "Hello";
test2.Text = "Hello World";

Console.WriteLine(test1.Text);
Console.WriteLine(test2.Text);

Console.WriteLine(test1 == test2);