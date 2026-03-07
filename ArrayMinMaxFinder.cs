using System;

class ArrayMinMaxFinder
{
    static void Main()
    {
        int[] arr = {25, 12, 45, 8, 30};

        int max = arr[0];
        int min = arr[0];

        foreach (int num in arr)
        {
            if (num > max)
                max = num;

            if (num < min)
                min = num;
        }

        Console.WriteLine("Largest Element = " + max);
        Console.WriteLine("Smallest Element = " + min);
    }
}