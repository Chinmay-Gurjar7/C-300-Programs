using System;

class ClassObjectDemo101
{
    int num = 10;

    public void Show()
    {
        Console.WriteLine("Number: " + num);
    }

    static void Main()
    {
        ClassObjectDemo101 obj = new ClassObjectDemo101();
        obj.Show();
    }
}