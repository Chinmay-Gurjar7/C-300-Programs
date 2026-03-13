using System;

class StringSplitWords
{
    static void Main()
    {
        string sentence = "C Sharp programming is powerful";

        string[] words = sentence.Split(' ');

        Console.WriteLine("Words in the string:");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}