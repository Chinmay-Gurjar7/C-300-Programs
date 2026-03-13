using System;
using System.Text.RegularExpressions;

class RemoveSpecialChars
{
    static void Main()
    {
        string input = "Hello@# C# World!! 2026";

        string result = Regex.Replace(input, "[^a-zA-Z0-9 ]", "");

        Console.WriteLine("Original: " + input);
        Console.WriteLine("Cleaned: " + result);
    }
}