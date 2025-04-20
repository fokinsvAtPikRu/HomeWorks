using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    internal class MyLazySequence<T>:IEnumerable<T>
    {
        T _current;
        Func<T, T> _iterator;
        IEnumerator<T> _enumerator;
        
        public MyLazySequence(T current, Func<T, T> iterator)
        {
            _current = current;
            _iterator = iterator;          
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                yield return _current;
                _current = _iterator(_current);
            }
        }       

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


