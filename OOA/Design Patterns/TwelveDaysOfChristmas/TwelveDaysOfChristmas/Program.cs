// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------
var n = 15;
for (int i = 0; i <= n; i++) { var st = c('*', i); var sp = c(' ', n - i); if (f(i, $"{sp} *\n")) continue; w($"{sp}{st} | {st}{sp}\n"); }
bool f (int i, string s) { var b = i == 0; w(b ? s : ""); return b; }
string c (char c, int i) => new(c, i); void w (string s) => Console.Write(s);
var days = new string[] { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth ", "ninth", "tenth", "eleventh", "twelfth" };
var gifts = new string[] { "a partridge in a pear tree", "two turtle doves", "three French hens", "four calling birds", "five gold rings", "six geese a-laying", "seven swans a-swimming", "eight maids a-milking", "nine ladies dancing", "ten lords a-leaping", "eleven pipers piping", "twelve drummers drumming" };
string verse = "On the {0} day of Christmas my true love gave to me\n{1}";
for (int i = 0; i < 12; i++) Console.WriteLine($"{string.Format(verse, days[ i ], SayIt(i))}\n");
string SayIt (int i) { return (i > 0) ? i > 0 ? gifts[ i ] + (i == 1 ? "\nand " : ",\n") + SayIt(i - 1) : gifts[ i ] : gifts[ i ]; }
