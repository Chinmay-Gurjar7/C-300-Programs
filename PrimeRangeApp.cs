using System;

class PrimeRangeApp
{
    static void Main()
    {
        Console.Write("Enter start number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end number: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime Numbers:");

        for (int i = start; i <= end; i++)
        {
            int count = 0;

            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    count++;
            }

            if (count == 2)
                Console.Write(i + " ");
        }
    }
}