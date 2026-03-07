using System;
using System.Linq;

class ArrayDuplicateRemover
{
    static void Main()
    {
        int[] arr = {1, 2, 2, 3, 4, 4, 5};

        var unique = arr.Distinct();

        Console.WriteLine("Array without duplicates:");

        foreach (var num in unique)
        {
            Console.Write(num + " ");
        }
    }
}