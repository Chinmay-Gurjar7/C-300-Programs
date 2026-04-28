using Microsoft.Extensions.Configuration;
using System;

class ConfigNest
{
    static void Main()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        Console.WriteLine(config["AppName"]);
    }
}