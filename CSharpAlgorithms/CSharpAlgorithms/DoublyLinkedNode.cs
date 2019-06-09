using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class DoublyLinkedNode<T>
    {
        public DoublyLinkedNode<T> Next { get; internal set; }
        public DoublyLinkedNode<T> Previous { get; internal set; }

        public T Value { get; set; }

        public DoublyLinkedNode(T value)
        {
            Value = value;
        }
    }
}
