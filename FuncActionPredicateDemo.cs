using System;

class FuncActionPredicateDemo
{
    static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;
        Action<string> print = msg => Console.WriteLine(msg);
        Predicate<int> isEven = x => x % 2 == 0;

        print("Sum: " + add(3, 4));
        print("Is Even: " + isEven(4));
    }
}