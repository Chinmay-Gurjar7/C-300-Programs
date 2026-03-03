using System;

class SalaryCalculator
{
    static void Main()
    {
        Console.Write("Enter basic salary: ");
        double basic = Convert.ToDouble(Console.ReadLine());

        double hra = basic * 0.20;
        double da = basic * 0.10;
        double totalSalary = basic + hra + da;

        Console.WriteLine("HRA: " + hra);
        Console.WriteLine("DA: " + da);
        Console.WriteLine("Total Salary: " + totalSalary);
    }
}