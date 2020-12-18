using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [TestCase("holaMundo", 2)]
        [TestCase("NOTHINGoneTwoThree", 3)]
        [TestCase("", 0)]
        [TestCase(null, 0)]
        public void Test_CamelCase(string s, int words)
        {
            Assert.AreEqual(Str.CamelCase(s), words);
        }
    }
}
