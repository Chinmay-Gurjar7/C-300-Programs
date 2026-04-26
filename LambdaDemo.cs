using System;

class LambdaDemo
{
    static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add(5, 3));
    }
}