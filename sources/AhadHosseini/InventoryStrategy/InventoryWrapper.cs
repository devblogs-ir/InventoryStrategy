using InventoryStrategy.Enumerators;
using InventoryStrategy.Models;
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
        //if ( _managementApproach == InventoryManagementApproach.FirstInFirstOut)
            Products.Add(product);
        //else
        //    Products.Add(product);
    }
    private IEnumerable<Product> Events()
    {
        LIFOEnumerator Lifo = new (Products);
        FIFOEnumerator Fifo = new(Products);
        if (_managementApproach == InventoryManagementApproach.FirstInFirstOut)
        {
            while( Fifo.MoveNext())
            {
                yield return Fifo.Current;
            }
        }   
        else
        {
            while (Lifo.MoveNext())
            {
                yield return Lifo.Current;
            }
        }
            
    }
    public IEnumerator<Product> GetEnumerator()
    {
        return Events().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}
