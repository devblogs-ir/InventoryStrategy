using ConsoleApp.Models;

namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        InventoryWrapper inventory = new(InventoryManagementApproach.FirstInFirstOut)
        {
            new Product(1, "IPhone"),
            new Product(2, "IPhone"),
            new Product(3, "IPhone"),
            new Product(4, "IPhone")
        };

        InventoryWrapper lifoInventory = new(InventoryManagementApproach.LastInFirstOut)
        {
            new Product(5, "Laptop"),
            new Product(6, "Laptop"),
            new Product(7, "Laptop"),
            new Product(8, "Laptop")
        };

        Console.WriteLine("Enumerating products using a stack approach (LIFO):");
        foreach (var product in lifoInventory)
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("Enumerating products using a queue approach (FIFO):");
        foreach (var product in inventory)
        {
            Console.WriteLine(product);
        }
    }
}
