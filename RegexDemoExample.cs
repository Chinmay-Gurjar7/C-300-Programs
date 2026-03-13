using System;
using System.Text.RegularExpressions;

class RegexDemoExample
{
    static void Main()
    {
        string text = "My phone number is 9876543210";

        Match match = Regex.Match(text, @"\d+");

        if (match.Success)
            Console.WriteLine("Number found: " + match.Value);
    }
}