using System;

class SubstringReplacementTool
{
    static void Main()
    {
        Console.Write("Enter original string: ");
        string text = Console.ReadLine();

        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        string result = text.Replace(oldWord, newWord);

        Console.WriteLine("Updated string: " + result);
    }
}