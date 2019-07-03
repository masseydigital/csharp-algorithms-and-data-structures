using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms.SymbolTables
{
    // St stands for single table
    class SequentialSearchSt<TKey, TValue>
    {
        private class Node
        {
            public TKey Key { get; }
            public TValue Value { get; set; }

            public Node Next { get; set; }

            public Node(TKey key, TValue value, Node next)
            {
                Key = key;
                Value = value;
                Next = next;
            }
        }

        private Node _first;
        private readonly EqualityComparer<TKey> _comparer;

        public int Count { get; private set; }

        public SequentialSearchSt()
        {
            _comparer = EqualityComparer<TKey>.Default;
        }

        public SequentialSearchSt(EqualityComparer<TKey> comparer)
        {
            _comparer = comparer ?? throw new ArgumentNullException();
        }

        public bool TryGet(TKey key, out TValue val)
        {
            for (Node x = _first; x != null; x = x.Next)
            {
                if (_comparer.Equals(x: key, y: x.Key))
                {
                    val = x.Value;
                    return true;
                }
            }

            val = default(TValue);
            return false;
        }

        public void Add(TKey key , TValue val)
        {
            if(key == null)
            {
                throw new ArgumentNullException(paramName: "Key can't be null.");
            }

            for(Node x = _first; x!=null; x = x.Next)
            {
                if (_comparer.Equals(x: key, y: x.Key))
                {
                    x.Value = val;
                    return;
                }
            }

            _first = new Node(key, val, _first);

            Count++;
        }

        public bool Contains(TKey key)
        {
            for (Node x = _first; x != null; x = x.Next)
            {
                if (_comparer.Equals(x: key, y: x.Key))
                {
                    return true;
                }
            }

            return false;
        }

        public IEnumerable<TKey> Keys()
        {
            for(Node x = _first; x!= null; x = x.Next)
            {
                yield return x.Key;
            }
        }

        public bool Remove(TKey key)
        {
            // Null key is not allowed
            // Counter should be adjusted properly
            // It should remove a key - value pair entirely
            // It should return false if the requested key was not found, otherwise true.

            if (key == null)
            {
                throw new ArgumentNullException(paramName: "Key can't be null");
            }

            if(Count == 1 && _comparer.Equals(x:_first.Key, y: key))
            {
                _first = null;
                Count--;
                return true;
            }

            Node prev = null;
            Node current = _first;

            while (current != null)
            {
                prev = current;
                current = current.Next;

                if (_comparer.Equals(x: current.Key, y: key))
                {
                    if(prev == null)
                    {
                        _first = current.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }

                    Count--;
                    return true;
                }

                prev = current;
                current = current.Next;
            }

            return false;
        }
    }
}
