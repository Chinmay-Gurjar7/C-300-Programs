using System;

class PositiveOrNegative
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 0)
            Console.WriteLine("Number is Positive");
        else
            Console.WriteLine("Number is Negative");

        Console.ReadLine();
    }
}