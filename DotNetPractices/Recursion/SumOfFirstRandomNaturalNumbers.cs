using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.Recursion
{
    public class SumOfFirstRandomNaturalNumbers
    {
        public static int SumOfTen(int min, int max)
        {
            return CalcuSum(min, max);
        }

        public static int CalcuSum(int min, int val)
        {
            if (val == min)
                return val;
            return val + CalcuSum(min, val - 1);
        }
    }
}