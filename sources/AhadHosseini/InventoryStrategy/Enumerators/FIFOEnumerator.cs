using InventoryStrategy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStrategy.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    private int curIndex;
    private Product curProduct;
    private List<Product> products = new();
    public FIFOEnumerator(List<Product> products)
    {
        this.products = products;
        curIndex = -1;
        curProduct = default(Product);
    }

    public Product Current => products[curIndex];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        products.Clear();
    }

    public bool MoveNext()
    {
        if (++curIndex >= products.Count)
        {
            return false;
        }
        else
        {
            curProduct = products[curIndex];
        }
        return true;
    }

    public void Reset()
    {
        curIndex = -1;
    }
}