using System;

class NullableDemo
{
    static void Main()
    {
        int? number = null;

        if (number.HasValue)
            Console.WriteLine("Value: " + number.Value);
        else
            Console.WriteLine("Number is null");

        number = 25;
        Console.WriteLine("After assigning value: " + number);
    }
}