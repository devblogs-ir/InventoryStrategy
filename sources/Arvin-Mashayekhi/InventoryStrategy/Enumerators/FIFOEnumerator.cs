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

    public void Dispose() => products.Clear();
    

    public bool MoveNext()
    {
        currentIndext++;
        return currentIndext < products.Count;
    }

    public void Reset() => currentIndext = -1;
    
}

