using System;

class PolymorphismDemo106
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Sum: " + (a + b));
    }

    public void Add(int a, int b, int c)
    {
        Console.WriteLine("Sum: " + (a + b + c));
    }

    static void Main()
    {
        PolymorphismDemo106 obj = new PolymorphismDemo106();
        obj.Add(2, 3);
        obj.Add(2, 3, 4);
    }
}