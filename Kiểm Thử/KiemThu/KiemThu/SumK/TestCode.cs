using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumK
{
    public class TestCode
    {
        public long K(long s0, out long sum)
        {
            if (s0 < 1)
            {
                throw new Exception("tong nho hon 1");
            }
            sum = 0;
            long i = 1;
            while (sum <= s0)
            {
                sum += i;
                i++;
            }
            return i;
        }

    }
}
