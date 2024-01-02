using InventoryStrategy.Entities;
using InventoryStrategy.Enumerators;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        if (_managementApproach == InventoryManagementApproach.LastInFirstOut)
        {
            var lifo = new LIFOEnumerator(Products);
            while (lifo.MoveNext())
            {

                yield return lifo.Current;
            }

        }
        else
        {
            var fifo = new FIFOEnumerator(Products);

            while (fifo.MoveNext())
            {
                yield return fifo.Current;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

