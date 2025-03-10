using System;

namespace INHERITANCE
{
    public class Square : Figures
    {
        public Square(double length)
        {
            Length = length;
        }

        public override void CalculateArea()
        {
            double area = Length * Length;
            Console.WriteLine($"Area of Square: {area}");
        }

        public override void CalculatePerimeter()
        {
            double perimeter = 4 * Length;
            Console.WriteLine($"Perimeter of Square: {perimeter}");
        }

        public static void PrintResult()
        {
            Console.WriteLine("Static method of Square class");
        }
    }
}
