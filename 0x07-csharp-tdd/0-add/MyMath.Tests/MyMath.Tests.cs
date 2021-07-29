using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Starting set of tests for addition</summary>
    public class OperationsTests
    {
        [Test]
        ///<summary>both positive</summary>
        public void TestPositive()
        {
            int aPlusb = Operations.Add(1, 8);
            Assert.AreEqual(9, aPlusb);
        }
        [Test]
        ///<summary>both negative</summary>
        public void TestNegative()
        {
            int aPlusb = Operations.Add(-1, -8);
            Assert.AreEqual(-9, aPlusb);
        }
        [Test]
        ///<summary>both zero</summary>
        public void Test2Zero()
        {
            int aPlusb = Operations.Add(0, 0);
            Assert.AreEqual(0, aPlusb);
        }
        [Test]
        ///<summary>one positive / one negative</summary>
        public void TestDiffer()
        {
            int aPlusb = Operations.Add(1, -8);
            Assert.AreEqual(-7, aPlusb);
        }
        [Test]
        ///<summary>one zero / one negative</summary>
        public void TestZeroNeg()
        {
            int aPlusb = Operations.Add(0, -8);
            Assert.AreEqual(-8, aPlusb);
        }
        [Test]
        ///<summary>one positive / one zero</summary>
        public void TestZeroPos()
        {
            int aPlusb = Operations.Add(1, 0);
            Assert.AreEqual(1, aPlusb);
        }
    }
}