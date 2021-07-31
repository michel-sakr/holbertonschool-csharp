using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    ///<summary>Starting set of tests for unique</summary>
    public class Tests
    {
        [Test]
        ///<summary>first letter unique</summary>
        public void firstUnique()
        {
            string s = "batata";
            int un = Str.UniqueChar(s);
            Assert.AreEqual(0, un);
        }
        [Test]
        ///<summary>last letter unique</summary>
        public void lastUnique()
        {
            string s = "ananas";
            int un = Str.UniqueChar(s);
            Assert.AreEqual(5, un);
        }
        [Test]
        ///<summary>empty unique</summary>
        public void emptyUnique()
        {
            string s = "";
            int un = Str.UniqueChar(s);
            Assert.AreEqual(-1, un);
        }
        [Test]
        ///<summary>first letter unique</summary>
        public void noUnique()
        {
            string s = "bonbon";
            int un = Str.UniqueChar(s);
            Assert.AreEqual(-1, un);
        }
        [Test]
        ///<summary>one letter unique</summary>
        public void oneUnique()
        {
            string s = "a";
            int un = Str.UniqueChar(s);
            Assert.AreEqual(0, un);
        }
        [Test]
        ///<summary>2 unique</summary>
        public void twoUnique()
        {
            string s = "batatas";
            int un = Str.UniqueChar(s);
            Assert.AreEqual(0, un);
        }
        [Test]
        ///<summary>mid letter unique</summary>
        public void midUnique()
        {
            string s = "rotator";
            int un = Str.UniqueChar(s);
            Assert.AreEqual(3, un);
        }

    }
}