using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        int[,] matrix;

        [SetUp]
        public void TestInit()
        {
            matrix = new int[,]
            {
                {0, 1, 2},
                {3, 4, 5},
                {6, 7, 8}
            };
        }

        [Test]
        public void Test_Divide_by_2()
        {
            int[,] expected = new int[,]
            {
                {0, 0, 1},
                {1, 2, 2},
                {3, 3, 4}
            };

            Assert.AreEqual(Matrix.Divide(matrix, 2), expected);
        }

        [Test]
        public void Test_Divide_by_0()
        {
            Assert.IsNull(Matrix.Divide(matrix, 0));
        }

        [Test]
        public void Test_Divide_null_matrix()
        {
            Assert.IsNull(Matrix.Divide(null, 2));
        }
    }
}
