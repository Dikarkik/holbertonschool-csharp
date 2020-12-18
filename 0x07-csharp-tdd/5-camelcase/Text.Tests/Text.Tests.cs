using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [TestCase("Hola Mundo", 2)]
        [TestCase("NaNaNa", 3)]
        [TestCase("", 0)]
        public void Test_CamelCase(string s, int words)
        {
            Assert.AreEqual(Str.CamelCase(s), words);
        }
    }
}