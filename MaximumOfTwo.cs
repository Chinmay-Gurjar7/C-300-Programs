using System;

class MaximumOfTwo
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine("Maximum number is: " + num1);
        else
            Console.WriteLine("Maximum number is: " + num2);

        Console.ReadLine();
    }
}