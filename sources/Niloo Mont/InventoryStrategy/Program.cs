using InventoryStrategy;
using InventoryStrategy.Models;
using InventoryStrategy.Models.Enums;

var fifoInventory = new InventoryWrapper<Product>(InventoryManagementApproach.FirstInFirstOut);

fifoInventory.Add(new Product(1, "IPhone1"));
fifoInventory.Add(new Product(2, "IPhone2"));
fifoInventory.Add(new Product(3, "IPhone3"));
fifoInventory.Add(new Product(4, "IPhone4"));

Console.WriteLine("Enumerating products using a stack approach (FIFO):");
foreach (var product in fifoInventory)
{
    Console.WriteLine(product);
}

var lifoInventory = new InventoryWrapper<Product>(InventoryManagementApproach.LastInFirstOut);

lifoInventory.Add(new Product(1, "IPhone1"));
lifoInventory.Add(new Product(2, "IPhone2"));
lifoInventory.Add(new Product(3, "IPhone3"));
lifoInventory.Add(new Product(4, "IPhone4"));

Console.WriteLine("Enumerating products using a stack approach (LIFO):");
foreach (var product in lifoInventory)
{
    Console.WriteLine(product);
}