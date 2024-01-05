using InventoryStrategy.Enumerators;
using InventoryStrategy.Models;
using System.Collections;

namespace InventoryStrategy;

public class InventoryWrapper<T>(InventoryManagementApproach managementApproach) : IEnumerable<T> where T : class
{
    private readonly InventoryManagementApproach _managementApproach = managementApproach;
    private readonly List<T> _genericList = [];

    public InventoryManagementApproach ManagementApproach => _managementApproach;

    public void Add(T item) => _genericList.Add(item);

    public IEnumerator<T> GetEnumerator()
    {
        IEnumerator<T> enumeratorStrategy = ManagementApproach switch
        {
            InventoryManagementApproach.LastInFirstOut => new LIFOEnumerator<T>(_genericList),
            InventoryManagementApproach.FirstInFirstOut => new FIFOEnumerator<T>(_genericList),
            _ => throw new NotSupportedException("Strategy Not Supported"),
        };

        while (enumeratorStrategy.MoveNext())
        {
            yield return enumeratorStrategy.Current;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
