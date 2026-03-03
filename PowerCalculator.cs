using System;

class PowerCalculator
{
    static void Main()
    {
        Console.Write("Enter base number: ");
        int baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter exponent: ");
        int exponent = Convert.ToInt32(Console.ReadLine());

        double result = Math.Pow(baseNum, exponent);

        Console.WriteLine("Result: " + result);
    }
}