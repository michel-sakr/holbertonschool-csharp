using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    /// <summary>
    /// Tests for addition
    /// </summary>
    public class OperationsTests
    {
        [Test]
        /// <summary>
        /// Two zeros
        /// </summary>
        public void TwoZeros()
        {
            int twozs = Operations.Add(0, 0);
            Assert.AreRqual(0, twozs);
        }
        
        /// <summary>
        /// Two positive
        /// </summary>
        public void TwoPositives()
        {
            int twos = Operations.Add(1, 9);
            Assert.AreRqual(10, twos);
        }
        
        /// <summary>
        /// Two negative
        /// </summary>
        public void TwoNegatives()
        {
            int twos = Operations.Add(-1, -2);
            Assert.AreRqual(-3, twos);
        }

        /// <summary>
        /// One positive one negative
        /// </summary>
        public void Alternative()
        {
            int twos = Operations.Add(-1, 1);
            Assert.AreRqual(0, twos);
        }
    }
}