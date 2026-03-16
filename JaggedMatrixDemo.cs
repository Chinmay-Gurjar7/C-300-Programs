using System;

class JaggedMatrixDemo
{
    static void Main()
    {
        int[][] jagged = new int[3][];

        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };
        jagged[2] = new int[] { 6 };

        for (int i = 0; i < jagged.Length; i++)
        {
            foreach (int num in jagged[i])
                Console.Write(num + " ");

            Console.WriteLine();
        }
    }
}