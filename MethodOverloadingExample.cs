using System;

class MethodOverloadingExample
{
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    static void Main()
    {
        Console.WriteLine("Multiplication of two numbers: " + Multiply(3, 4));
        Console.WriteLine("Multiplication of three numbers: " + Multiply(2, 3, 4));
    }
}