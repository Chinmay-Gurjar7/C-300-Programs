using System;
using System.IO;

class FileForge
{
    static string path = "data.txt";

    static void Main()
    {
        File.WriteAllText(path, "Hello Data");
        string data = File.ReadAllText(path);
        Console.WriteLine(data);
    }
}