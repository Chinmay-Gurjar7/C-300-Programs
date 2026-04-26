using System;

class GenericClass<T>
{
    public T Value;

    public void Show()
    {
        Console.WriteLine(Value);
    }
}

class GenericsDemo
{
    static void Main()
    {
        GenericClass<int> obj1 = new GenericClass<int> { Value = 10 };
        GenericClass<string> obj2 = new GenericClass<string> { Value = "Hello" };

        obj1.Show();
        obj2.Show();
    }
}