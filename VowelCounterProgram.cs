using System;

class VowelCounterProgram
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        int count = 0;

        foreach(char c in text.ToLower())
        {
            if("aeiou".Contains(c))
                count++;
        }

        Console.WriteLine("Total vowels: " + count);
    }
}