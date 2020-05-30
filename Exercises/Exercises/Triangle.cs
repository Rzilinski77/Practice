using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class Triangle
    {
        public int SideOneLength { get; set; }
        public int SideTwoLength { get; set; }
        public int SideThreeLength { get; set; }

        public Triangle(int sideOne, int sideTwo, int sideThree)
        {
            SideOneLength = sideOne;
            SideTwoLength = sideTwo;
            SideThreeLength = sideThree;
        }

        public static int CalculatePerimeter(Triangle triangle)
        {
            int perimeter = triangle.SideOneLength + triangle.SideTwoLength + triangle.SideThreeLength;

            return perimeter;
        }

        public static double CalculateArea(Triangle triangle)
        {
            double a = triangle.SideOneLength;
            double b = triangle.SideTwoLength;
            double c = triangle.SideThreeLength;
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a)*(s - b)*(s - c));
            return area;
        }
    }
}
