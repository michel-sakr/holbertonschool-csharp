using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary>Starting set of tests for camelcase</summary>
    public class Tests
    {
        [Test]
        ///<summary>test for five words</summary>
        public void fiveCamelCase()
        {
            string s = "hello World. This is First Test";
            int countUpper = Str.CamelCase(s);
            Assert.AreEqual(5, countUpper);
        }
        [Test]
        ///<summary>test for one word</summary>
        public void noCamelCase()
        {
            string s = "hello.";
            int countUpper = Str.CamelCase(s);
            Assert.AreEqual(1, countUpper);
        }
        [Test]
        ///<summary>test for two words</summary>
        public void oneCamelCase()
        {
            string s = "hello world";
            int countUpper = Str.CamelCase(s);
            Assert.AreEqual(1, countUpper);
        }
        [Test]
        ///<summary>test for empty string</summary>
        public void emptyCamelCase()
        {
            string s = "";
            int countUpper = Str.CamelCase(s);
            Assert.AreEqual(0, countUpper);
        }
        [Test]
        ///<summary>test for null string</summary>
        public void nullCamelCase()
        {
            string s = null;
            int countUpper = Str.CamelCase(s);
            Assert.AreEqual(0, countUpper);
        }

    }
}