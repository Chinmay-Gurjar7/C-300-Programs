using System;

class TupleDemoProgram
{
    static void Main()
    {
        var student = (Id: 1, Name: "Rahul", Marks: 85);

        Console.WriteLine("Student ID: " + student.Id);
        Console.WriteLine("Student Name: " + student.Name);
        Console.WriteLine("Marks: " + student.Marks);
    }
}