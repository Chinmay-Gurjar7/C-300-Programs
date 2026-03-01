using System;

class ConstantReadonlyDemo
{
    const double PI = 3.14159;
    readonly int number;

    public ConstantReadonlyDemo(int num)
    {
        number = num;
    }

    static void Main()
    {
        ConstantReadonlyDemo obj = new ConstantReadonlyDemo(50);
        Console.WriteLine("Constant PI: " + PI);
        Console.WriteLine("Readonly number: " + obj.number);
    }
}