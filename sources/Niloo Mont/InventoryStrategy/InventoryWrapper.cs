using InventoryStrategy.Enumerators;
using InventoryStrategy.Models.Enums;
using System.Collections;

namespace InventoryStrategy;

public class InventoryWrapper<T> : IEnumerable<T>
{
    private InventoryManagementApproach _managementApproach;
    private List<T> _list;
    public InventoryWrapper(InventoryManagementApproach managementApproach)
    {
        _managementApproach = managementApproach;
        _list = new List<T>();
    }
    public void Add(T item)
    {
        _list.Add(item);
    }
    public IEnumerator<T> GetEnumerator()
    {
        if (_managementApproach is InventoryManagementApproach.LastInFirstOut)
        {
            LIFOEnumerator<T> enumerator = new(_list);
            while (enumerator.MoveNext())
                yield return enumerator.Current;
        }
        if (_managementApproach is InventoryManagementApproach.FirstInFirstOut)
        {
            FIFOEnumerator<T> enumerator = new(_list);
            while (enumerator.MoveNext())
                yield return enumerator.Current;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
