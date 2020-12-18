using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [TestCase("Racecar", true)]
        [TestCase("level", true)]
        [TestCase("A man, a plan, a canal: Panama.", true)]
        public void Test_IsPalindrome(string s, bool response)
        {
            Assert.AreEqual(Str.IsPalindrome(s), response);
        }

        [Test]
        public void Test_empty_string()
        {
            Assert.AreEqual(Str.IsPalindrome(""), true);
        }
    }
}
