using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CSharpAlgorithms.Test
{
    [TestFixture]
    class SinglyLinkedListTests
    {
        private SinglyLinkedList<int> _list;

        [SetUp]
        public void Init()
        {
            _list = new SinglyLinkedList<int>();
        }

        [Test]
        public void CreateEmptyList_CorrectState()
        {
            Assert.IsTrue(_list.IsEmpty);
            Assert.IsNull(_list.Head);
            Assert.IsNull(_list.Tail);
        }

        [Test]
        public void AddFirst_And_AddLast_OneItem_CorrectState()
        {
            _list.AddFirst(1);

            CheckStateWithSingleNode(_list);

            _list.RemoveFirst();
            _list.AddLast(1);

            CheckStateWithSingleNode(_list);
        }

        [Test]
        public void AddRemoveToGetToStateWithSingleNode_CorrectState()
        {
            _list.AddFirst(1);
            _list.AddLast(2);
            _list.RemoveFirst();

            CheckStateWithSingleNode(_list);

            _list.AddFirst(2);
            _list.RemoveLast();

            CheckStateWithSingleNode(_list);
        }

        [Test]
        public void AddFirst_And_AddLast_AddItemsInCorrectOrder()
        {
            _list.AddFirst(1);
            _list.AddFirst(2);

            Assert.AreEqual(2, _list.Head.Value);
            Assert.AreEqual(2, _list.Tail.Value);

            _list.AddLast(3);

            Assert.AreEqual(3, _list.Tail.Value);
        }

        [Test]
        public void RemoveFirst_EmptyList_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => _list.RemoveFirst());
        }

        [Test]
        public void RemoveLast_EmptyList_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => _list.RemoveLast());
        }

        [Test]
        public void RemoveFirst_RemoveLast_CorrectState()
        {
            _list.AddFirst(1);
            _list.AddFirst(2);
            _list.AddFirst(3);
            _list.AddFirst(4);

            _list.RemoveFirst();
            _list.RemoveLast();

            Assert.AreEqual(3, _list.Head.Value);
            Assert.AreEqual(2, _list.Tail.Value);
        }

        private void CheckStateWithSingleNode(SinglyLinkedList<int> list)
        {
            Assert.AreEqual(1, list.Count);
            Assert.IsFalse(list.IsEmpty);
            Assert.AreSame(list.Head, list.Tail);
        }
    }
}
