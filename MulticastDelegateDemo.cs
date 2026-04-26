using System;

delegate void MyDelegate();

class MulticastDelegateDemo
{
    static void Method1() => Console.WriteLine("Method1");
    static void Method2() => Console.WriteLine("Method2");

    static void Main()
    {
        MyDelegate d = Method1;
        d += Method2;

        d();
    }
}