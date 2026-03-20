using System;

class AccessDemo111
{
    public int a = 10;
    private int b = 20;

    public void Show()
    {
        Console.WriteLine("Private b: " + b);
    }

    static void Main()
    {
        AccessDemo111 obj = new AccessDemo111();
        Console.WriteLine("Public a: " + obj.a);
        obj.Show();
    }
}