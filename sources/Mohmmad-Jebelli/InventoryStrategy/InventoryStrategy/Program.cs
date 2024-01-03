// See https://aka.ms/new-console-template for more information
using InventoryStrategy.Models;
using InventoryStrategy;

var inventory = new InventoryWrapper(InventoryManagementApproach.LastInFirstOut);

inventory.Add(new Product(1, "IPhone"));
inventory.Add(new Product(2, "Samsung"));
inventory.Add(new Product(3, "Mi"));
inventory.Add(new Product(4, "HTC"));

Console.WriteLine($"Enumerating products using a stack approach ({InventoryManagementApproach.LastInFirstOut.ToString()}):");

foreach (var product in inventory)
{
    Console.WriteLine(product);
}




var inventory2 = new InventoryWrapper(InventoryManagementApproach.FirstInFirstOut);

inventory2.Add(new Product(1, "IPhone"));
inventory2.Add(new Product(2, "Samsung"));
inventory2.Add(new Product(3, "Mi"));
inventory2.Add(new Product(4, "HTC"));

Console.WriteLine($"Enumerating products using a stack approach ({InventoryManagementApproach.FirstInFirstOut.ToString()}):");

foreach (var product in inventory2)
{
    Console.WriteLine(product);
}
