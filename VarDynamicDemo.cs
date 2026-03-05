using System;

class VarDynamicDemo
{
    static void Main()
    {
        var x = 10;   // Type decided at compile time
        dynamic y = 20;

        Console.WriteLine("var x: " + x);
        Console.WriteLine("dynamic y: " + y);

        y = "Now I am a string";
        Console.WriteLine("dynamic changed: " + y);
    }
}