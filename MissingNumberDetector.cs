using System;

class MissingNumberDetector
{
    static void Main()
    {
        int[] arr = {1,2,3,5};

        int n = 5;
        int sum = n * (n + 1) / 2;

        int arrSum = 0;

        foreach(int num in arr)
            arrSum += num;

        Console.WriteLine("Missing Number: " + (sum - arrSum));
    }
}