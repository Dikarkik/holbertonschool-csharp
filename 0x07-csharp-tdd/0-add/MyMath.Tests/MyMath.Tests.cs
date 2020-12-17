using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_Add_positive_numbers()
        {
            Assert.AreEqual(Operations.Add(1, 2), 3);
        }

        [Test]
        public void Test_Add_negative_numbers()
        {
            Assert.AreEqual(Operations.Add(-1, -2), -3);
        }

        [Test]
        public void Test_Add_positive_and_negative_number()
        {
            Assert.AreEqual(Operations.Add(3, -3), 0);
        }
    }
}
