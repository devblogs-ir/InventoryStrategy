using System.Collections;
using Models;

namespace Enumerators;

public class FIFOEnumerator(List<Product> products_) : IEnumerator<Product>
{
    private readonly List<Product> products = products_ ;
    private int index = -1;

    public Product Current => products[index];

    object IEnumerator.Current => products[index];

    public void Dispose()
    {
        products.Clear();
    }

    public bool MoveNext()
    {
        int index_ = index  + 1;
        int count = products.Count();

        if (index_ < count)
        {
            index = index_ ;
            return true;
        }
        index = count;
        return false;
    }

    public void Reset()
    {
        index = -1;
    }
}