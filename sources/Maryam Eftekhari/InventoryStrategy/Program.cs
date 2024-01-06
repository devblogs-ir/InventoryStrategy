using InventoryStrategy.Models;
using InventoryStrategy;

namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        var inventory = new InventoryWrapper(InventoryManagementApproach.LastInFirstOut);

        inventory.Add(new Product(1, "IPhone1"));
        inventory.Add(new Product(2, "IPhone2"));
        inventory.Add(new Product(3, "IPhone3"));
        inventory.Add(new Product(4, "IPhone4"));

        Console.WriteLine("Enumerating products using a stack approach (LIFO):");
        foreach (var product in inventory)
        {
            Console.WriteLine(product);
        }

        inventory = new InventoryWrapper(InventoryManagementApproach.FirstInFirstOut);

        inventory.Add(new Product(1, "Smart Watch1"));
        inventory.Add(new Product(2, "Smart Watch2"));
        inventory.Add(new Product(3, "Smart Watch3"));
        inventory.Add(new Product(4, "Smart Watch4"));

        Console.WriteLine("Enumerating products using a stack approach (FIFO):");
        foreach (var product in inventory)
        {
            Console.WriteLine(product);
        }
    }
}
