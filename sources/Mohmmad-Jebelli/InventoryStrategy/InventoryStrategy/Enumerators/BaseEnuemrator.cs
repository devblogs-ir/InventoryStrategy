using InventoryStrategy.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryStrategy.Enumerators
{
    public class BaseEnuemrator<T> : IEnumerator<T>
    {
        protected int _index = 0;
        protected List<T> _items;
        public BaseEnuemrator(List<T> products)
        {
            _items = products;
        }

        public T Current => _items[_index];

        object IEnumerator.Current => Current;

        public void Dispose() => _items = null;


        public virtual bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public virtual void Reset()
        {
            throw new NotImplementedException();
        }

        
    }

}
