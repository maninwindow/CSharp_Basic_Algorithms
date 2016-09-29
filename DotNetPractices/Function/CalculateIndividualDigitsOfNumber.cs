using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.Function
{
    public class CalculateIndividualDigitsOfNumber
    {
        public static int SumCal(int n)
        {
            string n1 = Convert.ToString(n);
            int sum = 0;
            for (int i = 0; i < n1.Length; i++)
                sum += Convert.ToInt32(n1.Substring(i, 1));
            return sum;
        }
    }
}
