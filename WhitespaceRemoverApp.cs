using System;

class WhitespaceRemoverApp
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        string result = text.Replace(" ", "");

        Console.WriteLine("After removing spaces: " + result);
    }
}