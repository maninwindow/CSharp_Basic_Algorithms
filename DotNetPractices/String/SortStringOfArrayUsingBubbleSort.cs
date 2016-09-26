using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.String
{
    public class SortStringOfArrayUsingBubbleSort
    {
        public static void SortStringUsingBubbleSort()
        {   
            string[] arr1;
            string temp;
            int n, i, j, l;

            Console.Write("\n\nSorts the strings of an array using bubble sort :\n");
            Console.Write("-----------------------------------------------------\n");
            Console.Write("Input number of strings :");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[n];
            Console.Write("Input {0} strings below :\n", n);
            for (i = 0; i < n; i++)
            {
                arr1[i] = Console.ReadLine();
            }
            l = arr1.Length;

            for (i = 0; i < l; i++)
            {
                for (j = 0; j < l - 1; j++)
                {
                    if (arr1[j].CompareTo(arr1[j + 1]) > 0)
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }
            Console.Write("\n\nAfter sorting the array appears like : \n");
            for (i = 0; i < l; i++)
            {
                Console.WriteLine(arr1[i] + " ");
            }
        }
    }
}
