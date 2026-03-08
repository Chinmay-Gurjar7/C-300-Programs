using System;
using System.Collections.Generic;

class CharacterFrequencyAnalyzer
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        Dictionary<char,int> freq = new Dictionary<char,int>();

        foreach(char c in text)
        {
            if(freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        foreach(var item in freq)
            Console.WriteLine(item.Key + " : " + item.Value);
    }
}