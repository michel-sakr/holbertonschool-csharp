using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary>Starting set of tests for palidnrome</summary>
    public class Tests
    {
        [Test]
        ///<summary>string with punctuations</summary>
        public void punctStr()
        {
            string str = "A man, a plan, a canal: Panama.";
            bool tOrF = Str.IsPalindrome(str);
            Assert.AreEqual(true,tOrF);
        }
        [Test]
        ///<summary>empty string</summary>
        public void empStr()
        {
            string str = "";
            bool tOrF = Str.IsPalindrome(str);
            Assert.AreEqual(true,tOrF);
        }
        [Test]
        ///<summary>palidnrome string</summary>
        public void normStr()
        {
            string str = "redivider";
            bool tOrF = Str.IsPalindrome(str);
            Assert.AreEqual(true,tOrF);
        }
        [Test]
        ///<summary>case sens string</summary>
        public void capStr()
        {
            string str = "Level";
            bool tOrF = Str.IsPalindrome(str);
            Assert.AreEqual(true,tOrF);
        }
        [Test]
        ///<summary>one char string</summary>
        public void charStr()
        {
            string str = "a";
            bool tOrF = Str.IsPalindrome(str);
            Assert.AreEqual(true,tOrF);
        }
        [Test]
        ///<summary>not palindrome string</summary>
        public void noneStr()
        {
            string str = "visual";
            bool tOrF = Str.IsPalindrome(str);
            Assert.AreEqual(false,tOrF);
        }
    }
}