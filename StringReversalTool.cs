using System;

class StringReversalTool
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        char[] arr = text.ToCharArray();
        Array.Reverse(arr);

        Console.WriteLine("Reversed string: " + new string(arr));
    }
}