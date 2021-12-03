using System;

namespace consolItProger
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the area of a circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of a circle with radius {0} is equal to {1}", radius, area);
        }
    }
}