using System;
using System.Collections.Generic;

class Product
{
    public string Name;
    public int Qty;
}

class StockKeeper
{
    static List<Product> items = new List<Product>();

    static void Main()
    {
        items.Add(new Product { Name = "Pen", Qty = 10 });

        foreach (var p in items)
            Console.WriteLine($"{p.Name} - {p.Qty}");
    }
}