// See https://aka.ms/new-console-template for more information
using InventoryStrategy.Models;
using InventoryStrategy;

var inventoryFIFO = new InventoryWrapper(InventoryManagementApproach.FirstInFirstOut);

inventoryFIFO.Add(new Product(1, "IPhone"));
inventoryFIFO.Add(new Product(2, "IPhone"));
inventoryFIFO.Add(new Product(3, "IPhone"));
inventoryFIFO.Add(new Product(4, "IPhone"));

Console.WriteLine("Enumerating products using a stack approach (FIFO):");
foreach (var product in inventoryFIFO)
{
    Console.WriteLine(product);
}

var inventoryLIFO = new InventoryWrapper(InventoryManagementApproach.LastInFirstOut);

inventoryLIFO.Add(new Product(1, "TV"));
inventoryLIFO.Add(new Product(2, "TV"));
inventoryLIFO.Add(new Product(3, "TV"));
inventoryLIFO.Add(new Product(4, "TV"));
Console.WriteLine("Enumerating products using a stack approach (LIFO):");
foreach (var product in inventoryLIFO)
{
    Console.WriteLine(product);
}

Console.ReadLine();