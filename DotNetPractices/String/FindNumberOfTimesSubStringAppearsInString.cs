using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.String
{
    public class FindNumberOfTimesSubStringAppearsInString
    {
        public static void FindNumberOfTimesSubString()
        {
            string str1;
            string findstring;
            int strt = 0;
            int cnt = -1;
            int idx = -1;

            Console.Write("\n\nFind the number of times a specific string appears in a string :\n");
            Console.Write("--------------------------------------------------------------------\n");

            Console.Write("Input the original string : ");
            str1 = Console.ReadLine();
            Console.Write("Input the string to be searched for : ");
            findstring = Console.ReadLine();

            while (strt != -1)
            {
                strt = str1.IndexOf(findstring, idx + 1);
                cnt += 1;
                idx = strt;
            }
            Console.Write("The string '{0}' occurs " + cnt + " times.\n", findstring);
        }
    }
}