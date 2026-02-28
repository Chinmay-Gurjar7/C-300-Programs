using System;

class RectangleAreaFinder
{
    static void Main()
    {
        Console.Write("Enter length of rectangle: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter breadth of rectangle: ");
        double breadth = double.Parse(Console.ReadLine());

        double area = length * breadth;

        Console.WriteLine("Area of Rectangle = " + area);
    }
}