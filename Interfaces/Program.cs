using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        /**
         * Interface: Public set of members such as Properties, Methods, Events and Inidexers.
         *
         * **/

        private static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);
            Console.Read();
        }

        public static void DisplayPolygon(string polygonType, Square square)
        {
            Console.WriteLine("PolygonType is : " + polygonType);
            Console.WriteLine("Area is : " + square.GetArea());
            Console.WriteLine("SideLength is :" + square.SideLength);
            Console.WriteLine("Number of sides are :" + square.NumberOfSides);
        }
    }
}