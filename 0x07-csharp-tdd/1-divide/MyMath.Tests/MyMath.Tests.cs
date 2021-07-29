using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    ///<summary>Start a new set of tests for Division</summary>
    public class Tests
    {
        [Test]
        ///<summary>odd number division</summary>
        public void oddDiv()
        {
            int[,] matrix = new int[,] { { 3, 5 }, { 1, 7 }, { 9, 3 }, { 7, 1 } };
            int num = 2;
            int[,] newMat = Matrix.Divide(matrix, num);
            int[,] ans = new int[,] { { 1, 2 }, { 0, 3 }, { 4, 1 }, { 3, 0 } };
            Assert.AreEqual(ans, newMat);
        }
        [Test]
        ///<summary>even number division</summary>
        public void evenDiv()
        {
            int[,] matrix = new int[,] { { 2, 4 }, { 2, 6 }, { 8, 2 }, { 6, 8 } };
            int num = 2;
            int[,] newMat = Matrix.Divide(matrix, num);
            int[,] ans = new int[,] { { 1, 2 }, { 1, 3 }, { 4, 1 }, { 3, 4 } };
            Assert.AreEqual(ans, newMat);
        }
        [Test]
        ///<summary>null matrix division</summary>
        public void nullDiv()
        {
            int[,] matrix = null;
            int num = 2;
            int[,] newMat = Matrix.Divide(matrix, num);
            Assert.AreEqual(null, newMat);
        }
        [Test]
        ///<summary>division by 0</summary>
        public void zeroDiv()
        {
            int[,] matrix = new int[,] { { 3, 5 }, { 1, 7 }, { 9, 3 }, { 7, 1 } };
            int num = 0;
            int[,] newMat = Matrix.Divide(matrix, num);
            Assert.AreEqual(null, newMat);
        }
        [Test]
        ///<summary>0 in matrix</summary>
        public void matZeroDiv()
        {
            int[,] matrix = new int[,] { { 0, 5 }, { 1, 0 }, { 9, 3 }, { 0, 1 } };
            int num = 2;
            int[,] newMat = Matrix.Divide(matrix, num);
            int[,] ans = new int[,] { { 0, 2 }, { 0, 0 }, { 4, 1 }, { 0, 0 } };
            Assert.AreEqual(ans, newMat);
        }
    }
}