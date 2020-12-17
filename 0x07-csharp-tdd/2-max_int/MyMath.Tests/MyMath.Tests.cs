using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        List<int> nums;

        [Test]
        public void Test_Max_positives()
        {
            nums = new List<int>() {0, 1, 2};
            Assert.AreEqual(Operations.Max(nums), 2);
        }

        [Test]
        public void Test_Max_negatives()
        {
            nums = new List<int>() {-3, -2, -1};
            Assert.AreEqual(Operations.Max(nums), -1);
        }

        [Test]
        public void Test_Max_positives_and_negatives()
        {
            nums = new List<int>() {-1, 0, 1};
            Assert.AreEqual(Operations.Max(nums), 1);
        }
    }
}
