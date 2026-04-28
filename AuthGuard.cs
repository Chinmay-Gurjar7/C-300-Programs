using System;

class AuthGuard
{
    static void Main()
    {
        string role = "admin";

        if (role == "admin")
            Console.WriteLine("Full Access");
        else
            Console.WriteLine("Limited Access");
    }
}