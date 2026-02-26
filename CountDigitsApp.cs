using System;

class CountDigitsApp
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int count = 0;

        while (num != 0)
        {
            num /= 10;
            count++;
        }

        Console.WriteLine("Total digits: " + count);
    }
}