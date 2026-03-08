using System;

class MatrixTransposeApp
{
    static void Main()
    {
        int[,] matrix = { {1,2,3},{4,5,6} };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        Console.WriteLine("Transpose Matrix:");

        for(int i=0;i<cols;i++)
        {
            for(int j=0;j<rows;j++)
            {
                Console.Write(matrix[j,i] + " ");
            }
            Console.WriteLine();
        }
    }
}