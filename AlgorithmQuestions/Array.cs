using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions
{
    public class Array
    {
        /**
            Rverse digits of an integer
            Example1: x = 123, return 321
            Example2: x = -123, return -321

            Have you thought about this?
            Here are some good questions to ask before coding. Bonus points for you if you have already thought through this!
            If the integer's last digit is 0, what should the output be? ie, cases such as 10, 100.
            Did you notice that the reversed integer might overflow? Assume the input is a 32-bit integer, then the reverse of 1000000003 overflows. How should you handle such cases?
            For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
        **/

        public static int ReverseInteger_Solution01(int x)
        {
            int result = 0;

            while (x != 0)
            {
                int tail = x % 10;
                int newResult = result * 10 + tail;
                if ((newResult - tail) / 10 != result)
                { return 0; }
                result = newResult;
                x = x / 10;
            }

            return result;
        }

        public static int ReverseInteger_Solution02(int x)
        {
            long rev = 0;
            while (x != 0)
            {
                rev = rev * 10 + x % 10;
                x = x / 10;
                if (rev > int.MaxValue || rev < int.MinValue)
                    return 0;
            }
            return (int)rev;
        }

        /**
         * Question name: Two Sum
         * Tags: Array, Hash Table
         * Description: Given an array of integers,
         * return indices of the two numbers such that they add up to a specific target.
         * You may assume that each input would have exactly one solution.
         * Example:
         * Given nums = [2, 7, 11, 15], target = 9,
         * Because nums[0] + nums[1] = 2 + 7 = 9,
         * return [0, 1].
         * **/

        public int[] TwoSum(int[] nums, int target)
        {
            return nums;
        }

        /**
            Given a sorted array, remove the duplicates in place such that
            each element appear only once and return the new length.
            Do not allocate extra space for another array, you must do this in place with constant memory.
            For example,
            Given input array nums = [1,1,2],
            Your function should return length = 2,
            with the first two elements of nums being 1 and 2 respectively.
            It doesn't matter what you leave beyond the new length.
        **/

        public static Tuple<int, int> RemoveDuplicates_Solution01(int[] nums)
        {
            int duplicates = 0;
            if (nums.Length < 2)
                return new Tuple<int, int>(nums.Length, duplicates);
            var hashSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(nums[i]))
                    duplicates++;
                hashSet.Add(nums[i]);
            }
            return new Tuple<int, int>(hashSet.Count, duplicates);
        }

        public static int RemoveDuplicates_Solution02(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != nums[j]) nums[++j] = nums[i];
            return ++j;
        }

        /**
            Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array),
            some elements appear twice and others appear once.
            Find all the elements of [1, n] inclusive that do not appear in this array.
            Could you do it without extra space and in O(n) runtime?
            You may assume the returned list does not count as extra space.
            Example:
            Input: [4,3,2,7,8,2,3,1]
            Output:[5,6]
        **/

        //public IList<int> FindDisappearedNumbers(int[] nums)
        //{
        //}
    }
}