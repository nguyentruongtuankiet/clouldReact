using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    public class TestCode
    {
        public long BinaryToDe(string sbin, out bool isSymmetry)
        {
            long sum = 0;
            long tpow = 1;
            const int MAX_BITS = 16;
            if (sbin.Length > MAX_BITS)
                throw new OverflowException("The number is too big.");
            for (int i = sbin.Length - 1; i >= 0; i--)
            {
                if (sbin[i] == '1')
                    sum = sum + tpow;
                else if (sbin[i] != '0')
                    throw new FormatException("Invalid binary format.");
                tpow = 2 * tpow;
            }
            string isSym = sum.ToString();
            int n = isSym.Length;

            for (int i = 0; i < n / 2; i++)
                if (isSym[i] != isSym[n - i - 1])
                    isSymmetry = false;
            isSymmetry = true;

            return sum;

        }
    }
}
