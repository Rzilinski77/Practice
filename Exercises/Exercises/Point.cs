using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public static double CalculateDistance(int x, int y)
        {
            double distance = Math.Sqrt(x * x + y * y);
            return distance;
        }

        public static void CalculateMidpoint(Point other)
        {
            Console.WriteLine("Enter in two degrees to make another point!");
            int point3 = int.Parse(Console.ReadLine());
            int point4 = int.Parse(Console.ReadLine());

            Point midPoint = new Point((point3 + other.x) / 2, (point4 + other.y) / 2);

            Console.WriteLine($"The midpoint between ({other.x},{other.y}) and ({point3},{point4}) is ({midPoint.x},{midPoint.y})");
        }
    }

}
