using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaryToDecimal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void TestMethod1()
        {
            TestCode testCode = new TestCode();
            long actSum = testCode.BinaryToDe("11011101110111011101", out bool isSymmetry);
            Assert.AreEqual(13, actSum);
            Assert.AreEqual(false, isSymmetry);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestMethod2()
        {
            TestCode testCode = new TestCode();
            long actSum = testCode.BinaryToDe("13", out bool isSymmetry);
            Assert.AreEqual(13, actSum);
            Assert.AreEqual(false, isSymmetry);
        }

        [TestMethod]
        public void TestMethod3()
        {
            TestCode testCode = new TestCode();
            long actSum = testCode.BinaryToDe("1011", out bool isSymmetry);
            Assert.AreEqual(11, actSum);
            Assert.AreEqual(true, isSymmetry);
        }

        [TestMethod]
        public void TestMethod4()
        {
            TestCode testCode = new TestCode();
            long actSum = testCode.BinaryToDe("1100", out bool isSymmetry);
            Assert.AreEqual(12, actSum);
            Assert.AreEqual(false, isSymmetry);
        }
    }

}
