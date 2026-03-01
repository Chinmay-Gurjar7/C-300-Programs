using System;

class TypeCastingDemo
{
    static void Main()
    {
        int num = 10;
        double d = num;   // Implicit casting

        Console.WriteLine("Implicit Casting (int to double): " + d);

        double x = 9.78;
        int y = (int)x;   // Explicit casting

        Console.WriteLine("Explicit Casting (double to int): " + y);
    }
}