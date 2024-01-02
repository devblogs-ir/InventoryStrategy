using InventoryStrategy.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStrategy.Enumerators;
public class FIFOEnumerator : IEnumerator<Product>
{
    private int currentIndext;
    private List<Product> products = new();
    public FIFOEnumerator(List<Product> _products)
    {
        products = _products;
        currentIndext = -1;
    }
    public Product Current => products[currentIndext];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        products.Clear();
    }

    public bool MoveNext()
    {
        int index = ++currentIndext;
        int count = products.Count;

        if (index < count)
        {
            currentIndext = index;
            return true;
        }

        currentIndext = count;
        return false;
    }

    public void Reset()
    {
        currentIndext = -1;
    }
}

