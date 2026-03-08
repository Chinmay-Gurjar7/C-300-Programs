using System;

class PalindromeCheckerApp
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        char[] arr = text.ToCharArray();
        Array.Reverse(arr);

        string reversed = new string(arr);

        if(text == reversed)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}