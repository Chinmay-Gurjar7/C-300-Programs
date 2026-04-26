using System;
using System.Reflection;

class Sample
{
    public void Show() => Console.WriteLine("Hello Reflection");
}

class ReflectionDemo
{
    static void Main()
    {
        Type t = typeof(Sample);

        foreach (var method in t.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}