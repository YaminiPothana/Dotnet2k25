using System;

namespace INHERITANCE
{
    public class Circle : Figures
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void CalculateArea()
        {
            double area = Constants.PI * Radius * Radius;
            Console.WriteLine($"Area of Circle: {area}");
        }

        public void CalculateCircumference()
        {
            double circum = 3*Constants.PI * Radius;
            Console.WriteLine($"Circumference of Circle: {circum}");
        }
    }
}
