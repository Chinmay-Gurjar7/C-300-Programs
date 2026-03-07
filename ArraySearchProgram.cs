using System;

class ArraySearchProgram
{
    static void Main()
    {
        int[] arr = {10, 20, 30, 40, 50};
        int search = 30;
        bool found = false;

        foreach (int num in arr)
        {
            if (num == search)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine("Element Found");
        else
            Console.WriteLine("Element Not Found");
    }
}