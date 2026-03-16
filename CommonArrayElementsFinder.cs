using System;

class CommonArrayElementsFinder
{
    static void Main()
    {
        int[] a = {1,2,3,4,5};
        int[] b = {4,5,6,7};

        Console.WriteLine("Common Elements:");

        foreach(int x in a)
        {
            foreach(int y in b)
            {
                if(x == y)
                    Console.WriteLine(x);
            }
        }
    }
}