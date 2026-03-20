using System;

sealed class SealedDemo114
{
    public void Show()
    {
        Console.WriteLine("Sealed Class");
    }
}

class Test114
{
    static void Main()
    {
        SealedDemo114 obj = new SealedDemo114();
        obj.Show();
    }
}