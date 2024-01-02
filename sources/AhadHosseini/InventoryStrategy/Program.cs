// See https://aka.ms/new-console-template for more information
using InventoryStrategy.Models;
using InventoryStrategy;

var inventory = new InventoryWrapper(InventoryManagementApproach.FirstInFirstOut);

inventory.Add(new Product(1, "Product 1 "));
inventory.Add(new Product(2, "Product 2 "));
inventory.Add(new Product(3, "Product 3 "));
inventory.Add(new Product(4, "Product 4 "));
inventory.Add(new Product(6, "Product 5 "));


Console.WriteLine($"Enumerating products using a stack approach (FIFO):");
foreach (var product in inventory)
{
    Console.WriteLine(product);
}


var inventory2 = new InventoryWrapper(InventoryManagementApproach.LastInFirstOut);
inventory2.Add(new Product(1, "Product 1"));
inventory2.Add(new Product(2, "Product 2"));
inventory2.Add(new Product(3, "Product 3"));
inventory2.Add(new Product(4, "Product 4"));
inventory2.Add(new Product(6, "Product 5"));

Console.WriteLine("Enumerating products using a stack approach (LIFO):");
foreach (var product in inventory2)
{
    Console.WriteLine(product);
}