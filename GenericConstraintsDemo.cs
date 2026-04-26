using System;

class GenericClass<T> where T : class
{
    public void Show(T item)
    {
        Console.WriteLine(item.ToString());
    }
}

class GenericConstraintsDemo
{
    static void Main()
    {
        GenericClass<string> obj = new GenericClass<string>();
        obj.Show("Hello Constraint");
    }
}