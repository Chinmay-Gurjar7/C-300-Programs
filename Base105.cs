using System;

class Base105
{
    public virtual void Show()
    {
        Console.WriteLine("Base Method");
    }
}

class Derived105 : Base105
{
    public override void Show()
    {
        Console.WriteLine("Overridden Method");
    }

    static void Main()
    {
        Base105 obj = new Derived105();
        obj.Show();
    }
}