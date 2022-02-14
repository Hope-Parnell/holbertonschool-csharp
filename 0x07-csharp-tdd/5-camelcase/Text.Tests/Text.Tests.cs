using NUnit.Framework;

namespace Text.Tests
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
            Assert.AreEqual(Str.CamelCase("jabdkj"), 1);
            Assert.AreEqual(Str.CamelCase(""), 0);
            Assert.AreEqual(Str.CamelCase("testAThing"), 3);
            Assert.AreEqual(Str.CamelCase("camelCase"), 2);
        }
    }
}
