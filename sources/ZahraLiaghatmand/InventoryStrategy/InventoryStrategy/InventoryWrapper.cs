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
        Products = new List<Product>();
    }
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
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}


