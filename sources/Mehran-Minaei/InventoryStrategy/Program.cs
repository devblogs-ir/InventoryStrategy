// See https://aka.ms/new-console-template for more information
using Models;

Console.WriteLine("Hello, World!");

var inventory = new InventoryWrapper(InventoryManagementApproach.FirstInFirstOut);


inventory.Add(new Product(1," Product 1"));
inventory.Add(new Product(2," Product 2"));
inventory.Add(new Product(3," Product 3"));
inventory.Add(new Product(4," Product 4"));
inventory.Add(new Product(5," Product 5"));

Console.WriteLine("Enumerating products using a stack approach (LIFO):");
foreach (var product in inventory)
{
    Console.WriteLine(product);
}