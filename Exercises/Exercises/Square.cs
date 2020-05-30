using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class Square
    {
        public int SideLength { get; set; }

        public Square(int sideLength)
        {
            SideLength = sideLength;
        }

        public static int CalculatePerimeter(int length)
        {
            int perimeter = length * 4;
            return perimeter;
        }

        public static int CalculateArea(int length)
        {
            int area = length * length;
            return area;
        }
    }


}
