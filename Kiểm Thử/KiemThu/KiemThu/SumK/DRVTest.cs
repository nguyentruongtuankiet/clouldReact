using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SumK
{
    [TestClass]
    public class DRVTest
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\SumK.csv", "SumK.csv", DataAccessMethod.Sequential), DeploymentItem("SumK.csv")]
        [TestMethod]
        public void TestMethod1()
        {
            try {
                TestCode testCode = new TestCode();
                long s0 = (long)Convert.ToDouble(TestContext.DataRow[0].ToString());
                long kqMongDoiK = (long)Convert.ToDouble(TestContext.DataRow[1].ToString());
                long kqMongDoiSum = (long)Convert.ToDouble(TestContext.DataRow[2].ToString());
                long kqThucK = testCode.K(s0, out long sum);
                long kqThucSum = sum;
                Assert.AreEqual(kqMongDoiK, kqThucK, 0.1);
                Assert.AreEqual(kqMongDoiSum, kqThucSum, 0.1);
            } catch {
                if (bool.Parse(TestContext.DataRow[3].ToString()))
                {
                    Assert.IsTrue(true);
                    return;
                }
                else
                {
                    Assert.Fail();
                    return;
                }
            }
           
        }
    }
}
