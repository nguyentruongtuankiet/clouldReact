using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRVTest
{
    class TestCode
    {
        public double TinhTienDien(int socu, int somoi)
        {
            const double BAC1 = 1484, BAC2 = 1533, BAC3 = 1786, BAC4 = 2242, BAC5 = 2503, BAC6 = 2587;

            double tien = 0;
            int tieuthu = somoi - socu;

            if (tieuthu <= 50) tien = tieuthu * BAC1;
            else if (tieuthu > 50 && tieuthu <= 100) tien = 50 * BAC1 + (tieuthu - 50) * BAC2;
            else if (tieuthu > 100 && tieuthu <= 200) tien = 50 * BAC1 + 50 * BAC2 + (tieuthu - 100) * BAC3;
            else if (tieuthu > 200 && tieuthu <= 300) tien = 50 * BAC1 + 50 * BAC2 + 100 * BAC3 + (tieuthu - 200) * BAC4;
            else if (tieuthu > 300 && tieuthu <= 400) tien = 50 * BAC1 + 50 * BAC2 + 100 * BAC3 + 100 * BAC4 + (tieuthu - 300) * BAC5;
            else tien = 50 * BAC1 + 50 * BAC2 + 100 * BAC3 + 100 * BAC4 + 100 * BAC5 + (tieuthu - 400) * BAC6;

            tien = tien * 1.1;
            return tien;
        }

    }
}
