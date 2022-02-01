// -----------------------------------------------------------------------------------------------
//  Program.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

Console.WriteLine("Hello, World!");

Console.WriteLine(TestingTheCyclomaticIndex.GetMeAString(0));

public static class TestingTheCyclomaticIndex
{
    public static string GetMeAString (int value)
    {
        Leet(value);
        // Två tester, test1: 0, test2: !=0
        // Given att value är 0
        // When metoden GetMeAString anropas
        // Then bör svaret vara "Hello"

        switch (value)
        {
            case 0:
                return "Hello";
            default:
                return "Good bye";
        }
    }

    public static string Leet (int value)
    {
        // Två if-satser
        // = två tester, 1 med 1337, 1 med 10
        //   plus ett test utan något av värdena

        if (value == 1337)
            return "Leet!";
        if (value == 10)
            return "Tio";

        return "";
    }

    public static int GetStringLength(string? data)
    {
        var length = (data?.Length) ?? 0;

        //var length = (data?.Length) ?? 0;
        return length;
    }
}