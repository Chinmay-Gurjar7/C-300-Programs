using System;
using System.Collections.Generic;

class Book
{
    public int Id;
    public string Title;
}

class BookVault
{
    static List<Book> books = new List<Book>();

    static void Main()
    {
        books.Add(new Book { Id = 1, Title = "C# Basics" });

        foreach (var b in books)
            Console.WriteLine($"{b.Id} - {b.Title}");
    }
}