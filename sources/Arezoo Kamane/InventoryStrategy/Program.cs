using ConsoleApp.Models;

namespace ConsoleApp;

public class Program
{
    static void Main(string[] args)
    {
        var inventory = new InventoryWrapper(InventoryManagementApproach.FirstInFirstOut);

        inventory.Add(new Product(1, "IPhone"));
        inventory.Add(new Product(2, "IPhone"));
        inventory.Add(new Product(3, "IPhone"));
        inventory.Add(new Product(4, "IPhone"));

        Console.WriteLine("Enumerating products using a Queue approach (FIFO):");
        foreach (var product in inventory)
        {
            Console.WriteLine(product);
        }



        var inventory1 = new InventoryWrapper(InventoryManagementApproach.LastInFirstOut);

        inventory1.Add(new Product(1, "IPhone"));
        inventory1.Add(new Product(2, "IPhone"));
        inventory1.Add(new Product(3, "IPhone"));
        inventory1.Add(new Product(4, "IPhone"));

        Console.WriteLine("Enumerating products using a stack approach (LIFO):");
        foreach (var product in inventory1)
        {
            Console.WriteLine(product);
        }
    }
}
