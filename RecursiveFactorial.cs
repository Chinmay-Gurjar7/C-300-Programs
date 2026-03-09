using System;

class RecursiveFactorial
{
    static int Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;

        return n * Factorial(n - 1);
    }

    static void Main()
    {
        int num = 5;
        Console.WriteLine("Factorial of " + num + " = " + Factorial(num));
    }
}