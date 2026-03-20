using System;

partial class PartialDemo115
{
    public void Method1()
    {
        Console.WriteLine("Method 1");
    }
}

partial class PartialDemo115
{
    public void Method2()
    {
        Console.WriteLine("Method 2");
    }

    static void Main()
    {
        PartialDemo115 obj = new PartialDemo115();
        obj.Method1();
        obj.Method2();
    }
}