using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.Function
{
    public class FeibonacciSeries
    {
        public static int Fibo(int nno)
        {
            int num1 = 0;
            int num2 = 1;

            for (int i = 0; i < nno; i++)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }
            return num1;
        }
    }
}
