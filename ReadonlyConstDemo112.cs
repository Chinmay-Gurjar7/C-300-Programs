using System;

class ReadonlyConstDemo112
{
    readonly int x;
    const int y = 100;

    public ReadonlyConstDemo112(int val)
    {
        x = val;
    }

    static void Main()
    {
        ReadonlyConstDemo112 obj = new ReadonlyConstDemo112(50);
        Console.WriteLine("Readonly x: " + obj.x);
        Console.WriteLine("Const y: " + y);
    }
}