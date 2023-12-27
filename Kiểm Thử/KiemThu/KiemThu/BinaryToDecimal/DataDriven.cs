using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaryToDecimal
{
    [TestClass]
    public class DataDriven
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data.csv", DataAccessMethod.Sequential), DeploymentItem("data.csv")]
        public void TestMethodDriven()
        {
            TestCode testCode = new TestCode();
            String sbin = TestContext.DataRow[0].ToString();
            bool expIsSymmetry = Boolean.Parse(TestContext.DataRow[1].ToString());
            long expSum = (long)Double.Parse(TestContext.DataRow[2].ToString());
            long actSum = testCode.BinaryToDe(sbin, out bool isSymmetry);
            Assert.AreEqual(expIsSymmetry, isSymmetry);
            Assert.AreEqual(expSum, actSum);
        }
    }
}
