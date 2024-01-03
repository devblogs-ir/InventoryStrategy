using System.Collections;
using Enumerators;
using Models;

public class InventoryWrapper(InventoryManagementApproach managementApproach_) : IEnumerable<Product>
{
    public InventoryManagementApproach managementApproach = managementApproach_;
    public List<Product> Products = [];

    public void Add(Product product)
    {
        Products.Add(product);
    }

    public IEnumerator<Product> GetEnumerator()
    {
        if(managementApproach == InventoryManagementApproach.LastInFirstOut)
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