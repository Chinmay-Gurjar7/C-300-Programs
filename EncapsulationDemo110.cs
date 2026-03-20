using System;

class EncapsulationDemo110
{
    private int value;

    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }

    static void Main()
    {
        EncapsulationDemo110 obj = new EncapsulationDemo110();
        obj.Value = 50;
        Console.WriteLine("Value: " + obj.Value);
    }
}