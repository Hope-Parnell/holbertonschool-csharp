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
            int[,] myMatrix = new int[,]
            {
                {0, 1, 2},
                {3, 4, 5},
                {6, 7, 8}
            };
            int[,] result = Matrix.Divide(myMatrix, 2);

            Assert.AreEqual(result[1,1], 2);
            Assert.AreEqual(Matrix.Divide(null, 2), null);
            Assert.AreEqual(Matrix.Divide(myMatrix, 0), null);
        }
    }
}
