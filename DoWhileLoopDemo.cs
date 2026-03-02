using System;

class DoWhileLoopDemo
{
    static void Main()
    {
        int i = 1;

        do
        {
            Console.WriteLine("Count: " + i);
            i++;
        } while (i <= 5);
    }
}