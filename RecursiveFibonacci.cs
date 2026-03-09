using System;

class RecursiveFibonacci
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        int terms = 10;

        Console.WriteLine("Fibonacci Series:");
        for (int i = 0; i < terms; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}