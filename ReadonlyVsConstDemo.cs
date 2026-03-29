using System;

class Demo
{
    public const int x = 10;
    public readonly int y;

    public Demo(int val)
    {
        y = val;
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo(20);
        Console.WriteLine("Const: " + Demo.x);
        Console.WriteLine("Readonly: " + d.y);
    }
}