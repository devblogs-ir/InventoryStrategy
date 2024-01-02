using ConsoleApp.Models;
namespace ConsoleApp;
public class Program
{
    static void Main(string[] args)
    {
        var inventoryLIFO = new InventoryWrapper(InventoryManagementApproach.LastInFirstOut);
        inventoryLIFO.Add(new Product(1, "IPhone"));
        inventoryLIFO.Add(new Product(2, "IPhone"));
        inventoryLIFO.Add(new Product(3, "IPhone"));
        inventoryLIFO.Add(new Product(4, "IPhone"));
        Console.WriteLine("Enumerating products using a stack approach (LIFO):");
        foreach (var product in inventoryLIFO)
        {
            Console.WriteLine(product.ToString());
        }
        var inventoryFIFO = new InventoryWrapper(InventoryManagementApproach.FirstInFirstOut);
        inventoryFIFO.Add(new Product(1, "IPhone"));
        inventoryFIFO.Add(new Product(2, "IPhone"));
        inventoryFIFO.Add(new Product(3, "IPhone"));
        inventoryFIFO.Add(new Product(4, "IPhone"));   
        Console.WriteLine("Enumerating products using a stack approach (FIFO):");
        foreach (var product in inventoryFIFO)
        {
            Console.WriteLine(product.ToString());
        }
    }
}
