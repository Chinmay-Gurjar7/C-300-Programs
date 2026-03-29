using System;

class Demo
{
    public int a = 1;
    private int b = 2;
    protected int c = 3;

    public void Show()
    {
        Console.WriteLine(a + " " + b + " " + c);
    }
}

class Test : Demo
{
    public void Display()
    {
        Console.WriteLine(a + " " + c);
    }
}

class Program
{
    static void Main()
    {
        Test t = new Test();
        t.Show();
        t.Display();
    }
}