using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SumK
{
    [TestClass]
    public class UnitTestSumK
    {
        [TestMethod]
        public void SumKTestMethod1()
        {
            TestCode testCode = new TestCode();
            long kqThucK = testCode.K(60, out long sum);
            long kqMongDoiK = 12;
            long kqThucSum = sum;
            long kqMongDoiSum = 66;
            Assert.AreEqual(kqMongDoiK, kqThucK);
            Assert.AreEqual(kqMongDoiSum, kqThucSum);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SumKTestMethod2()
        {
            TestCode testCode = new TestCode();
            long kqThucK = testCode.K(-60, out long sum);
            long kqMongDoiK = 12;
            long kqThucSum = sum;
            long kqMongDoiSum = 66;
            Assert.AreEqual(kqMongDoiK, kqThucK);
            Assert.AreEqual(kqMongDoiSum, kqThucSum);
        }
    }
}
