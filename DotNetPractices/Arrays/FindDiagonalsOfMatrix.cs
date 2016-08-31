using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.Arrays
{
    public class FindDiagonalsOfMatrix
    {
        public static void SumOfRightDiagonals()
        {
            int i, j, sum = 0, n;
            int[,] arr1 = new int[50, 50];

            Console.Write("\n\nFind sum of right diagonals of a matrix :\n");
            Console.Write("---------------------------------------\n");

            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == j) sum = sum + arr1[i, j];
                }
            }

            Console.Write("The matrix is :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0} ", arr1[i, j]);
                Console.Write("\n");
            }

            Console.Write("Addition of the right Diagonal elements is :{0}\n", sum);
        }

        public static void SumOfLeftDiagonals()
        {
            int i, j, sum = 0, n, m = 0;
            int[,] arr1 = new int[50, 50];

            Console.Write("\n\nFind sum of left diagonals of a matrix :\n");
            Console.Write("--------------------------------------------\n");

            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}  ", arr1[i, j]);
                Console.Write("\n");
            }
            // calculate the sum of left diagonals
            for (i = 0; i < n; i++)
            {
                m = m - 1;
                for (j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        sum = sum + arr1[i, j];
                    }
                }
            }
            Console.Write("Addition of the  left Diagonal elements is :{0}\n", sum);
        }
    }
}