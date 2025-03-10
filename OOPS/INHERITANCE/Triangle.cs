using System;

namespace INHERITANCE
{
    public class Triangle : Figures
    {
        private double SideA, SideB, SideC;

        public Triangle(double height, double width, double sideA, double sideB, double sideC)
        {
            Height = height;
            Width = width;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override void CalculateArea()
        {
            double area = 0.5 * Height * Width;
            Console.WriteLine($"Area of Triangle: {area}");
        }
        public void CalculatePermiter()
        {
            double perimeter = SideA + SideB+ SideC;
            Console.WriteLine($"Permiter of Triable is :{perimeter}");
        }

    }
}
