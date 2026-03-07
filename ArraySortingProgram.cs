using System;

class ArraySortingProgram
{
    static void Main()
    {
        int[] arr = {50, 10, 40, 20, 30};

        Array.Sort(arr);

        Console.WriteLine("Sorted Array:");

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}