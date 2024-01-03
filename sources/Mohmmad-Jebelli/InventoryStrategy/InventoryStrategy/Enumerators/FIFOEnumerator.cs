using InventoryStrategy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStrategy.Enumerators;

public class FIFOEnumerator<T> : BaseEnuemrator<T>, IEnumerator<T>
{
    public FIFOEnumerator(List<T> products) : base(products)
    {
        _index = -1;
    }

    public override bool MoveNext()
    {
        if (_index < _items.Count - 1)
        {
            _index++;
            return true;
        }
        else
            return false;
    }


    public override void Reset() => _index = 0;

}

