using System;

class PayMaster
{
    static void Main()
    {
        Console.Write("Salary: ");
        double salary = double.Parse(Console.ReadLine());

        double tax = salary * 0.1;
        double net = salary - tax;

        Console.WriteLine("Net Salary: " + net);
    }
}