using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAlgorithms.SymbolTables;

namespace CSharpAlgorithms
{
    public class ChainHashSet<TKey, TValue>
    {
        private SequentialSearchSt<TKey, TValue>[] _chains;

        private const int DefaultCapacity = 4;
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public ChainHashSet(int capacity)
        {
            Capacity = capacity;
            _chains = new SequentialSearchSt<TKey, TValue>[capacity];

            for(int i=0; i<capacity; i++)
            {
                _chains[i] = new SequentialSearchSt<TKey, TValue>();
            }
        }

        private int Hash(TKey key)
        {
            return (key.GetHashCode() & 0x7fffffff) % Capacity;
        }

        public TValue Get(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(paramName: "Key is not allowed to be null");
            }

            int index = Hash(key);
            if (_chains[index].TryGet(key, out TValue val))
            {
                return val;
            }

            throw new ArgumentException(message: "Key was not found");
        }

        public bool Contains(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(paramName: "Key is not allowed to be null");
            }

            int index = Hash(key);
            return _chains[index].TryGet(key, out TValue _);
        }

        public bool Remove(TKey key)
        {
            if(key == null)
            {
                throw new ArgumentNullException(paramName: "Key is not allowed to be null");
            }

            int index = Hash(key);
            if (_chains[index].Contains(key))
            {
                Count--;
                _chains[index].Remove(key);

                return true;
            }

            return false;
        }

        public void Add(TKey key, TValue val)
        {
            if (key == null)
            {
                throw new ArgumentNullException(paramName: "Key is not allowed to be null");
            }

            if(val == null)
            {
                Remove(key);
                return;
            }

            if (Count >= 10 * Capacity) Resize(2 * Capacity);

            int i = Hash(key);
            if (!_chains[i].Contains(key))
                Count++;

            _chains[i].Add(key, val);
        }

        private void Resize(int chains)
        {
            var temp = new ChainHashSet<TKey, TValue>(chains);
            for(int i=0; i<Capacity; i++)
            {
                foreach(var key in _chains[i].Keys())
                {
                    if(_chains[i].TryGet(key, out TValue val))
                    {
                        temp.Add(key, val);
                    }
                }
            }

            Capacity = temp.Capacity;
            Count = temp.Count;
            _chains = temp._chains;
        }

        /*TODO: Need to implement queues from previous lecture
        public IEnumerable<TKey> Keys()
        {
           var queue = new Queue<Tkey>();
           for(int i=0; i<Capacity; i++){
                foreach(TKey key in _chains[i].Keys())
                {
                    queue.Enqueue(key);
                }
            }

            return queue;
        }
        */
    }
}
