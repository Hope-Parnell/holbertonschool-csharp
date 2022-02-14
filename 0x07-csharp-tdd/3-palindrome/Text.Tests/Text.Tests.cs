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
            Assert.True(Str.IsPalindrome("Racecar"));
            Assert.True(Str.IsPalindrome("level"));
            Assert.True(Str.IsPalindrome("A man, a plan, a canal: Panama."));
            Assert.True(Str.IsPalindrome(""));
            Assert.False(Str.IsPalindrome("Test"));
        }
    }
}
