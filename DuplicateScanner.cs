using System;

class DuplicateScanner
{
    static void Main()
    {
        int[] arr = {1,2,3,4,2,5,3};

        Console.WriteLine("Duplicate Elements:");

        for(int i=0;i<arr.Length;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[i] == arr[j])
                {
                    Console.WriteLine(arr[i]);
                    break;
                }
            }
        }
    }
}