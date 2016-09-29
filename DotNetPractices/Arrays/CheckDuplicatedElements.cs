using System;

namespace DotNetPractices.Arrays
{
    public class CheckDuplicatedElements
    {
        public static void DuplicatedElements()
        {
            int[] arr1 = new int[100];
            int i, j, n, ctr = 0;

            Console.Write("\n\nCount total number of duplicate elements in an array:\n");
            Console.Write("---------------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*Finds duplicate elements in the array */
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    /*Increment the counter when the seaarch value is duplicate.*/
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                        break;
                    }
                }
            }

            Console.Write("\nTotal number of duplicate elements found in the array is : {0}\n\n", ctr);
        }
    }
}