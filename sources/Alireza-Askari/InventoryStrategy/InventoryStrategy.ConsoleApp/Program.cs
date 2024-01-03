using InventoryStrategy.ConsoleApp.Models;
using InventoryStrategy.ConsoleApp;

Console.WriteLine("Hello, World!");

//for FIFO
InventoryWrapper fifoList = new InventoryWrapper(InventoryManagementApproach.FirstInFirstOut);

fifoList.Add(new Product(1, "mobile1"));
fifoList.Add(new Product(2, "mobile2"));
fifoList.Add(new Product(3, "mobile3"));
fifoList.Add(new Product(4, "mobile4"));


Console.WriteLine("Enumerating products using a stack approach (FIFO):");
foreach (var product in fifoList)
{
    Console.WriteLine(product);
}


//for LIFO
InventoryWrapper lifoList = new InventoryWrapper(InventoryManagementApproach.LastInFirstOut);

lifoList.Add(new Product(1, "TV1"));
lifoList.Add(new Product(2, "TV2"));
lifoList.Add(new Product(3, "TV3"));
lifoList.Add(new Product(4, "TV4"));
lifoList.Add(new Product(5, "TV5"));


Console.WriteLine("Enumerating products using a stack approach (LIFO):");
foreach (var product in lifoList)
{
    Console.WriteLine(product);
}

