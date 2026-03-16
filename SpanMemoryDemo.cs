using System;

class SpanMemoryDemo
{
    static void Main()
    {
        int[] numbers = {1,2,3,4,5};

        Span<int> span = numbers;

        span[0] = 100;

        ReadOnlySpan<int> readOnlySpan = numbers;

        Console.WriteLine("Modified Array:");

        foreach(int num in readOnlySpan)
            Console.WriteLine(num);
    }
}