using System;

sealed class A
{
    public void Show()
    {
        Console.WriteLine("Sealed class");
    }
}

class Program
{
    static void Main()
    {
        A obj = new A();
        obj.Show();
    }
}