using Microsoft.EntityFrameworkCore;
using System;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class AppDb : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("your_connection_string");
}

class EntityHub
{
    static void Main()
    {
        using var db = new AppDb();
        db.Students.Add(new Student { Name = "John" });
        db.SaveChanges();
    }
}