using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.String
{
    public class PrintCharactersOfStringInReverseOrder
    {
        public static void PrintInReverseOrder()
        {
            string str;
            int l = 0;

            Console.Write("\n\nprint individual characters of string in reverse order :\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            l = str.Length - 1;
            Console.Write("The characters of the string in reverse are : \n");
            while (l >= 0)
            {
                Console.Write("{0} ", str[l]);
                l--;
            }
            Console.Write("\n\n");
        }
    }
}