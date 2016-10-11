using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.LINQ
{
    public class AcceptAndDisplayTheMembers
    {
        public static void TestMethod()
        {
            int i = 0;
            int memlist, n, m;
            List<int> templist = new List<int>();
            Console.Write("\nLINQ : Accept the members of a list and display the members more than a specific value : ");
            Console.Write("\n----------------------------------------------------------------------------------------\n");

            Console.Write("Input the number of members in the List : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Member {0} : ", i);
                memlist = Convert.ToInt32(Console.ReadLine());
                templist.Add(memlist);
            }

            Console.Write("\nInput the value above you want to display the members of the List : ");
            m = Convert.ToInt32(Console.ReadLine());

            List<int> FilterList = templist.FindAll(x => x > m ? true : false);
            Console.WriteLine("\nThe numbers greater than {0} are : ", m);
            foreach (var num in FilterList)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
