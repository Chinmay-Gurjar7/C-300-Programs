using Microsoft.Extensions.DependencyInjection;
using System;

interface IMessage
{
    void Send();
}

class Email : IMessage
{
    public void Send() => Console.WriteLine("Email Sent");
}

class Injectify
{
    static void Main()
    {
        var services = new ServiceCollection();
        services.AddTransient<IMessage, Email>();

        var provider = services.BuildServiceProvider();
        var msg = provider.GetService<IMessage>();

        msg.Send();
    }
}