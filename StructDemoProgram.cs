using System;

struct Student
{
    public int id;
    public string name;

    public void Display()
    {
        Console.WriteLine("Student ID: " + id);
        Console.WriteLine("Student Name: " + name);
    }
}

class StructDemoProgram
{
    static void Main()
    {
        Student s1;
        s1.id = 101;
        s1.name = "Chinmay";

        s1.Display();
    }
}