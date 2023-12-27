using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectBDCL1
{
    [TestClass]
    public class UnitTestHamKT
    {
        [TestMethod]
        public void TestMethodTC1()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(3, 4, 5);//Kết quả thực a,b,c=3
            string exp_Triangle = "Scalene"; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC2()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(1, 4, 4);//Kết quả thực a,b,c=3
            Console.WriteLine(act_Triangle);
            string exp_Triangle = "Isosceles"; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC3()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(4, 1, 4);//Kết quả thực a,b,c=3
            string exp_Triangle = "Isosceles"; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC4()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(4, 4, 1);//Kết quả thực a,b,c=3
            Console.WriteLine(act_Triangle);
            string exp_Triangle = "Isosceles"; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC5()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(0, 4, 4);//Kết quả thực a,b,c=3
            Console.WriteLine(act_Triangle);
            string exp_Triangle = ""; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC6()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(5, 0, 5);//Kết quả thực a,b,c=3
            Console.WriteLine(act_Triangle);
            string exp_Triangle = ""; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC7()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(4, 4, 0);//Kết quả thực a,b,c=3
            Console.WriteLine(act_Triangle);
            string exp_Triangle = ""; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC8()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(5, 4, 4);//Kết quả thực a,b,c=3
            Console.WriteLine(act_Triangle);
            string exp_Triangle = "Isosceles"; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC9()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(4, 5, 4);//Kết quả thực a,b,c=3
            Console.WriteLine(act_Triangle);
            string exp_Triangle = "Isosceles"; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC10()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(4, 4, 5);//Kết quả thực a,b,c=3
            Console.WriteLine(act_Triangle);
            string exp_Triangle = "Isosceles"; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC11()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(5, 5, 5);//Kết quả thực a,b,c=3
            Console.WriteLine(act_Triangle);
            string exp_Triangle = "Equilateral"; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC12()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(-3, -4, 4);//Kết quả thực a,b,c=3
            Console.WriteLine(act_Triangle);
            string exp_Triangle = ""; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

        [TestMethod]
        public void TestMethodTC13()
        {
            UnitTestProjectBDCL1.HamKT clsHamKT = new UnitTestProjectBDCL1.HamKT();
            string act_Triangle = clsHamKT.Triangle(2, 3, 5);//Kết quả thực a,b,c=3
            Console.WriteLine(act_Triangle);
            string exp_Triangle = ""; // kết quả mong đợi
            Assert.AreEqual(exp_Triangle, act_Triangle); // hàm so sánh
        }

    }
}
