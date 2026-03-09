using System;

class MethodWithParametersDemo
{
    static void AddNumbers(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }

    static void Main()
    {
        AddNumbers(10, 20);
        AddNumbers(5, 7);
    }
}