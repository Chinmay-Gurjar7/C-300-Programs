using System;

class SafeBank
{
    static double balance = 1000;

    static void Main()
    {
        Console.WriteLine("1.Deposit 2.Withdraw");
        int ch = int.Parse(Console.ReadLine());

        if (ch == 1)
        {
            double amt = double.Parse(Console.ReadLine());
            balance += amt;
        }
        else
        {
            double amt = double.Parse(Console.ReadLine());
            balance -= amt;
        }

        Console.WriteLine("Balance: " + balance);
    }
}