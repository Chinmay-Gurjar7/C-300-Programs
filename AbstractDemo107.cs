using System;

abstract class AbstractDemo107
{
    public abstract void Show();

    public void Display()
    {
        Console.WriteLine("Non-Abstract Method");
    }
}

class Child107 : AbstractDemo107
{
    public override void Show()
    {
        Console.WriteLine("Abstract Method Implemented");
    }

    static void Main()
    {
        Child107 obj = new Child107();
        obj.Show();
        obj.Display();
    }
}