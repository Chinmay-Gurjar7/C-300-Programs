using System;
using System.Text.Json;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class JsonSerializationDemo
{
    static void Main()
    {
        Person p = new Person { Name = "John", Age = 25 };

        string json = JsonSerializer.Serialize(p);
        Console.WriteLine("Serialized: " + json);

        Person obj = JsonSerializer.Deserialize<Person>(json);
        Console.WriteLine($"Deserialized: {obj.Name}, {obj.Age}");
    }
}