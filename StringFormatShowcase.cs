using System;

class StringFormatShowcase
{
    static void Main()
    {
        string name = "Chinmay";
        int age = 19;
        double marks = 89.56;

        Console.WriteLine("Name: {0}, Age: {1}, Marks: {2:F2}", name, age, marks);
    }
}