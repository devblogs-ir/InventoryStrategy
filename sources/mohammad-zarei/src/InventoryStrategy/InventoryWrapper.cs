using InventoryStrategy.Enumerators;
using InventoryStrategy.Models;
using System.Collections;

namespace InventoryStrategy;

public class InventoryWrapper<T> : IEnumerable<T>
{
    private readonly InventoryManagementApproach _managementApproach;
    private readonly List<T> _goods;

    public InventoryWrapper(InventoryManagementApproach managementApproach)
    {
        _managementApproach = managementApproach;
        _goods = new List<T>();
    }

    public void Add(T good)
    {
        _goods.Add(good);
    }

    public IEnumerator<T> GetEnumerator()
    {
        switch (_managementApproach)
        {
            case InventoryManagementApproach.FirstInFirstOut:
                return new FIFOEnumerator<T>(_goods);
            case InventoryManagementApproach.LastInFirstOut:
                return new LIFOEnumerator<T>(_goods);
            default:
                throw new ArgumentException("Invalid approach");
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
