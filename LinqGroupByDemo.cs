using System;
using System.Linq;

class LinqGroupByDemo
{
    static void Main()
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 6 };

        var groups = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");

        foreach (var group in groups)
        {
            Console.WriteLine(group.Key + ": " + string.Join(", ", group));
        }
    }
}