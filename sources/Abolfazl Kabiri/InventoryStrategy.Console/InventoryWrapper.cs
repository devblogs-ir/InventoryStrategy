using InventoryStrategy.Console.Enumerators;
using InventoryStrategy.Console.Models;
using System.Collections;

namespace InventoryStrategy.Console;
public class InventoryWrapper<T> : IEnumerable<T>
{
    private InventoryManagementApproach _managementApproach;
    private IEnumerator<T> enumerator;
    private List<T> Products;

    public InventoryWrapper(InventoryManagementApproach managementApproach)
    {
        _managementApproach = managementApproach;
        Products = new List<T>();
    }

    public void Add(T product) => Products.Add(product);

    public IEnumerator<T> GetEnumerator()
    {
        enumerator = _managementApproach switch
        {
            InventoryManagementApproach.FirstInFirstOut => new FifoEnumerator<T>(Products),
            InventoryManagementApproach.LastInFirstOut => new LifoEnumerator<T>(Products),
            _ => throw new InvalidOperationException("Invalid inventory management approach.")
        };
        return enumerator;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

}
