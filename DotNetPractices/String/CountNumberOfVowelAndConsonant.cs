using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.String
{
    public class CountNumberOfVowelAndConsonant
    {
        public static void CountVowelAndConsonant()
        {
            string str;
            int i, len, vowel, cons;

            Console.Write("\n\nCount total number of vowel or consonant :\n");
            Console.Write("----------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            vowel = 0;
            cons = 0;
            len = str.Length;

            for (i = 0; i < len; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    cons++;
                }
            }
            Console.Write("\nThe total number of vowel in the string is : {0}\n", vowel);
            Console.Write("The total number of consonant in the string is : {0}\n\n", cons);
        }
    }
}