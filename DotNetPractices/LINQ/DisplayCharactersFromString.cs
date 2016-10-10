using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.LINQ
{
    public class DisplayCharactersFromString
    {
        public static void TestMethod()
        {
            string str;

            Console.Write("\nLINQ : Display the characters and frequency of character from giving string : ");
            Console.Write("\n----------------------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("\n");

            var FreQ = from x in str
                       group x by x into y
                       select y;
            Console.Write("The frequency of the characters are :\n");
            foreach (var ArrEle in FreQ)
            {
                Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
            }
        }
    }
}
