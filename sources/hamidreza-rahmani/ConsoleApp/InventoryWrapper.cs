using System.Collections;
using ConsoleApp.Enumerators;
using ConsoleApp.Models;

namespace ConsoleApp;

public class InventoryWrapper : IEnumerable<Product>
{
    public InventoryManagementApproach _managementApproach;
    public List<Product> Products;

    public InventoryWrapper(InventoryManagementApproach managementApproach)
    {
        _managementApproach = managementApproach;
        Products = new List<Product>();
    }

    public IEnumerator<Product> GetEnumerator()
    {
        if (_managementApproach.Equals(InventoryManagementApproach.FirstInFirstOut))
        {
            FIFOEnumerator fifo = new(Products);
            while (fifo.MoveNext()) yield return fifo.Current;
        }
        else
        {
            LIFOEnumerator lifo = new(Products);
            while (lifo.MoveNext()) yield return lifo.Current;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Product product)
    {
        Products.Add(product);
    }
}