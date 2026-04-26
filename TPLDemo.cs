using System;
using System.Threading.Tasks;

class TPLDemo
{
    static void Main()
    {
        Parallel.For(1, 6, i =>
        {
            Console.WriteLine(i);
        });
    }
}