using System;
using System.Threading;

class MultithreadingDemo
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(500);
        }
    }

    static void Main()
    {
        Thread t = new Thread(PrintNumbers);
        t.Start();
    }
}