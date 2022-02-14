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
            Assert.True(Str.IsPalindrome("RaceCar"));
            Assert.True(Str.IsPalindrome("Race /Car. "));
            Assert.False(Str.IsPalindrome("Test"));
        }
    }
}
