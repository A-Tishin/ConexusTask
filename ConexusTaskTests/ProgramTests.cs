using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConexusTask.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        private static int[] _zeroesTestArr1 = new[] { 1, 6, 4, 0, 0, 4, 0, 5, 5, 8 };
        private static int[] _zeroesTestArr2 = new[] { 1, 6, 4, 4, 5, 5, 8, 0, 0, 0 };
        private static int[] _medianTestArr = new[] { 2, 6, 4, 4, 5, 5, 8, 7, 9, 4 };

        [TestMethod()]
        [DataRow(0, true)]
        [DataRow(5, false)]
        [DataRow(-128, false)]
        public void IsPowerOfTwoTest(int isPower, bool methodResponse)
        {
            var result = Program.IsPowerOfTwo(isPower);
            Assert.IsTrue(result == methodResponse);
        }

        [TestMethod()]
        [DataRow(1, 1)]
        [DataRow(15, 4)]
        [DataRow(125, 6)]
        public void CountOneTest(int num, int onesCount)
        {
            var result = Program.CountOne(num);
            Assert.AreEqual(result, onesCount);
        }

        [TestMethod()]
        public void ZeroesToEndTest()
        {
            Program.ZeroesToEnd(_zeroesTestArr1);
            Assert.IsTrue(_zeroesTestArr1.SequenceEqual(_zeroesTestArr2));
        }

        [TestMethod()]
        public void GetIndexOfMedianTest()
        {
            var result = Program.GetIndexOfMedian(_medianTestArr);
            Assert.AreEqual(result, 6);
        }
    }
}