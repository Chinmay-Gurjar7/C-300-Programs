using System;

class MatrixAdditionProgram
{
    static void Main()
    {
        int[,] a = { {1,2}, {3,4} };
        int[,] b = { {5,6}, {7,8} };
        int[,] result = new int[2,2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i,j] = a[i,j] + b[i,j];
            }
        }

        Console.WriteLine("Matrix Addition Result:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(result[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}