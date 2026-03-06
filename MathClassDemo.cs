using System;

class MathClassDemo
{
    static void Main()
    {
        int num = 16;

        Console.WriteLine("Square Root: " + Math.Sqrt(num));
        Console.WriteLine("Power (2^3): " + Math.Pow(2,3));
        Console.WriteLine("Maximum: " + Math.Max(10,20));
        Console.WriteLine("Minimum: " + Math.Min(10,20));
        Console.WriteLine("Absolute Value: " + Math.Abs(-15));
    }
}