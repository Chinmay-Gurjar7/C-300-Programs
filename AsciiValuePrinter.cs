using System;

class AsciiValuePrinter
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = Console.ReadKey().KeyChar;

        int asciiValue = (int)ch;

        Console.WriteLine("\nASCII value of " + ch + " = " + asciiValue);
    }
}