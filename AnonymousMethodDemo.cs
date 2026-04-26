using System;

delegate void MyDelegate(string msg);

class AnonymousMethodDemo
{
    static void Main()
    {
        MyDelegate d = delegate (string msg)
        {
            Console.WriteLine(msg);
        };

        d("Anonymous Method");
    }
}