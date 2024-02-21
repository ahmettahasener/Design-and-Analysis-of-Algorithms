using System;

namespace Algorithm_Homework_1
{
    internal class DivideAndConquerHard
    {
        public static void Main(string[] args)
        {
            Point[] points = new Point[]
            {
            new Point(1, 2),
            new Point(4, 6),
            new Point(7, 8),
            new Point(9, 10),
            new Point(3, 5)
            };

            double closestDistance = ClosestPairDistance(points);
            Console.WriteLine("The closest pair of points distance is: " + closestDistance);
        }
        public static double ClosestPairDistance(Point[] points)
        {
            double minDistance = double.PositiveInfinity;

            // Brute-force approach to find the closest pair of points
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = EuclideanDistance(points[i], points[j]);
                    minDistance = Math.Min(minDistance, distance);
                }
            }

            return minDistance;
        }

        private static double EuclideanDistance(Point a, Point b)
        {
            double dx = a.X - b.X;
            double dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
public class Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
}
