using InventoryStrategy.Models;
using InventoryStrategy;

var inventory = new InventoryWrapper<Product>(InventoryManagementApproach.FirstInFirstOut);

inventory.Add(new Product(10, "IPhone10"));
inventory.Add(new Product(22, "IPhone20"));
inventory.Add(new Product(30, "IPhone30"));
inventory.Add(new Product(82, "IPhone40"));

Console.WriteLine("Enumerating products using a Qeueu approach (FIFO):");
foreach (var product in inventory)
{
    Console.WriteLine(product);
}

Console.WriteLine("==================================================");

var inventory2 = new InventoryWrapper<Product>(InventoryManagementApproach.LastInFirstOut);

inventory2.Add(new Product(10, "IPhone10"));
inventory2.Add(new Product(22, "IPhone20"));
inventory2.Add(new Product(30, "IPhone30"));
inventory2.Add(new Product(82, "IPhone40"));

Console.WriteLine("Enumerating products using a stack approach (LIFO):");
foreach (var product in inventory2)
{
    Console.WriteLine(product);
}
