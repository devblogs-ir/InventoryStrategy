using ConsoleApp.Enumerators;
using ConsoleApp.Models;
using System.Collections;
using System.Collections.Generic;

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
        if(_managementApproach == InventoryManagementApproach.LastInFirstOut)
        {
            var lifoProducts = new  LIFOEnumerator(Products);

            while (lifoProducts.MoveNext())
            {
                yield return lifoProducts.Current;
            }
        }
        else
        {
            var fifoProducts = new FIFOEnumerator(Products);

            while (fifoProducts.MoveNext())
            {
                yield return fifoProducts.Current;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}
