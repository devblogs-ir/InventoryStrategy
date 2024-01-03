

using ConsoleApp.Models;

namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        var fifo = new InventoryWrapper(InventoryManagementApproach.FirstInFirstOut);

        fifo.Add(new Product(1, "IPHONE"));
        fifo.Add(new Product(2, "SAMSUNG"));
        fifo.Add(new Product(3, "XIAOMI"));
        fifo.Add(new Product(4, "HUAWEI"));

        Console.WriteLine("Enumerating products using a stack approach (FIFO):");
        foreach (var product in fifo)
        {
            Console.WriteLine(product);
        }

        var lifo = new InventoryWrapper(InventoryManagementApproach.LastInFirstOut);

        lifo.Add(new Product(1, "IPHONE"));
        lifo.Add(new Product(2, "SAMSUNG"));
        lifo.Add(new Product(3, "XIAOMI"));
        lifo.Add(new Product(4, "HUAWEI"));

        Console.WriteLine("Enumerating products using a stack approach (LIFO):");
        foreach (var product in lifo)
        {
            Console.WriteLine(product);
        }
    }
}