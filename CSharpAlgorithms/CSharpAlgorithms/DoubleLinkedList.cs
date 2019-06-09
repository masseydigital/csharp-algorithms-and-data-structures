using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgorithms
{
    class DoubleLinkedList<T>
    {
        public DoublyLinkedNode<T> Head { get;  set; }
        public DoublyLinkedNode<T> Tail { get;  set; }

        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedNode<T>(value));
        }

        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedNode<T>(value));
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            //Shift the head node
            Head = Head.Next;

            Count--;

            if(IsEmpty)
            {
                Tail = null;
            }
            else
            {
                Head.Previous = null;
            }
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            if(Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Previous.Next = null;  //null the last node
                Tail = Tail.Previous;       //shift the tail (now it is the former penultimate node)
            }

            Count--;
        }


        private void AddFirst(DoublyLinkedNode<T> node)
        {
            //Save off the head
            DoublyLinkedNode<T> temp = Head;

            //Point head to node
            Head = node;

            //Insert the rest of the list behind the head
            Head.Next = temp;

            if (IsEmpty)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }

            Count++;
        }

        private void AddLast(DoublyLinkedNode<T> node)
        {
            if (IsEmpty)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;

            }

            Tail = node;
            Count++;
        }
    }
}
