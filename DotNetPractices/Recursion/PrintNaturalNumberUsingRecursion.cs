using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.Recursion
{
    public static class PrintNaturalNumberUsingRecursion
    {
        public static int printNatural(int stval, int ctr)
        {
            if (ctr < 1)
            {
                return stval;
            }
            ctr--;
            Console.Write(" {0} ", stval);
            return printNatural(stval + 1, ctr);
        }
    }
}