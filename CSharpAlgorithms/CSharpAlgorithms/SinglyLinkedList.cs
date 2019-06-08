using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        public void AddLast(T value)
        {
            AddLast(new Node<T>(value));
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            Head = Head.Next;

            if (Count == 1)
            {
                Tail = null;
            }

            Count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            if (Count == 1)
            {
                Head = Tail = null;
            }
            else
            {
                //find the penultimate node
                var current = Head;
                while(current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }

            Count--;
        }

        private void AddFirst(Node<T> node)
        {
            //save off the current head
            Node<T> tmp = Head;

            Head = node;

            //Shifting the former head
            Head.Next = tmp;

            Count++;

            if(Count == 1)
            {
                Tail = Head;
            }
        }

        private void AddLast(Node<T> node)
        {
            if (IsEmpty)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }

            Tail = node;
            Count++;
        }

        public bool IsEmpty => Count == 0;
    }
}
