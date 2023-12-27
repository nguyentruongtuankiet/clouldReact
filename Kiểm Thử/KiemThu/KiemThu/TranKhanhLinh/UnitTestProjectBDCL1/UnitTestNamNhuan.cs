using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectBDCL1
{
    [TestClass]
    public class UnitTestNamNhuan
    {
        [TestMethod]
        public void TestMethod1()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new HamKT();
            bool rs = clsHamKT.IsLeapYear(2002);
            Assert.AreEqual(false,rs);
        }
        [TestMethod]
        public void TestMethod2()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new HamKT();
            bool rs = clsHamKT.IsLeapYear(2004);
            Assert.AreEqual(true, rs);
        }
        [TestMethod]
        public void TestMethod3()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new HamKT();
            var ex = Assert.ThrowsException<ArgumentException>(() => clsHamKT.IsLeapYear(-200));
            Assert.AreEqual("yy", ex.Message);
        }
        [TestMethod]
        public void TestMethod4()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new HamKT();
            bool rs = clsHamKT.IsLeapYear(1582);
            Assert.AreEqual(false, rs);
        }
        [TestMethod]
        public void TestMethod5()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new HamKT();
            var ex = Assert.ThrowsException<ArgumentException>(() => clsHamKT.IsLeapYear(1581));
            Assert.AreEqual("yy", ex.Message);
        }

    }
}
