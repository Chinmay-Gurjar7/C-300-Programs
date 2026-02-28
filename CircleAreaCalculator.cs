using System;

class CircleAreaCalculator
{
    static void Main()
    {
        Console.Write("Enter radius of circle: ");
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("Area of Circle = " + area);
    }
}