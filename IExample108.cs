using System;

interface IExample108
{
    void Show();
}

class InterfaceDemo108 : IExample108
{
    public void Show()
    {
        Console.WriteLine("Interface Method");
    }

    static void Main()
    {
        InterfaceDemo108 obj = new InterfaceDemo108();
        obj.Show();
    }
}