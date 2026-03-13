using System;
using System.Text.RegularExpressions;

class EmailValidator
{
    static void Main()
    {
        string email = "example@gmail.com";

        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        if (Regex.IsMatch(email, pattern))
            Console.WriteLine("Valid Email");
        else
            Console.WriteLine("Invalid Email");
    }
}