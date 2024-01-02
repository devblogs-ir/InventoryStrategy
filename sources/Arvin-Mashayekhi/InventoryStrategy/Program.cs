using InventoryStrategy.Entities;

namespace InventoryStrategy;
public class Program
{
    static void Main(string[] args)
    {
        var inventory = new InventoryWrapper(InventoryManagementApproach.FirstInFirstOut);

        inventory.Add(new Product(1, "IPhone"));
        inventory.Add(new Product(2, "IPhone"));
        inventory.Add(new Product(1, "IPhone"));
        inventory.Add(new Product(1, "IPhone"));

        Console.WriteLine("Enumerating products using a stack approach (LIFO):");
        foreach (var product in inventory)
        {
            Console.WriteLine(product);
        }
    }
}


