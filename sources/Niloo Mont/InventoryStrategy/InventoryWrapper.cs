using InventoryStrategy.Enumerators;
using InventoryStrategy.Models.Enums;
using System.Collections;

namespace InventoryStrategy;
//
// Summary:
//     Gets ManagementApproach and iterates the list accordingly
public class InventoryWrapper<T> : IEnumerable<T>
{
    private readonly InventoryManagementApproach _managementApproach;
    private readonly List<T> _list;
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
        IEnumerator<T> enumerator = null!;
        if (_managementApproach is InventoryManagementApproach.LastInFirstOut)
            enumerator = new LIFOEnumerator<T>(_list);
        if (_managementApproach is InventoryManagementApproach.FirstInFirstOut)
            enumerator = new FIFOEnumerator<T>(_list);
        while (enumerator.MoveNext())
            yield return enumerator.Current;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
