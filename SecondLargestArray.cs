using System;

class ArrayMethodDemo
{
    static void PrintArray(int[] arr)
    {
        Console.WriteLine("Array elements are:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        PrintArray(numbers);
    }
}