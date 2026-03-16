using System;

class StringImmutabilityDemo
{
    static void Main()
    {
        string str = "Hello";

        str = str + " World";

        Console.WriteLine(str);
    }
}