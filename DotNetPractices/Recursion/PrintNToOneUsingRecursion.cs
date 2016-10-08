using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.Recursion
{
    public class PrintNToOneUsingRecursion
    {
        public static int printNatura(int ctr, int stval)
        {
            if (ctr < 1)
            {
                return stval;
            }

            Console.Write(" {0} ", ctr);
            ctr--;
            return printNatura(ctr, stval);
        }
    }
}