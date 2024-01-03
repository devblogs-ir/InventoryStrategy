using InventoryStorage.Enumerator;
using InventoryStorage.Models;
using System.Collections;

namespace InventoryStorage;
public class InventoryWrapper<T> : IEnumerable<T> where T : class
{
    private readonly EnumerationApproach _approach;
    private readonly List<T> _values;

    public InventoryWrapper(EnumerationApproach approach)
    {
        _approach = approach;
        _values = new List<T>();
    }

    public void Add(T item)
    {
        _values.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        var enumerator = ChooseApproach(_approach);

        return enumerator;
    }

    private IEnumerator<T> ChooseApproach(EnumerationApproach approach) => approach switch
    {
        EnumerationApproach.FIFO => new FifoEnumerato<T>(_values),
        EnumerationApproach.LIFO => new LifoEnumerator<T>(_values),

        _ => throw new NotSupportedException(),
    };

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
