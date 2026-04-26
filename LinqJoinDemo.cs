using System;
using System.Linq;

class Student { public int Id; public string Name; }
class Course { public int StudentId; public string CourseName; }

class LinqJoinDemo
{
    static void Main()
    {
        var students = new[]
        {
            new Student { Id = 1, Name = "A" },
            new Student { Id = 2, Name = "B" }
        };

        var courses = new[]
        {
            new Course { StudentId = 1, CourseName = "Math" },
            new Course { StudentId = 2, CourseName = "Science" }
        };

        var result = students.Join(courses,
            s => s.Id,
            c => c.StudentId,
            (s, c) => new { s.Name, c.CourseName });

        foreach (var item in result)
            Console.WriteLine($"{item.Name} - {item.CourseName}");
    }
}