using InventoryStrategy.Models;

namespace InventoryStrategy;

public class Program
{
    static void Main(string[] args)
    {
        var mobileInventory = new InventoryWrapper<Mobile>(InventoryManagementApproach.FirstInFirstOut)
        {
            new(1, "S21 Ultra"),
            new(2, "IPhone6s"),
            new(3, "13T pro"),
            new(4, "IPhone8")
        };

        Console.WriteLine($"Enumerating products using a stack approach ({mobileInventory._managementApproach}):");
        foreach (var mobile in mobileInventory)
        {
            Console.WriteLine(mobile);
        }

        var laptopInventory = new InventoryWrapper<Laptop>(InventoryManagementApproach.LastInFirstOut)
        {
            new(1, "Lenevo"),
            new(2, "Asus"),
            new(3, "Omen"),
            new(4, "Dell")
        };

        Console.WriteLine($"Enumerating products using a queue approach ({laptopInventory._managementApproach}):");
        foreach (var laptop in laptopInventory)
        {
            Console.WriteLine(laptop);
        }
    }
}
