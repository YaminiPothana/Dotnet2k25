using System;

namespace INHERITANCE
{
    public class Rectangle : Figures
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override void CalculateArea()
        {
            double area = Length * Width;
            Console.WriteLine($"Area of Rectangle: {area}");
        }

        public override void CalculatePerimeter()
        {
            double perimeter = 2 * (Length + Width);
            Console.WriteLine($"Perimeter of Rectangle: {perimeter}");
        }

        public static void Print()
        {
            Console.WriteLine("Static Method Of Rectangle Class");
        }
    }
}
