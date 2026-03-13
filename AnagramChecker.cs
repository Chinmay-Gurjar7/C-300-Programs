using System;

class AnagramChecker
{
    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        char[] a = str1.ToLower().ToCharArray();
        char[] b = str2.ToLower().ToCharArray();

        Array.Sort(a);
        Array.Sort(b);

        if (new string(a) == new string(b))
            Console.WriteLine("Strings are Anagrams");
        else
            Console.WriteLine("Strings are NOT Anagrams");
    }
}