using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
    public int Age;
}

class StudentSphere
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Add  2. View  3. Delete  4. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;
                case 2:
                    ViewStudents();
                    break;
                case 3:
                    DeleteStudent();
                    break;
                case 4:
                    return;
            }
        }
    }

    static void AddStudent()
    {
        Student s = new Student();
        Console.Write("ID: ");
        s.Id = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        s.Name = Console.ReadLine();
        Console.Write("Age: ");
        s.Age = int.Parse(Console.ReadLine());

        students.Add(s);
    }

    static void ViewStudents()
    {
        foreach (var s in students)
            Console.WriteLine($"{s.Id} {s.Name} {s.Age}");
    }

    static void DeleteStudent()
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());
        students.RemoveAll(s => s.Id == id);
    }
}