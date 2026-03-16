using System;

class ValueReferenceComparison
{
    static void ChangeValue(int x)
    {
        x = 100;
    }

    static void ChangeReference(int[] arr)
    {
        arr[0] = 100;
    }

    static void Main()
    {
        int a = 10;
        ChangeValue(a);

        Console.WriteLine("Value Type: " + a);

        int[] arr = {10};
        ChangeReference(arr);

        Console.WriteLine("Reference Type: " + arr[0]);
    }
}