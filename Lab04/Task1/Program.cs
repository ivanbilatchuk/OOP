using System;
using Task1;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter coordinates <topLeftX> <topLeftY> <bottomRightX> <bottomRightY>:");
        string[] input = Console.ReadLine().Split(' ');
        int topLeftX = int.Parse(input[0]);
        int topLeftY = int.Parse(input[1]);
        int bottomRightX = int.Parse(input[2]);
        int bottomRightY = int.Parse(input[3]);
        Point point1 = new Point(topLeftX, topLeftY);
        Point point2 = new Point(bottomRightX, bottomRightY);
        Rectangle rectangle = new Rectangle(point1, point2);
        Console.WriteLine("Enter number of points:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter point <x> <y>:");
            string[] points = Console.ReadLine().Split(' ');
            int x = int.Parse(points[0]);
            int y = int.Parse(points[1]);
            Point point = new Point(x, y);
            Console.WriteLine(rectangle.Contains(point));   
        }    
    }
}