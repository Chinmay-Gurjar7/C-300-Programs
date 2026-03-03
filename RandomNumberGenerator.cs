using System;

class RandomNumberGenerator
{
    static void Main()
    {
        Random rand = new Random();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Random Number: " + rand.Next(1, 101));
        }
    }
}
