using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CSharpAlgorithms.Test
{
    [TestFixture]
    class SinglyLinkedListTests
    {
        [Test]
        public void CreateEmptyList_CorrectState()
        {
            var list = new SinglyLinkedList<int>();
            Assert.IsTrue(list.IsEmpty);
            Assert.IsNull(list.Head);
            Assert.IsNull(list.Tail);
        }
    }
}
