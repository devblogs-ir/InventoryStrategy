using InventoryStrategy.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStrategy.Enumerators;
public class LIFOEnumerator : IEnumerator<Product>
{
    private int currentIndext;
    private List<Product> products = new();
    public LIFOEnumerator(List<Product> _products)
    {
        products = _products;
        currentIndext = _products.Count();
    }
    public Product Current => products[currentIndext];

    object IEnumerator.Current => Current;

    public void Dispose()
       => products.Clear();
    

    public bool MoveNext()
       => currentIndext< products.Count && currentIndext > -1;

    public void Reset()
       => currentIndext = -1;
    
}

