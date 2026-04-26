using System;

class Publisher
{
    public event Action OnNotify;

    public void RaiseEvent()
    {
        OnNotify?.Invoke();
    }
}

class EventDemo
{
    static void Main()
    {
        Publisher p = new Publisher();

        p.OnNotify += () => Console.WriteLine("Event Triggered");

        p.RaiseEvent();
    }
}