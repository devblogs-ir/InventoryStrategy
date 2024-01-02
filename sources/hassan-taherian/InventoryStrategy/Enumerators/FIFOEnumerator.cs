using ConsoleApp.Models;
using System.Collections;

namespace ConsoleApp.Enumerators;

public class FIFOEnumerator : IEnumerator<Product>
{
    List<Product> _products;

    public FIFOEnumerator(List<Product> products)
    {
        _products = products;
    }
    int currentIndex = -1;
    public Product Current => _products[currentIndex];

    object IEnumerator.Current => Current;

    public void Dispose() { }

    public bool MoveNext()
    {
        currentIndex++;
        return currentIndex < _products.Count;
    }

    public void Reset()
    {
        currentIndex = -1;
    }
}
