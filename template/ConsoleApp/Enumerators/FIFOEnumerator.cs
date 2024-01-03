using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    private List<Product> products;
    private int currentIndex;

    public FIFOEnumerator(List<Product> products)
    {
        this.products = products;
        currentIndex = -1;
    }

    public Product Current => products[currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        products.Clear();
    }

    public bool MoveNext()
    {
        currentIndex++;
        return currentIndex < products.Count;
    }

    public void Reset()
    {
        currentIndex = -1;
    }
}
