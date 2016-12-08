using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablePractice
{
    internal class HashTable
    {
        private static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4 };
            int resultIndex = BinarySearchPractice(number, 3);
        }

        public static int BinarySearchPractice01(int[] number, int key)
        {
            int resultIndex = -1;
            if (number == null)
                return resultIndex;
            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] == key)
                    return resultIndex = i;
            }
            return resultIndex;
        }

        public static int BinarySearchPractice02(int[] number, int key)
        {
            int resultIndex = -1;
            if (number == null)
                return resultIndex;
            for (int i = 0; i < number.Length - 1; i++)
            {
                if (number[i] == key)
                    return resultIndex = i;
            }
            return resultIndex;
        }
    }
}