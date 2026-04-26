using System;

[Obsolete("This class is outdated")]
class OldClass
{
    public void Show() => Console.WriteLine("Old Method");
}

class AttributesDemo
{
    static void Main()
    {
        OldClass obj = new OldClass();
        obj.Show();
    }
}