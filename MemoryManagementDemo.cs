using System;

class MemoryManagementDemo
{
    static void Main()
    {
        int[] arr = new int[1000];

        Console.WriteLine("Memory allocated for array.");

        arr = null;

        GC.Collect();

        Console.WriteLine("Garbage collection invoked.");
    }
}