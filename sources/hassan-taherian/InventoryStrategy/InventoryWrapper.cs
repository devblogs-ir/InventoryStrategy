using ConsoleApp.Enumerators;
using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp;

public class InventoryWrapper(InventoryManagementApproach managementApproach) : IEnumerable<Product>
{
    public InventoryManagementApproach _managementApproach = managementApproach;
    public List<Product> Products = [];

    public void Add(Product product)
    {
        Products.Add(product);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        return _managementApproach switch
        {
            InventoryManagementApproach.FirstInFirstOut => new FIFOEnumerator(Products),
            InventoryManagementApproach.LastInFirstOut => new LIFOEnumerator(Products),
            _ => throw new NotImplementedException(),
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

}
