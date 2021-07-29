using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Starting set of tests for max</summary>
    public class Tests
    {
        [Test]
        ///<summary>max of positive</summary>
        public void posList()
        {
            List<int> newList = new List<int> { 4, 2, 1, 5, 3 };
            int max = Operations.Max(newList);
            Assert.AreEqual(5, max);
        }
        [Test]
        ///<summary>max of negative</summary>
        public void negList()
        {
            List<int> newList = new List<int> { -4, -2, -1, -5, -3 };
            int max = Operations.Max(newList);
            Assert.AreEqual(-1, max);
        }
        [Test]
        ///<summary>max of empty</summary>
        public void emptyList()
        {
            List<int> newList = new List<int>();
            int max = Operations.Max(newList);
            Assert.AreEqual(0, max);
        }
        [Test]
        ///<summary>max of neg/pos</summary>
        public void mixedList()
        {
            List<int> newList = new List<int> { -4, 2, 1, -5, 3 };
            int max = Operations.Max(newList);
            Assert.AreEqual(3, max);
        }
        [Test]
        ///<summary>max of one int</summary>
        public void singleList()
        {
            List<int> newList = new List<int> { 3 };
            int max = Operations.Max(newList);
            Assert.AreEqual(3, max);
        }
        [Test]
        ///<summary>max of repeated int</summary>
        public void repeatedList()
        {
            List<int> newList = new List<int> { -2, -2, -2 };
            int max = Operations.Max(newList);
            Assert.AreEqual(-2, max);
        }
    }
}