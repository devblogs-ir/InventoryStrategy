using InventoryStrategy.Console;
using InventoryStrategy.Console.Models;

public class Program
{
    private const InventoryManagementApproach _LIFOApproach = InventoryManagementApproach.LastInFirstOut;
    private const InventoryManagementApproach _FIFOApproach = InventoryManagementApproach.FirstInFirstOut;

    static void Main(string[] args)
    {
        InventoryWrapper inventoryMobile = new(_LIFOApproach)
        {
            new Mobile(1, "IPhone1"),
            new Mobile(2, "IPhone2"),
            new Mobile(3, "IPhone3"),
            new Mobile(4, "IPhone4")
        };

        Console.WriteLine($"Enumerating products using a stack approach {_LIFOApproach}:");

        foreach (var product in inventoryMobile)
        {
            Console.WriteLine(product);
        }

        InventoryWrapper inventoryLaptop = new(_FIFOApproach)
        {
            new Laptop(1, "Laptop1"),
            new Laptop(2, "Laptop2"),
            new Laptop(3, "Laptop3"),
            new Laptop(4, "Laptop4")
        };

        Console.WriteLine($"Enumerating products using a stack approach {_LIFOApproach}:");

        foreach (var product in inventoryLaptop)
        {
            Console.WriteLine(product);
        }

        Console.ReadKey();
    }
}