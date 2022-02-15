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
            Assert.AreEqual(Str.UniqueChar("test"), 1);
            Assert.AreEqual(Str.UniqueChar("aabbcc"), -1);
            Assert.AreEqual(Str.UniqueChar("abcbca"), -1);
            Assert.AreEqual(Str.UniqueChar(""), -1);
            Assert.AreEqual(Str.UniqueChar(null), -1);
            Assert.AreEqual(Str.UniqueChar("abbcc"), 0);
        }
    }
}
