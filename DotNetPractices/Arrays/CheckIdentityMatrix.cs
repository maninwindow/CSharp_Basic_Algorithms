using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.Arrays
{
    public class CheckIdentityMatrix
    {
        public static void CheckIndentity()
        {
            int[,] arr1 = new int[50, 50];
            int i, j, r1, c1;

            Console.Write("\n\n Check whether a Given Matrix is an Identity Matrix :\n ");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write(" Input the orders(2x2, 3x3, ...) of squere matrix : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            c1 = r1;

            Console.Write(" Input elements in the matrix :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.Write(" element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write(" The matrix is :\n");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                    Console.Write(" {0}  ", arr1[i, j]);
                Console.Write("\n");
            }
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    if ((i == j && arr1[i, j] != 1) || (i != j && arr1[i, j] != 0))
                    {
                        goto label;
                    }
                }
            }
            Console.WriteLine(" The matrix is an Identity Matrix.\n\n");
            return;
        label:
            Console.WriteLine("\n The matrix is not an Identity Matrix\n\n");
        }
    }
}