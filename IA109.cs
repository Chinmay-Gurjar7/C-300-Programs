using System;

interface IA109
{
    void MethodA();
}

interface IB109
{
    void MethodB();
}

class MultiInterfaceDemo109 : IA109, IB109
{
    public void MethodA()
    {
        Console.WriteLine("Method A");
    }

    public void MethodB()
    {
        Console.WriteLine("Method B");
    }

    static void Main()
    {
        MultiInterfaceDemo109 obj = new MultiInterfaceDemo109();
        obj.MethodA();
        obj.MethodB();
    }
}