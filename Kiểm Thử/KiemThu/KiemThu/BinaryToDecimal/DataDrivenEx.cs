using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BinaryToDecimal
{
    [TestClass]
    public class DataDrivenEx
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data.csv", DataAccessMethod.Sequential), DeploymentItem("data.csv")]
        public void TestMethodDrivenEX()
        {
            try
            {
                TestCode testCode = new TestCode();
                String sbin = TestContext.DataRow[0].ToString();
                bool expIsSymmetry = Boolean.Parse(TestContext.DataRow[1].ToString());
                long expSum = (long)Double.Parse(TestContext.DataRow[2].ToString());
                long actSum = testCode.BinaryToDe(sbin, out bool isSymmetry);

                bool ex = Boolean.Parse(TestContext.DataRow[3].ToString());
                if (ex)
                {
                    Assert.Fail();
                }
                Assert.AreEqual(expIsSymmetry, isSymmetry);
                Assert.AreEqual(expSum, actSum);
               
            }
            catch(OverflowException e)
            {
                bool ex = Boolean.Parse(TestContext.DataRow[3].ToString());
                if (ex)
                {
                    Assert.IsTrue(true);
                    return;
                }
                Assert.Fail();
            }
            catch (FormatException e1)
            {
                bool ex = Boolean.Parse(TestContext.DataRow[3].ToString());
                if (ex)
                {
                    Assert.IsTrue(true);
                    return;
                }
                Assert.Fail();
            }
        }
    }
}
