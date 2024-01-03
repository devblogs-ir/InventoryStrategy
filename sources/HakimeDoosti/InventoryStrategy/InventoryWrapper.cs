using ConsoleApp.Enumerators;
using InventoryStrategy.Enumerators;
using InventoryStrategy.Models;
using System.Collections;

namespace InventoryStrategy;

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

        IEnumerator<Product> productEnumerator =
            _managementApproach == InventoryManagementApproach.FirstInFirstOut ?
            new FIFOEnumerator(Products) : new LIFOEnumerator(Products);


        while (productEnumerator.MoveNext())
        {
            yield return productEnumerator.Current;
        }


    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }


}



