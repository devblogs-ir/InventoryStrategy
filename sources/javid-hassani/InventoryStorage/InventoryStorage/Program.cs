// See https://aka.ms/new-console-template for more information
using InventoryStorage;
using InventoryStorage.Models;

Console.WriteLine("Hello, World!");

var collection = new InventoryWrapper<Product>(EnumerationApproach.LIFO);

collection.Add(new(1, "nike"));
collection.Add(new(2, "addidas"));
collection.Add(new(3, "puma"));

Console.WriteLine("Enumerating products using a stack approach (LIFO):");

foreach (var product in collection)
{
    Console.WriteLine($"{product.Id} , {product.Name}");
}