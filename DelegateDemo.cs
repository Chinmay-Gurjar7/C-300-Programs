using System;

delegate void MyDelegate(string msg);

class DelegateDemo
{
    static void Show(string message)
    {
        Console.WriteLine(message);
    }

    static void Main()
    {
        MyDelegate d = Show;
        d("Hello Delegates");
    }
}