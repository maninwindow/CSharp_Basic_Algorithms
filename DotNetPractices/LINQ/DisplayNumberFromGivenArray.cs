using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.LINQ
{
    public class DisplayNumberFromGivenArray
    {
        public static void TestMethod()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");
            Console.Write("---------------------------------------------------------------------\n");
            Console.Write("The numbers in the array  are : \n");
            Console.Write(" 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2\n");

            var n = from x in arr1
                    group x by x into y
                    select y;
            Console.WriteLine("\nThe number and the Frequency are : \n");
            foreach (var arrNo in n)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            }
            Console.WriteLine("\n");
        }
    }
}
