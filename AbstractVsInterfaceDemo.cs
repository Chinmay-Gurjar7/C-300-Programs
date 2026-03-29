using System;

abstract class Animal
{
    public abstract void Sound();
}

interface IRun
{
    void Run();
}

class Dog : Animal, IRun
{
    public override void Sound()
    {
        Console.WriteLine("Bark");
    }

    public void Run()
    {
        Console.WriteLine("Dog runs");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Sound();
        d.Run();
    }
}