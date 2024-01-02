using InventoryStrategy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStrategy.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    private int curIndex;
    private Product curProduct;
    private List<Product> products = new();

    public LIFOEnumerator(List<Product> products)
    {
        this.products = products;
        curIndex = products.Count;
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
        if (--curIndex == -1)
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
        curIndex = products.Count();
    }
}
