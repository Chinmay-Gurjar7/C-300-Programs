using System;

class CompoundInterest
{
    static void Main()
    {
        Console.Write("Enter Principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double amount = principal * Math.Pow((1 + rate / 100), time);
        double ci = amount - principal;

        Console.WriteLine("Compound Interest = " + ci);
        Console.ReadLine();
    }
}