using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CSharpAlgorithms.Test
{
    [TestFixture]
    public class BinarySearchTests
    {
        [Test]
        public void BinarySearch_SortedInput_ReturnsCorrectIndex()
        {
            int[] input = { 0, 3, 4, 5, 7, 9, 12, 15, 22 };

            Assert.AreEqual(2, Searching.BinarySearch(input, 4));
            Assert.AreEqual(4, Searching.BinarySearch(input, 8));
            Assert.AreEqual(6, Searching.BinarySearch(input, 15));
            Assert.AreEqual(7, Searching.BinarySearch(input, 22));

            Assert.AreEqual(2, Searching.BinarySearch(input, 4));
            Assert.AreEqual(4, Searching.BinarySearch(input, 8));
            Assert.AreEqual(6, Searching.BinarySearch(input, 15));
            Assert.AreEqual(7, Searching.BinarySearch(input, 22));
        }
    }
}
