using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("abbb", 0)]
        [TestCase("aabc", 2)]
        [TestCase("aaab", 3)]
        [TestCase("aabbc", 4)]
        [TestCase("aabbcc", -1)]
        [TestCase("", -1)]
        [TestCase(null, -1)]
        public void Test_UniqueChar_in_the_middle(string s, int index)
        {
            Assert.AreEqual(Str.UniqueChar(s), index);
        }
    }
}
