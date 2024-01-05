using InventoryStrategy.Console.Enumerators;
using InventoryStrategy.Console.Models;
using System.Collections;

namespace InventoryStrategy.Console;
public class InventoryWrapper<T> : IEnumerable<T>
{
    private InventoryManagementApproach _managementApproach;
    private IEnumerator<T> _enumerator;
    private List<T> _items;

    public InventoryWrapper(InventoryManagementApproach managementApproach)
    {
        _managementApproach = managementApproach;
        _items = new List<T>();
    }

    public void Add(T product) => _items.Add(product);

    public IEnumerator<T> GetEnumerator()
    {
        _enumerator = _managementApproach switch
        {
            InventoryManagementApproach.FirstInFirstOut => new FifoEnumerator<T>(_items),
            InventoryManagementApproach.LastInFirstOut => new LifoEnumerator<T>(_items),
            _ => throw new InvalidOperationException("Invalid inventory management approach.")
        };
        return _enumerator;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

}
