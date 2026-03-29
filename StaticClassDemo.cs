using System;

static class MathUtil
{
    public static int Square(int x)
    {
        return x * x;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(MathUtil.Square(5));
    }
}