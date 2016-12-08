using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class AlgorithmQuestions
    {
        public static int ReverseInteger(int data)
        {
            int rev = 0;
            int result = 0;
            if (data == 0)
                return result = 0;
            if (data > 0)
            {
                while (data > 0)
                {
                    int temp = data % 10;
                    rev = rev * 10 + temp;
                    data = data / 10;
                }
                return result = rev;
            }
            else
            {
                while (data < 0)
                {
                    Math.Abs(data);
                    int temp = data % 10;
                    rev = rev * 10 + temp;
                    data = data / 10;
                }
                return result = -rev;
            }
            return result;
        }

        public static int ReverseInteger_Online(int x)
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
    }
}