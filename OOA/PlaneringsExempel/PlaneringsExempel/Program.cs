// See https://aka.ms/new-console-template for more information

using static PlaneringsExempel.Helper;

Console.WriteLine("Miniräknare");

int tal1 = 0;
int tal2 = 0;
string op = "";
int res = 0;

tal1 = AskForNumber("Ange tal 1");
while (true)
{
    op = AskForOperator("Ange operator");
    tal2 = AskForNumber("Ange tal 2");
    res = Calculate(tal1, op, tal2);
    Console.WriteLine($"{tal1} {op} {tal2} = {res}");
    tal1 = res;
}
