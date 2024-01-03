using ConsoleApp.Enumerators;
using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp;

public class InventoryWrapper : IEnumerable<Product>
{
    public InventoryManagementApproach _managementApproach;
    public List<Product> Products;

    public InventoryWrapper(InventoryManagementApproach managementApproach)
    {
        _managementApproach = managementApproach;
        Products = new ();
    }

    public void Add(Product product)
    {
        Products.Add(product);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        if (_managementApproach == InventoryManagementApproach.FirstInFirstOut)
            return new FIFOEnumerator(Products);
        else if (_managementApproach == InventoryManagementApproach.LastInFirstOut)
            return new LIFOEnumerator(Products);
        else
            throw new NotSupportedException("Unsupported inventory management approach.");

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}
