using System;

namespace Static_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 3, 2);
            Point point2 = new Point(2, 1, 3);

            Console.WriteLine($"p1+p2= {point1 + point2}");
            Console.WriteLine($"p1-p2= {point1 - point2}");
            Console.WriteLine($"p1*p2= {point1 * point2}");
            Console.WriteLine($"p1/p2= {point1 / point2}");

            Console.WriteLine($"p1++ = {++point1}");
            Console.WriteLine($"p2++ = {++point2}");

            Console.WriteLine($"p1-- = {--point1}");
            Console.WriteLine($"p2-- = {--point2}");

            Console.WriteLine(point1.ToString());
            Console.WriteLine(point2.ToString());

            Console.WriteLine(point1.Equals(point2));
            Console.WriteLine(point2.Equals(point1));

            Console.WriteLine(point1.GetHashCode());
            Console.WriteLine(point2.GetHashCode());
            Console.ReadKey();
        }
    }
}
