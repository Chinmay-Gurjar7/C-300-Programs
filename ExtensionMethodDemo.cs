using System;

static class Extensions
{
    public static int Square(this int num)
    {
        return num * num;
    }
}

class ExtensionMethodDemo
{
    static void Main()
    {
        int x = 5;
        Console.WriteLine(x.Square());
    }
}