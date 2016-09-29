using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractices.Function
{
    public class CountNumberOfSpacesInString
    {
      public static int SpaceCount(string str)
        {
            int spcctr = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    spcctr++;
            }
            return spcctr;
        }
    }
}
