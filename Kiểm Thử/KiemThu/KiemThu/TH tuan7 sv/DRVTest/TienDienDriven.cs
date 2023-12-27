using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRVTest

{   [TestClass]
    public class TienDienDriven
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                "|DataDirectory|\\data\\TinhTienDien1.csv", "TinhTienDien1#csv", DataAccessMethod.Sequential), DeploymentItem("data\\TinhTienDien1.csv")]    // đổi tên TextFile1 
        public void TinhTienDienTest1()
        {
            TestCode ttdDrv = new TestCode();
            // DataRow[0] cột 0, dòng sẽ lặp từ 0 cho đến hết
            int chiSoCu = Convert.ToInt32(TestContext.DataRow[0].ToString());
            int chiSoMoi = Convert.ToInt32(TestContext.DataRow[1].ToString());     
            double actual = ttdDrv.TinhTienDien(chiSoCu, chiSoMoi);
            double expected = Convert.ToDouble(TestContext.DataRow[2].ToString());
            Assert.AreEqual(expected, actual, 0.1);  // 0.1 sai số so sánh, do số thực
        }
    } // int chiSoCu = Convert.ToInt32(TestContext.DataRow[1].ToString()); dùng Convert cũng được

}
