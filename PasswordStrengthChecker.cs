using System;
using System.Text.RegularExpressions;

class PasswordStrengthChecker
{
    static void Main()
    {
        string password = "Strong@123";

        string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@#$%^&+=]).{8,}$";

        if (Regex.IsMatch(password, pattern))
            Console.WriteLine("Strong Password");
        else
            Console.WriteLine("Weak Password");
    }
}