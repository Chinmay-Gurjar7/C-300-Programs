using System;

class DestructorDemo103
{
    ~DestructorDemo103()
    {
        Console.WriteLine("Destructor Called");
    }

    static void Main()
    {
        DestructorDemo103 obj = new DestructorDemo103();
    }
}