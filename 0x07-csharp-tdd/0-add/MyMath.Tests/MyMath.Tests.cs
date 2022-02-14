using NUnit.Framework;

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
            int result = Operations.Add(0, 1);
            Assert.AreEqual(result, 1);
        }
    }
}
