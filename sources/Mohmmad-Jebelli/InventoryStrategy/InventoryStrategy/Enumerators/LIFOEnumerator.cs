using InventoryStrategy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStrategy.Enumerators;

public class LIFOEnumerator<T> : BaseEnuemrator<T>,IEnumerator<T>
{
    public LIFOEnumerator(List<T> products):base(products)
    {
        _index = _items.Count ;
    }

    public override bool MoveNext()
    {
        if (_index > 0)
        {
            _index--;
            return true;
        }
        else
            return false;
    }

    public override void Reset() => _index = _items.Count - 1;
}

