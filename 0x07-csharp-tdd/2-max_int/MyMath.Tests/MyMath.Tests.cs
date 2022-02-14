using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            List<int> myList1 = new List<int>() {-4, 20, 3, 0};
            List<int> myList2 = new List<int>() {-1, -50, -5};
            Assert.AreEqual(Operations.Max(null), 0);
            Assert.AreEqual(Operations.Max(new List<int>()), 0);
            Assert.AreEqual(Operations.Max(myList1), 20);
            Assert.AreEqual(Operations.Max(myList2), -1);
        }
    }
}
