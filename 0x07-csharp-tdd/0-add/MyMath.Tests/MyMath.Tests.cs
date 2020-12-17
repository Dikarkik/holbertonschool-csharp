using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(1, 2, 3)]
        [TestCase(-1, -2, -3)]
        [TestCase(3, -3, 0)]
        public void Test_Add_positive_and_negative_numbers(int a, int b, int result)
        {
            Assert.AreEqual(Operations.Add(1, 2), 3);
        }
    }
}
