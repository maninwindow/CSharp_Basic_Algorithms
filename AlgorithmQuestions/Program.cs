﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Reverse Integer
            //int data = -3243254;
            //Array.ReverseInteger_Solution01(data);
            //Array.ReverseInteger_Solution02(data);

            //Check duplicates and return the lengs of Array elements.
            int[] nums = { 1, 1, 1, 4, 4, 4, 10, 10, 1, 10 };
            //Array.RemoveDuplicates_Solution01(nums);
            //Array.RemoveDuplicates_Solution02(nums);
            Array.FindDisappearedNumbers(nums);
        }
    }
}