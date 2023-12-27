using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectBDCL1
{
    internal class HamKT
    {
        //hàm trả về string: "";"Scalene"; "Isosceles"; "Equilateral"
        public String Triangle(int a, int b, int c)
        {
            int match = 0;
            if (a == b)
                match = match + 1;
            if (a == c)
                match = match + 2;
            if (b == c)
                match = match + 3;
            if (match == 0)
                if ((a + b) <= c)
                    return ("");
                else if ((b + c) <= a)
                    return ("");
                else if ((a + c) <= b)
                    return ("");
                else return ("Scalene");
            else if (match == 1)
                if ((a + c) <= b)
                    return ("");
                else return ("Isosceles");
            else if (match == 2)
                if ((a + c) <= b)
                    return ("");
                else return ("Isosceles");
            else if (match == 3)
                if ((b + c) <= a)
                    return ("");
                else return ("Isosceles");
            else return ("Equilateral");

        }
        public bool IsLeapYear(int n)   
        {
            if (n < 1582)
            {
                throw new ArgumentException("yy");
            }
            if ((n % 4 == 0) || (n % 100 == 0 && n % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
