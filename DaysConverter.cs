using System;

class DaysConverter
{
    static void Main()
    {
        Console.Write("Enter total days: ");
        int totalDays = Convert.ToInt32(Console.ReadLine());

        int years = totalDays / 365;
        int remainingDays = totalDays % 365;

        int months = remainingDays / 30;
        int days = remainingDays % 30;

        Console.WriteLine("Years: " + years);
        Console.WriteLine("Months: " + months);
        Console.WriteLine("Days: " + days);
    }
}