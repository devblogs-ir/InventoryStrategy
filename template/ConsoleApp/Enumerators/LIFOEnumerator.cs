using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class LIFOEnumerator : IEnumerator<Product>
{
    private List<Product> products;
    private int currentIndex;

    public LIFOEnumerator(List<Product> products)
    {
        this.products = products;
        currentIndex = products.Count;
    }

    public Product Current => products[currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        products.Clear();
    }

    public bool MoveNext()
    {
        currentIndex--;
        return currentIndex >= 0;
    }

    public void Reset()
    {
        currentIndex = products.Count;
    }
}
