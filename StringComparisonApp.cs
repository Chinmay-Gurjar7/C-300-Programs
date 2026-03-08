using System;

class StringComparisonApp
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        if(s1.Equals(s2))
            Console.WriteLine("Strings are equal");
        else
            Console.WriteLine("Strings are different");
    }
}