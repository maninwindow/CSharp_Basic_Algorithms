using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.Function
{
    public class CalculateSumOfElementsinArray
    {
        public static int Sum(int[] arr1)
        {
            int tot = 0;
            for (int i = 0; i < arr1.Length; i++)
                tot += arr1[i];
            return tot;
        }
    }
}
