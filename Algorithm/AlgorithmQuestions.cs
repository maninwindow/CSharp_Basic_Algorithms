using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class AlgorithmQuestions
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
    }
}