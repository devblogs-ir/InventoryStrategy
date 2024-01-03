using ConsoleApp.Enumerators;
using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp;

public class InventoryWrapper : IEnumerable<Product>
{
    public InventoryManagementApproach _managementApproach;
    public List<Product> Products;
    public IEnumerator<Product>? enumerator;

    public InventoryWrapper(InventoryManagementApproach managementApproach)
    {
        _managementApproach = managementApproach;
        Products = new List<Product>();
    }

    public void Add(Product product)
    {
        Products.Add(product);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        if (_managementApproach == InventoryManagementApproach.FirstInFirstOut)
        {
            enumerator = new FIFOEnumerator(Products);
        }
        else if (_managementApproach == InventoryManagementApproach.LastInFirstOut)
        {
            enumerator = new LIFOEnumerator(Products);
        }
        else
        {
            throw new InvalidOperationException("Invalid inventory management approach.");
        }

        return enumerator;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}
