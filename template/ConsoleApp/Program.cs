using ConsoleApp.Models;

namespace ConsoleApp;

public class Program
{
    private const InventoryManagementApproach approach = InventoryManagementApproach.LastInFirstOut;

    static void Main(string[] args)
    {
        InventoryWrapper inventory = new(approach)
        {
            new Product(1, "IPhone1"),
            new Product(2, "IPhone2"),
            new Product(3, "IPhone3"),
            new Product(4, "IPhone4")
        };

        Console.WriteLine($"Enumerating products using a stack approach {approach}:");

        foreach (var product in inventory)
        {
            Console.WriteLine(product);
        }
    }
}
