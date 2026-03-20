using System;

class Parent104
{
    public void Display()
    {
        Console.WriteLine("Parent Class");
    }
}

class Child104 : Parent104
{
    public void Show()
    {
        Console.WriteLine("Child Class");
    }

    static void Main()
    {
        Child104 obj = new Child104();
        obj.Display();
        obj.Show();
    }
}