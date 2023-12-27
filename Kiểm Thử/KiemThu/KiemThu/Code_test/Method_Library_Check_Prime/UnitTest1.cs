using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Method_Library_Check_Prime
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary lib = new MethodLibrary.MethodLibrary();
            bool kqThuc = lib.primeCheck(13);   // test case 1 theo bảng test case
            bool kqMongdoi = true;
            Assert.AreEqual(kqMongdoi, kqThuc);

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary lib = new MethodLibrary.MethodLibrary();
            bool kqThuc = lib.primeCheck(-5);   // test case 1 theo bảng test case
            bool kqMongdoi = true;
            Assert.AreEqual(kqMongdoi, kqThuc);

        }
    }
}
