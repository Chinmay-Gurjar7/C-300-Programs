using System;

class WordCountUtility
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Word count: " + words.Length);
    }
}