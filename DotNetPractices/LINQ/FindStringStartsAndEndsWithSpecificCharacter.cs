using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.LINQ
{
    public class FindStringStartsAndEndsWithSpecificCharacter
    {
        public static void TestMethod()
        {
            string chst, chen;
            char ch;
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
            Console.Write("\n-----------------------------------------------------------------------\n");
            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

            Console.Write("\nInput starting character for the string : ");
            ch = (char)Console.Read();
            chst = ch.ToString();
            Console.Write("\nInput ending character for the string : ");
            ch = (char)Console.Read();
            chen = ch.ToString();


            var _result = from x in cities
                          where x.StartsWith(chst)
                          where x.EndsWith(chen)
                          select x;
            Console.Write("\n\n");
            foreach (var city in _result)
            {
                Console.Write("The city starting with {0} and ending with {1} is : {2} \n", chst, chen, city);
            }

            Console.ReadLine();
        }
    }
}
