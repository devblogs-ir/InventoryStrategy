using InventoryStrategy.Enumerators;
using InventoryStrategy.Models;
using System.Collections;

namespace InventoryStrategy;

public class InventoryWrapper<T>(InventoryManagementApproach managementApproach) : IEnumerable<T>
{
    public InventoryManagementApproach _managementApproach = managementApproach;
    public List<T> Products = [];

    public void Add(T item)
    {
        Products.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        IEnumerator<T> enumeratorStrategy = null!;
        switch (_managementApproach)
        {
            case InventoryManagementApproach.LastInFirstOut:
                enumeratorStrategy = new LIFOEnumerator<T>(Products);
                break;
            case InventoryManagementApproach.FirstInFirstOut:
                enumeratorStrategy = new FIFOEnumerator<T>(Products);
                break;
        }
        while (enumeratorStrategy.MoveNext())
        {
            yield return enumeratorStrategy.Current;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
